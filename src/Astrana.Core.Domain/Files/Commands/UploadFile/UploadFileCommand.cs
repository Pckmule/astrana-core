/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Files.Queries.GetFileInfo;
using Astrana.Core.Domain.Models.Files;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using File = System.IO.File;

namespace Astrana.Core.Domain.Files.Commands.UploadFile
{
    public class UploadFileCommand : IUploadFileCommand
    {
        private readonly ILogger<UploadFileCommand> _logger;
        private readonly IGetFileInfoQuery _getFileInfoQuery;

        public readonly string FilesPath;
        public readonly string TemporaryFileUploadPath;

        public string FilesRootPath => FilesPath;

        public UploadFileCommand(ILogger<UploadFileCommand> logger, IWebHostEnvironment webHostEnvironment, IGetFileInfoQuery getFileInfoQuery)
        {
            _logger = logger;

            _getFileInfoQuery = getFileInfoQuery;

            FilesPath = Path.Combine(webHostEnvironment.ContentRootPath, Constants.Files.FilesDirectoryName);
            TemporaryFileUploadPath = Path.Combine(webHostEnvironment.ContentRootPath, Constants.Files.TemporaryDirectoryName, Constants.Files.TemporaryFileUploadDirectoryName);

            if (!Directory.Exists(TemporaryFileUploadPath))
                Directory.CreateDirectory(TemporaryFileUploadPath);
        }

        public async Task<ExecutionResult<List<UploadedFile>>> ExecuteAsync(List<IFormFile> files, Guid actioningUserId, Func<Stream, Dictionary<string, object>>? getMetadataFunction = null, Func<Stream, Stream>? compressionFunction = null)
        {
            var uploadedFiles = new List<UploadedFile>();

            if (files.Count < 1)
                return new ExecutionFailResult<List<UploadedFile>>(uploadedFiles, "No files provided to upload.");

            var validFiles = GetValidFiles(files);

            if (validFiles.Count < 1)
                return new ExecutionFailResult<List<UploadedFile>>(uploadedFiles, "File(s) upload failed.", "No valid files.");

            try
            {
                foreach (var validFile in validFiles)
                {
                    var fileId = Guid.NewGuid();
                    var fileInfo = _getFileInfoQuery.Execute(validFile);

                    var fileName = fileId + "." + fileInfo.Extension;
                    var temporaryLocalPath = Path.Combine(TemporaryFileUploadPath, fileName);

                    var uploadedFile = new UploadedFile(fileId, temporaryLocalPath, fileInfo);

                    await SaveToLocalFileSystemAsync(temporaryLocalPath, validFile);

                    // TODO: Make sure this actually works...
                    var virusScanResult = new AntiVirus.Scanner().ScanAndClean(temporaryLocalPath);

                    uploadedFile.VirusScanResult = virusScanResult.ToString();

                    if (uploadedFile.VirusScanResult == virusScanResult.ToString())
                    {
                        ApplyCompression(compressionFunction, validFile, temporaryLocalPath);

                        uploadedFile.Metadata = GetMetadata(getMetadataFunction, validFile);

                        MoveToVettedDirectory(temporaryLocalPath, fileName);

                        uploadedFiles.Add(uploadedFile);
                    }
                    else
                    {
                        File.Delete(temporaryLocalPath);

                        uploadedFiles.Add(uploadedFile);
                    }
                }

                return new ExecutionSuccessResult<List<UploadedFile>>(uploadedFiles, "File(s) upload successful.");
            }
            catch (Exception ex)
            {
                return new ExecutionFailResult<List<UploadedFile>>(uploadedFiles, "File(s) upload failed.", ErrorCodes.Default);
            }
        }

        private static Dictionary<string, object> GetMetadata(Func<Stream, Dictionary<string, object>>? getMetadataFunction, IFormFile validFile)
        {
            return getMetadataFunction == null ? new Dictionary<string, object>() : getMetadataFunction.Invoke(validFile.OpenReadStream());
        }

        private static void ApplyCompression(Func<Stream, Stream>? compressionFunction, IFormFile validFile, string temporaryLocalPath)
        {
            if (compressionFunction == null) 
                return;

            var bytes = GetStreamToByteArray(compressionFunction.Invoke(validFile.OpenReadStream()));

            if (bytes.Length < 1)
                return;

            if (!File.Exists(temporaryLocalPath))
                return;

            using var fileStream = File.Open(temporaryLocalPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            fileStream.Write(bytes, 0, bytes.Length);
            fileStream.Close();
        }

        private static byte[] GetStreamToByteArray(Stream compressedFileStream)
        {
            using var memoryStream = new MemoryStream();
            compressedFileStream.CopyTo(memoryStream);
            return memoryStream.ToArray();
        }

        private void MoveToVettedDirectory(string temporaryLocalPath, string fileName)
        {
            File.Move(temporaryLocalPath, Path.Combine(FilesPath, fileName));
        }

        private static async Task SaveToLocalFileSystemAsync(string temporaryLocalPath, IFormFile validFile)
        {
            await using var stream = new FileStream(temporaryLocalPath, FileMode.Create);
            await validFile.CopyToAsync(stream);
        }

        private ValidationResult ValidateFormFile(IFormFile file)
        {
            if (file.Length <= 0)
                return new ValidationResult(outcome: ValidationOutcome.Failed, message: "File has not content.");

            var fileExtension = _getFileInfoQuery.Execute(file).Extension;

            if (Constants.Files.SupportedFileTypes.All(extension => !string.Equals(fileExtension, extension, StringComparison.InvariantCultureIgnoreCase)))
                return new ValidationResult(outcome: ValidationOutcome.Failed, message: "File type is not supported");

            return new ValidationResult(outcome: ValidationOutcome.Passed);
        }

        private List<IFormFile> GetValidFiles(IEnumerable<IFormFile> files)
        {
            return files.Where(file => ValidateFormFile(file).IsSuccess).ToList();
        }
    }
}
