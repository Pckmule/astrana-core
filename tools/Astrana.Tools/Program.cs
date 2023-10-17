/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration;
using Astrana.Core.Utilities;
using System.Reflection;

namespace Astrana.Tools;

public class Program
{
    private const string CmdId_SetAppSettingsFile = "1";

    private const string CmdId_StoreEncryptionKey = "2";
    private const string CmdId_StoreInitializationVector = "3";
    private const string CmdId_EncryptAppSettingsFile = "4";

    private const string CmdId_GenerateApiIssuerSigningKey = "5";

    private const string CmdId_GenerateEmojiConfigFile = "6";

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

                case CmdId_GenerateEmojiConfigFile:
                {
                    //  D:\repos\Astrana\Pckmule\astrana-core\src\Astrana.Core\Emoji\emoji.config.json
                    Console.WriteLine("Enter path to the config file: ");
                    var configFilePath = "D:\\repos\\Astrana\\Pckmule\\astrana-core\\src\\Astrana.Core\\Emoji\\emoji.config.json"; //Console.ReadLine();

                    //  D:\repos\Astrana\Pckmule\astrana-core\src\Astrana.Core\Emoji\openmoji.json
                    Console.WriteLine("Enter path to the source data file: ");
                    var sourceFilePath = "D:\\repos\\Astrana\\Pckmule\\astrana-core\\src\\Astrana.Core\\Emoji\\openmoji.json"; // Console.ReadLine();

                    var outputDirectoryPath = Path.Join(workingDirectory, "output");

                    Directory.CreateDirectory(Path.Join(workingDirectory, "output"));

                    new GenerateEmojiConfig(configFilePath, sourceFilePath, outputDirectoryPath).Execute();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Emoji configuration has been generated.");
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
        Console.WriteLine($"{CmdId_GenerateEmojiConfigFile}. Generate Emoji Configuration File");
        Console.WriteLine();

        return Console.ReadLine();
    }


    public static void Parse()
    {
        var data = File.ReadAllLines("D:\\repos\\Astrana\\Pckmule\\astrana-core\\tools\\Astrana.Tools\\temp.txt");

        var list = data.Select(line => line.Split(" ")[0].Trim()).Order().ToList();

        foreach (var line in list)
        {
            Console.WriteLine("new(Guid.NewGuid(), \"" + line.ToTitleCase() + "\", \"feeling_name_" + line + "\", \"" + line + "\", \"\", \"\"),");
        }
    }
}