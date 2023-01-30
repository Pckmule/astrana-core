/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Reflection;
using Astrana.Core.Configuration;

namespace Astrana.Tools;

public class Program
{
    private const string CmdId_SetAppSettingsFile = "1";

    private const string CmdId_StoreEncryptionKey = "2";
    private const string CmdId_StoreInitializationVector = "3";
    private const string CmdId_EncryptAppSettingsFile = "4";

    private const string CmdId_GenerateApiIssuerSigningKey = "5";

    private static async Task Main(string[] args)
    {
        var workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // TODO: Make this determined at runtime.
        var settingsFileTemplatePath = "D:\\repos\\Astrana\\astrana-core\\tools\\Astrana.Tools\\appsettings.ClearTextExample.json";
        
        var choice = ReadChoice();

        while (!string.IsNullOrWhiteSpace(choice))
        {
            switch (choice)
            {
                case CmdId_SetAppSettingsFile:
                {
                    Console.WriteLine("Enter the location of the AppSettings.json file.");
                    settingsFileTemplatePath = Console.ReadLine() ?? settingsFileTemplatePath;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Path to the AppSettings.json has been set.");
                    Console.ResetColor();
                }
                    break;

                case CmdId_StoreEncryptionKey:
                    EncryptionUtility.StoreEncryptionKey();
                    EncryptionUtility.StoreInitializationVector();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Encryption Key has been set.");
                    Console.ResetColor();
                    break;

                case CmdId_StoreInitializationVector:
                    EncryptionUtility.StoreInitializationVector();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Initialization Vector has been set.");
                    Console.ResetColor();
                    break;

                case CmdId_EncryptAppSettingsFile:
                {
                    var outputFilePath = Path.Join(workingDirectory, "output", "appsettings.json");

                    Directory.CreateDirectory(Path.Join(workingDirectory, "output"));
                    File.Copy(settingsFileTemplatePath, outputFilePath, true);

                    var configurationFilePaths = new List<string> { outputFilePath };

                    await new JsonConfigurationEncrypter().EncryptAsync(configurationFilePaths);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("AppSettings.json has been encrypted.");
                    Console.ResetColor();
                }
                    break;

            }

            Console.WriteLine();
            choice = ReadChoice();
        }
    }

    public static string? ReadChoice()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine($"{CmdId_SetAppSettingsFile}. Specify AppSettings.json file location");
        Console.WriteLine($"{CmdId_StoreEncryptionKey}. Store Encryption Key");
        Console.WriteLine($"{CmdId_StoreInitializationVector}. Store Initialization Vector");
        Console.WriteLine($"{CmdId_EncryptAppSettingsFile}. Encrypt the AppSettings.json");
        Console.WriteLine($"{CmdId_GenerateApiIssuerSigningKey}. Generate API Issuer Signing Key");
        Console.WriteLine();

        return Console.ReadLine();
    }
}