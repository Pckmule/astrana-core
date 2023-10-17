/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Constants
{
    public static class Files
    {
        public const string FilesDirectoryName = "files";

        public const string TemporaryDirectoryName = "temp";
        public const string TemporaryFileUploadDirectoryName = "files";


        public static readonly IReadOnlyList<string> SupportedDocumentFileTypes = new List<string>
        {
            "txt", "md", "pdf", "doc", "docx", "ppt", "pptx", "xls", "xlsx"
        };

        public static readonly IReadOnlyList<string> SupportedImageFileTypes = new List<string>
        {
            "gif", "jpg", "jpeg", "png", "webp"
        };

        public static readonly IReadOnlyList<string> SupportedAudioFileTypes = new List<string>
        {
            "mp3", "wav", "ogg"
        };

        public static readonly IReadOnlyList<string> SupportedVideoFileTypes = new List<string>
        {
            "mov", "mpeg", "mod", "mpa", "mpe", "mpeg", "mp2", "mp2v", "mp3", "mpg", "mpv2", "mp4", "mp4v", "mov", "mqv", "movie"
        };

        public static IReadOnlyList<string> SupportedFileTypes
        {
            get
            {
                var fileTypes = new List<string>();

                fileTypes.AddRange(SupportedDocumentFileTypes);
                fileTypes.AddRange(SupportedImageFileTypes);
                fileTypes.AddRange(SupportedAudioFileTypes);
                fileTypes.AddRange(SupportedVideoFileTypes);

                return fileTypes;
            }
        }

        public static IReadOnlyList<string> SupportedFileTypesWithDimensions
        {
            get
            {
                var fileTypes = new List<string>();

                fileTypes.AddRange(SupportedImageFileTypes);
                fileTypes.AddRange(SupportedVideoFileTypes);

                return fileTypes;
            }
        }
    }
}
