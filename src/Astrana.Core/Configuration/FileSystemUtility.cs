/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Configuration
{
    public static class FileSystemUtility
    {
        public const string DefaultConfigurationDirectoryName = "Conf";
        public const string AstranaApplicationDirectoryName = Core.Constants.Application.Name;

        private const string LinuxEtcDirectoryPath = "/etc";
        private const string LinuxOptDirectoryPath = "/opt";
        
        public static string SystemDrive
        {
            get
            {
                if (OperatingSystem.IsWindows())
                    return Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) ?? "C:";

                if (OperatingSystem.IsMacOS())
                    return "";

                if (OperatingSystem.IsLinux())
                    return "";

                throw new NotSupportedException();
            }
        }

        public static string? SystemHomeDirectoryPath =>
            OperatingSystem.IsLinux() || OperatingSystem.IsMacOS()
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

        public static string InstallationDirectoryPath
        {
            get
            {
                if (OperatingSystem.IsWindows())
                    return Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), AstranaApplicationDirectoryName);

                if (OperatingSystem.IsMacOS())
                    return Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), AstranaApplicationDirectoryName);

                if (OperatingSystem.IsLinux())
                    return Path.Join(LinuxOptDirectoryPath, AstranaApplicationDirectoryName).ToLower();

                throw new NotSupportedException();
            }
        }

        public static string GetSecureSettingsDirectoryPath
        {
            get
            {
                if (OperatingSystem.IsWindows())
                    return Path.Join(InstallationDirectoryPath, DefaultConfigurationDirectoryName);

                if (OperatingSystem.IsMacOS())
                    return Path.Join(InstallationDirectoryPath, DefaultConfigurationDirectoryName);

                if (OperatingSystem.IsLinux())
                    return Path.Join(LinuxEtcDirectoryPath, AstranaApplicationDirectoryName).ToLower();

                throw new NotSupportedException();
            }
        }
    }
}