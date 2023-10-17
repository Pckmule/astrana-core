#Requires -PSEdition Core
#Requires -RunAsAdministrator

Param(
	[Parameter(Mandatory = $True)]
	[Alias('c')]
	[ValidateSet("setconfig", "preinstallcheck", "install", "installpsmodules", IgnoreCase = $True)]
	[string]$Command,
	
	[Alias('n')]
	[string]$InstanceName = "Astrana",
	
	[Alias('re')]
	[switch]$RemoveExisting,
	
	[Alias('i')]
	[switch]$InteractiveMode,
	
	[Alias('gcf')]
	[switch]$GenerateConfigFile,
	
	[Alias('v')]
	[switch]$LogVerbose,
	
	[Alias('q')]
	[switch]$LogQuiet
)

$ScriptDirectory = $PWD

if($IsWindows)
{
	Add-Type -AssemblyName PresentationFramework
}

$ScriptMajorVersion = 1
$ScriptMinorVersion = 0
$ScriptPatchVersion = 0

$ScriptVersion = "$($ScriptMajorVersion).$($ScriptMinorVersion).$($ScriptPatchVersion)"

Write-Host "Astrana Installation Utility $ScriptVersion" -ForegroundColor White
Write-Host ""

$PlatformName = "Unknown"

if($IsWindows)
{
	$PlatformName = "Windows"
}
elseif($IsLinux)
{
	$PlatformName = "Linux"
}
elseif($MacOS)
{
	$PlatformName = "MacOS"
}

$PreparingToInstallMessage = "Preparing to install Astrana for $PlatformName"
$BeginningInstallMessage = "Installing Astrana for $($PlatformName)... "

$InstallerConfigurationFileName = "installer.config"
$InstallerConfigurationFilePath = (Join-Path -Path $ScriptDirectory -ChildPath $InstallerConfigurationFileName)

$InstallerConfigurationFileRootElementName = "Astrana"
$InstallerConfigurationFileNamespace = "https://www.astrana.org"
$InstallerConfigurationFileDtdUrl = "https://www.astrana.org/xml/astrana.dtd"
$InstallerConfigurationFileschemaLocation = "https://www.astrana.org/xml/astrana.xsd"

$PackageExtractionPath = [IO.Path]::Combine($ScriptDirectory, "setup", "package")
$PackageApplicationExtractionPath = [IO.Path]::Combine($PackageExtractionPath, "application")
$PackageDatabaseExtractionPath = [IO.Path]::Combine($PackageExtractionPath, "database")

$PLACEHOLDER_DATABASE_PROVIDER_ID = "{DATABASE_PROVIDER_ID}"
$PLACEHOLDER_DATABASE_NAME = "{DATABASE_NAME}"
$PLACEHOLDER_DATABASE_DATA_PATH = "{DATABASE_DATA_PATH}"
$PLACEHOLDER_DATABASE_LOGS_DATA_PATH = "{DATABASE_LOGS_DATA_PATH}"
$PLACEHOLDER_DATABASE_USERNAME = "{DATABASE_USERNAME}"
$PLACEHOLDER_DATABASE_PASSWORD = "{DATABASE_PASSWORD}"

$AppSettingsFileName = "appsettings.json"

$DropDatabaseScriptFileName = "{DATABASE_PROVIDER_ID}_DropDatabase.sql"
$CreateDatabaseScriptFileName = "{DATABASE_PROVIDER_ID}_CreateDatabase.sql"
$CreateDatabaseUserScriptFileName = "{DATABASE_PROVIDER_ID}_CreateDatabaseUser.sql"
$ApplyDatabaseMigrationsScriptFileName = "{DATABASE_PROVIDER_ID}_ApplyMigrations.sql"

$YesNoChoices = [ordered]@{
	No = @{ Id = "no"; FriendlyName = "No"; }
	Yes = @{ Id = "yes"; FriendlyName = "Yes"; }
}

$WebServerProviders = [ordered]@{
	Self = @{ Id = "self"; FriendlyName = "Kestrel"; }
	IIS = @{ Id = "iis"; FriendlyName = "Internet Information Services (IIS)"; }
	NGINX = @{ Id = "nginx"; FriendlyName = "NGINX"; }
}

$RevereseProxyProviders = [ordered]@{
	IIS = @{ Id = "iis"; FriendlyName = "Internet Information Services (IIS)"; }
	NGINX = @{ Id = "nginx"; FriendlyName = "NGINX"; }
}

$DatabaseProviders = [ordered]@{
	MSSQLServer = @{ Id = "MSSqlServer"; FriendlyName = "Microsoft SQL Server"; }
	Postgresql = @{ Id = "PostgreSQL"; FriendlyName = "PostgreSQL"; }
	MySQL = @{ Id = "MySQL"; FriendlyName = "MySQL"; }
}

$Languages = [ordered]@{
	English = @{ Id = "en"; FriendlyName = "English"; }
	French = @{ Id = "fr-FR"; FriendlyName = "French"; }
	Chinese = @{ Id = "zh-CN"; FriendlyName = "Chinese"; }
}

$Countries = [ordered]@{
	Australia = @{ Id = "au"; FriendlyName = "Australia"; }
	SouthAfrica = @{ Id = "za"; FriendlyName = "South Africa"; }
	China = @{ Id = "cn"; FriendlyName = "China"; }
}

$SslCertificateProviders = [ordered]@{
	Self = @{ Id = "self"; FriendlyName = "Self Signed"; }
	Vendor = @{ Id = "vendor"; FriendlyName = "Vendor"; }
}

function InstallPowerShellModuleIfNotExists
{
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$ModuleName
	)

	if (Get-Module -ListAvailable -Name $ModuleName) 
	{
		Write-Host "$ModuleName is installed."
	} 
	else 
	{
		Install-Module $ModuleName -Scope CurrentUser
	}
}

function InstallPowerShellModules
{
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseProvider,
		
		[Parameter(Mandatory = $True)]
		[string]
		$WebServerProvider
	)
	
	$DatabaseProviderLowered = $DatabaseProvider.ToLower()
	$WebServerProviderLowered = $WebServerProvider.ToLower()
	
	if($DatabaseProviderLowered -eq $DatabaseProvider.MSSQLServer.Id)
	{
		InstallPowerShellModuleIfNotExists "SQLServer"
	}
	elseif($DatabaseProviderLowered -eq $DatabaseProvider.Postgresql.Id)
	{
		InstallPowerShellModuleIfNotExists "SQLServer"
	}
	elseif($DatabaseProviderLowered -eq $DatabaseProvider.MySQL.Id)
	{
		InstallPowerShellModuleIfNotExists "SQLServer"
	}
}

function Ensure-ExecutableExists
{
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$ExecutableName,

		[string]
		$MinimumVersion = ""
	)

	if ((Get-Command $ExecutableName -ErrorAction SilentlyContinue) -eq $null) 
	{ 
		Write-Host "  ✗" -ForegroundColor Red -NoNewLine
	}
	else
	{ 
		Write-Host "  ✓" -ForegroundColor Green -NoNewLine
		
		$CurrentVersion = (Get-Command -Name $ExecutableName -ErrorAction Stop).Version

		if ($MinimumVersion)
		{
			$RequiredVersion = [version]$MinimumVersion

			if ($CurrentVersion -lt $RequiredVersion)
			{
				throw "$($ExecutableName) version $($CurrentVersion) does not meet requirements"
			}
		}
	}
	
	Write-Host " $ExecutableName"
	
}

function CheckPrequisites
{
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		[ValidateSet("create-configuration", "preinstallcheck", "execute-install", IgnoreCase = $True)]
		$Purpose
	)

	Write-Host "Checking Prerequisites... " -ForegroundColor DarkCyan
	
	$PrequisitesSoftware = [System.Collections.ArrayList]@()
	
	if($IsWindows)
	{
		if($Purpose -eq "create-configuration")
		{
			$PrequisitesSoftware += "powershell"
			$PrequisitesSoftware += "openssl"
		}
		elseif($Purpose -eq "preinstallcheck" -or $Purpose -eq "execute-install")
		{
			$PrequisitesSoftware += "powershell"
			$PrequisitesSoftware += "icacls"
			$PrequisitesSoftware += "openssl"
			
			if($config.Database.Provider -eq $DatabaseProviders.MSSQLServer.Id)
			{
				$PrequisitesSoftware += "sqlcmd"
			}			
			elseif($config.Database.Provider -eq $DatabaseProviders.Postgresql.Id)
			{
				$PrequisitesSoftware += "psql"
			}
			elseif($config.Database.Provider -eq $DatabaseProviders.MySQL.Id)
			{
				$PrequisitesSoftware += "mysql"
			}
		}
	}
	elseif($IsLinux)
	{
		if($Purpose -eq "create-configuration")
		{
			$PrequisitesSoftware += "openssl"
		}
		elseif($Purpose -eq "preinstallcheck" -or $Purpose -eq "execute-install")
		{
			$PrequisitesSoftware += "openssl"
			
			if($config.Database.Provider -eq $DatabaseProviders.Postgresql.Id)
			{
				$PrequisitesSoftware += "psql"
			}
			elseif($config.Database.Provider -eq $DatabaseProviders.MySQL.Id)
			{
				$PrequisitesSoftware += "mysql"
			}
		}
	}
	elseif($IsMacOS)
	{
		if($Purpose -eq "create-configuration")
		{
			$PrequisitesSoftware += "openssl"
		}
		elseif($Purpose -eq "preinstallcheck" -or $Purpose -eq "execute-install")
		{
			$PrequisitesSoftware += "openssl"
			
			if($config.Database.Provider -eq $DatabaseProviders.Postgresql.Id)
			{
				$PrequisitesSoftware += "psql"
			}
			elseif($config.Database.Provider -eq $DatabaseProviders.MySQL.Id)
			{
				$PrequisitesSoftware += "mysql"
			}
		}
	}
	
	foreach ($executable in $PrequisitesSoftware)
	{
		Ensure-ExecutableExists $executable
	}
	
	return $True
}

$XmlSettings = New-Object System.Xml.XmlWriterSettings
$XmlSettings.Indent = $True
$XmlSettings.IndentChars = "`t"

function CreateDefaultConfigurationFile
{
	$xmlWriter = [System.XML.XmlWriter]::Create((Join-Path -Path $ScriptDirectory -ChildPath $InstallerConfigurationFileName), $XmlSettings)
		
	$xmlWriter.WriteStartDocument()
	
	$xmlWriter.WriteComment("
	This configuration file is used by the Astrana Installation tools to install and configure an Astrana instance.

	Sections:

		Peer
		
		WebServer
			Host
				Provider [Self | IIS | NGINX | Kestrel]
				
				RevereseProxy
					Provider [IIS | NGINX]
				
			SslCertificate
				Provider [Self | Vendor]
		
		Database
			Provider [MSSQLServer | Postgresql | MySQL]
			
		Application
")
	
	$xmlWriter.WriteStartElement("Astrana")
	
	# TODO: Add Namespaces back
	
	# $xmlWriter.WriteStartElement("Astrana", $InstallerConfigurationFileNamespace)
	# $xmlWriter.WriteAttributeString("xmlns", "xsi", $null, "http://www.w3.org/2001/XMLSchema-instance");
	# $xmlWriter.WriteAttributeString("xmlns", "schemaLocation", $null, $InstallerConfigurationFileschemaLocation);
	
	$xmlWriter.WriteStartElement("Peer")
	
		$xmlWriter.WriteElementString("Language", "en")
		WriteEmptyElementString $xmlWriter "RegionCountry"
		WriteEmptyElementString $xmlWriter "TimeZone"
		
		WriteEmptyElementString $xmlWriter "FirstName"
		WriteEmptyElementString $xmlWriter "LastName"
		WriteEmptyElementString $xmlWriter "EmailAddress"
		WriteEmptyElementString $xmlWriter "PhoneCode"
		WriteEmptyElementString $xmlWriter "PhoneNumber"
		
	$xmlWriter.WriteEndElement()
		
	$xmlWriter.WriteStartElement("WebServer")
	
		$xmlWriter.WriteElementString("ContainerName", "Astrana")
		
		$xmlWriter.WriteStartElement("Host")
		
			$xmlWriter.WriteElementString("Provider", "Self")
			$xmlWriter.WriteElementString("Domain", "localhost")
			$xmlWriter.WriteElementString("Port", "80")
			
			$xmlWriter.WriteStartElement("RevereseProxy")
			$xmlWriter.WriteAttributeString("enabled", "false")
			
				WriteEmptyElementString $xmlWriter "Provider"
				
			$xmlWriter.WriteEndElement()
			
		$xmlWriter.WriteEndElement()
			
		$xmlWriter.WriteStartElement("SslCertificate")
			
			$xmlWriter.WriteElementString("Provider", "Self")
			WriteEmptyElementString $xmlWriter "Location"
		
		$xmlWriter.WriteEndElement()
			
	$xmlWriter.WriteEndElement()
	
	$xmlWriter.WriteStartElement("Database")
	
		WriteEmptyElementString $xmlWriter "Provider"
		$xmlWriter.WriteElementString("Name", "astrana")
		$xmlWriter.WriteElementString("HostAddress", "localhost")
		WriteEmptyElementString $xmlWriter "HostPort"
		$xmlWriter.WriteElementString("UserName", "astranu")
		WriteEmptyElementString $xmlWriter "Password"
		
	$xmlWriter.WriteEndElement()
	
	$xmlWriter.WriteStartElement("Application")
	
		WriteEmptyElementString $xmlWriter "PackageArchiveName"
		
	$xmlWriter.WriteEndElement()
	
	$xmlWriter.WriteEndElement()

	$xmlWriter.WriteEndDocument()
	$xmlWriter.Flush()
	$xmlWriter.Close()
}

function UpdateConfigurationFile
{
	Param
	(
		[Parameter(Mandatory = $True)]
		[hashtable]
		$Configuration
	)

	Write-Host "Saving configuration file changes... " -ForegroundColor DarkCyan -NoNewLine
	
	if(-not(Test-Path -Path $InstallerConfigurationFilePath -PathType leaf))
	{
		Write-Host "Failed" -ForegroundColor Red
		Throw "The Installer.config file couold not be found."
	}
	
	$ConfigXml = New-Object System.Xml.XmlDocument	
	$ConfigXml.PreserveWhitespace = $True
	
	$ConfigXml.Load($InstallerConfigurationFilePath)
	
	if(-not($ConfigXml -eq $null))
	{
		$ConfigXml.SelectSingleNode("//Astrana/Peer/Language").InnerText = ("" + $Configuration.Peer.Language).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Peer/RegionCountry").InnerText = ("" + $Configuration.Peer.RegionCountry).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Peer/TimeZone").InnerText = ("" + $Configuration.Peer.TimeZone).Trim()
		
		$ConfigXml.SelectSingleNode("//Astrana/Peer/FirstName").InnerText = ("" + $Configuration.Peer.FirstName).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Peer/LastName").InnerText = ("" + $Configuration.Peer.LastName).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Peer/EmailAddress").InnerText = ("" + $Configuration.Peer.EmailAddress).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Peer/PhoneCode").InnerText = ("" + $Configuration.Peer.PhoneCode).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Peer/PhoneNumber").InnerText = ("" + $Configuration.Peer.PhoneNumber).Trim()
		
		$ConfigXml.SelectSingleNode("//Astrana/WebServer/ContainerName").InnerText = ("" + $Configuration.WebServer.ContainerName).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/WebServer/Host/Provider").InnerText = ("" + $Configuration.WebServer.Host.Provider).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/WebServer/Host/Domain").InnerText = ("" + $Configuration.WebServer.Host.Domain).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/WebServer/Host/Port").InnerText = ("" + $Configuration.WebServer.Host.Port).Trim()
				
		$ConfigXml.SelectSingleNode("//Astrana/WebServer/Host/RevereseProxy").SetAttribute("enabled", ("" + $Configuration.WebServer.Host.RevereseProxy.Enabled).Trim())
		$ConfigXml.SelectSingleNode("//Astrana/WebServer/Host/RevereseProxy/Provider").InnerText = ("" + $Configuration.WebServer.Host.RevereseProxy.Provider).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/WebServer/SslCertificate/Provider").InnerText = ("" + $Configuration.WebServer.SslCertificate.Provider).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/WebServer/SslCertificate/Location").InnerText = ("" + $Configuration.WebServer.SslCertificate.Location).Trim()
		
		$ConfigXml.SelectSingleNode("//Astrana/Database/Provider").InnerText = ("" + $Configuration.Database.Provider).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Database/Name").InnerText = ("" + $Configuration.Database.Name).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Database/HostAddress").InnerText = ("" + $Configuration.Database.HostAddress).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Database/HostPort").InnerText = ("" + $Configuration.Database.HostPort).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Database/UserName").InnerText = ("" + $Configuration.Database.UserName).Trim()
		$ConfigXml.SelectSingleNode("//Astrana/Database/Password").InnerText = ("" + $Configuration.Database.Password).Trim()
				
		$ConfigXml.SelectSingleNode("//Astrana/Application/PackageArchiveName").InnerText = ("" + $Configuration.Application.PackageArchiveName).Trim()
		
		$ConfigXml.Save($InstallerConfigurationFilePath)
		
		Write-Host "Complete" -ForegroundColor Green
	}
	else
	{
		Write-Host "Failed" -ForegroundColor Red
	}
	
	Write-Host ""
}

function ReadInstallerConfiguration
{
	try
	{
		if(-not(Test-Path -Path $InstallerConfigurationFilePath -PathType leaf))
		{
			Throw "The Installer.config file couold not be found."
		}
		
		$configXml = [xml](Get-Content -Path $InstallerConfigurationFilePath)

		[hashtable]$config = @{}
		
		# TODO: Figure out how to get this with namespaces...
		$rootNode = $configXml.SelectNodes("//*[local-name() = 'Astrana']")
		
		if($rootNode -eq $null)
		{
			return $null
		}
		else
		{
			$config.Peer = @{}
			$config.Peer.Language = $rootNode.SelectSingleNode("//Peer/Language").InnerText
			$config.Peer.RegionCountry = $rootNode.SelectSingleNode("/Peer/RegionCountry").InnerText
			$config.Peer.TimeZone = $rootNode.SelectSingleNode("//Peer/TimeZone").InnerText
			$config.Peer.FirstName = $rootNode.SelectSingleNode("//Peer/FirstName").InnerText
			$config.Peer.LastName = $rootNode.SelectSingleNode("//Peer/LastName").InnerText
			$config.Peer.EmailAddress = $rootNode.SelectSingleNode("//Peer/EmailAddress").InnerText
			$config.Peer.PhoneCode = $rootNode.SelectSingleNode("//Peer/PhoneCode").InnerText
			$config.Peer.PhoneNumber = $rootNode.SelectSingleNode("//Peer/PhoneNumber").InnerText
			
			$config.WebServer = @{}
			$config.WebServer.ContainerName = $rootNode.SelectSingleNode("//WebServer/ContainerName").InnerText	
			
			$config.WebServer.Host = @{}
			$config.WebServer.Host.Provider = $rootNode.SelectSingleNode("//WebServer/Host/Provider").InnerText
			$config.WebServer.Host.Domain = $rootNode.SelectSingleNode("//WebServer/Host/Domain").InnerText
			$config.WebServer.Host.Port = $rootNode.SelectSingleNode("//WebServer/Host/Port").InnerText	
			
			$WebServerHostRevereseProxyNode = $rootNode.SelectSingleNode("//WebServer/Host/RevereseProxy")
			
			$config.WebServer.Host.RevereseProxy = @{}
			
			if((-not ($WebServerHostRevereseProxyNode -eq $null)) -and ($WebServerHostRevereseProxyNode.HasAttributes))
			{
				$config.WebServer.Host.RevereseProxy.Enabled = $WebServerHostRevereseProxyNode.GetAttribute("enabled")
				
				if([string]::IsNullOrEmpty($config.WebServer.Host.RevereseProxy.Enabled))
				{
					$config.WebServer.Host.RevereseProxy.Enabled = "false"
				}
			}
			else
			{
				$config.WebServer.Host.RevereseProxy.Enabled = "false"
			}
			
			$config.WebServer.Host.RevereseProxy.Provider = $rootNode.SelectSingleNode("//WebServer/Host/RevereseProxy/Provider").InnerText
			
			$config.WebServer.SslCertificate = @{}
			$config.WebServer.SslCertificate.Provider = $rootNode.SelectSingleNode("//WebServer/SslCertificate/Provider").InnerText
			$config.WebServer.SslCertificate.Location = $rootNode.SelectSingleNode("//WebServer/SslCertificate/Location").InnerText
			
			$config.Database = @{}
			$config.Database.Provider = $rootNode.SelectSingleNode("//Database/Provider").InnerText
			$config.Database.Name = $rootNode.SelectSingleNode("//Database/Name").InnerText
			$config.Database.HostAddress = $rootNode.SelectSingleNode("//Database/HostAddress").InnerText
			$config.Database.HostPort = $rootNode.SelectSingleNode("//Database/HostPort").InnerText
			$config.Database.UserName = $rootNode.SelectSingleNode("//Database/UserName").InnerText
			$config.Database.Password = $rootNode.SelectSingleNode("//Database/Password").InnerText			
			
			$config.Application = @{}
			$config.Application.PackageArchiveName = $rootNode.SelectSingleNode("//Application/PackageArchiveName").InnerText
			
			return $config
		}
	}
	catch
	{
		$_.Exception
		
		Write-Host "Cannot Read Configuration File" -ForegroundColor Red
		
		exit 1;
	}
}

function ValidateInstallerConfigurationFile
{
	Write-Host "   Validating Installer Configuration... " -NoNewLine	
	
	if(-not (Test-Path -Path $InstallerConfigurationFilePath -PathType leaf))
	{
		Write-Host "Failed" -ForegroundColor Red
		Write-Host ""
		Write-Host "Cannot find the installer configuration file." -ForegroundColor Yellow
	
		return $True
	}
	
	$configuration = ReadInstallerConfiguration	
		
	if($configuration.WebServer.ContainerName -match "^[a-zA-Z0-9]+$" -eq $False)
	{
		Write-Host "Invalid" -ForegroundColor Red
		
		Write-Host ""
		Write-Host "   Web Server Container Name must be Alpha-numeric without spaces or special characters." -ForegroundColor Yellow
	
		return $False
	}
	
	Write-Host "Valid" -ForegroundColor Green
	
	return $True
}

function ValidateSystemRequirements
{
	# Write-Host (Get-CimInstance -ClassName Win32_Processor | Select-Object -ExcludeProperty "CIM*")
	# Write-Host (Get-CimInstance -ClassName Win32_ComputerSystem | Select-Object -Property SystemType)
	
	# Write-Host (Get-CimInstance -ClassName Win32_LogicalDisk -Filter "DriveType=3" | Measure-Object -Property FreeSpace,Size -Sum | Select-Object -Property Property,Sum)
	
	Write-Host "   Checking System Requirements... " -NoNewLine	
	Start-Sleep -Seconds 1
	Write-Host "Complete" -ForegroundColor Green
	
	return $True
}

function RunPreInstallChecks
{
	Write-Host "Running Pre-installation Checks... " -ForegroundColor DarkCyan	
	
	$IsConfigurationValid = ValidateInstallerConfigurationFile
	
	if(-not $IsConfigurationValid)
	{	
		return $False
	}
	
	$SystemRequirementsMet = ValidateSystemRequirements
	
	if($IsConfigurationValid -and $SystemRequirementsMet)
	{	
		return $True
	}
	else
	{
		return $False
	}
}

[hashtable]$config = ReadInstallerConfiguration

function GetPromptChoiceOptions
{
	Param(
		[Parameter(Mandatory = $True)]
		[System.Collections.Specialized.OrderedDictionary]$OptionsList,
		[bool]$ShowId = $False
	)

	$usedChars = $()
	
	$options = @()
	
	foreach($item in $OptionsList.Values)
	{
		$id = $item["Id"]
		$label = $item["FriendlyName"];
		$description = $item["Description"]
		
		$charIndex = 0
		for (($i = 0); $i -lt $label.Length; $i++)
		{
			$char = $label.Substring($i, $i + 1)
			
			if(-not ($usedChars -Match $char))
			{
				$usedChars += $char
				$charIndex = $i
				break;
			}
		}
		
		$displayText = "$label".Insert($charIndex, "&")
		
		if($ShowId)
		{
			$displayText =  "$displayText ($id)"
		}
		
		$options += New-Object System.Management.Automation.Host.ChoiceDescription $displayText, $description
	}
	
	return $options
}

function GetChoiceValueByIndex
{
	Param(
		[Parameter(Mandatory = $True)]
		[System.Collections.Specialized.OrderedDictionary]$OptionsList,
		
		[Parameter(Mandatory = $True)]
		[int]$Index
	)

	$currentIndex = 0
	foreach($item in $OptionsList.Values)
	{
		if($currentIndex -eq $Index)
		{
			return $item["Id"]
		}
		
		$currentIndex++
	}
	
	return ""
}

function PromptForUserChoice
{
	Param(		
		[Parameter(Mandatory = $True)]
		[string]$Label,
		
		[Parameter(Mandatory = $True)]
		[System.Collections.Specialized.OrderedDictionary]$OptionsList,
		
		[int]$DefaultIndex = 0
	)

	return GetChoiceValueByIndex $OptionsList ($Host.UI.PromptForChoice($null, $Label, (GetPromptChoiceOptions $OptionsList), $DefaultIndex))
}

function ReadUserInput
{
	Param(		
		[Parameter(Mandatory = $True)]
		[string]$Label,
		
		[string]$DefaultValue = "",
		
		[bool]$ShowDefaultValueInLabel = $True
	)

	$DisplayLabel = "$($Label)"
	if($ShowDefaultValueInLabel -and (-not [string]::IsNullOrEmpty($DefaultValue)))
	{
		$DisplayLabel = "$Label (default is $($DefaultValue))"
	}
	
	$Value = Read-Host $DisplayLabel
	
	if([string]::IsNullOrEmpty($Value))
	{
		return $DefaultValue
	}
	else
	{
		return $Value
	}
}

function Show-FilePickerDialog
{
	Param(
		[string]$Title
	)
		
	if($IsWindows)
	{
		$dialog = New-Object -TypeName Microsoft.Win32.OpenFileDialog
		
		$dialog.Title = $Title
		$dialog.InitialDirectory = $ScriptDirectory
		# $dialog.Filter = "*.prem|*.crt|*.cer|*.der|*.p7b|*.p7c|*.p12|Everything|*.*"
		
		if ($dialog.ShowDialog())
		{
			return $dialog.FileName
		}
		else
		{
			return ""
		}
	}
}

function CaptureInteractiveInput
{
	try
	{
		Write-Host "Please provide the following details: " -ForegroundColor DarkCyan
		Write-Host ""
		
		$config.WebServer.Host.Provider = PromptForUserChoice "Select Web Server Provider:" $WebServerProviders
		Write-Host ""
		
		$config.WebServer.Host.Domain = ReadUserInput "Domain Name" $config.WebServer.Host.Domain		
		$config.WebServer.Host.Port = ReadUserInput "Port Number" $config.WebServer.Host.Port		
		$config.WebServer.ContainerName = ReadUserInput "Web Server Container Name" $config.WebServer.ContainerName
		
		Write-Host ""

		if(($config.WebServer.Host.Provider -eq $WebServerProviders.Self.Id) -and ((PromptForUserChoice "Use a reverse proxy?" $YesNoChoices $defaultReverseProxyChoice) -eq "yes"))
		{
			Write-Host ""
			$config.WebServer.Host.RevereseProxy.Enabled = "true"
			$config.WebServer.Host.RevereseProxy.Provider = PromptForUserChoice "Select Reverese Proxy Provider:" $RevereseProxyProviders
		}
		else
		{
			$config.WebServer.Host.RevereseProxy.Enabled = "false"
			$config.WebServer.Host.RevereseProxy.Provider = ""
		}
		
		Write-Host ""
		if((PromptForUserChoice "Generate SSL Certificate?" $YesNoChoices) -eq "yes")
		{
			if($IsWindows)
			{
				Write-Host "Select SSL Certificate file"
				Write-Host ""
				$SslFileLocation = ""
				
				do
				{
					$SslFileLocation = Show-FilePickerDialog "Select SSL Certificate file"
				} 
				while ([string]::IsNullOrEmpty($SslFileLocation))
				
				$config.SslFileLocation = $SslFileLocation
				
				Write-Host $config.SslFileLocation
			}
			else
			{
				$config.SslFileLocation = Read-Host "Specify SSL Certificate file:"
			}
		}
		Write-Host ""
		
		$config.Database.Provider = PromptForUserChoice "Select Database Provider:" $DatabaseProviders
		Write-Host ""
		
		$config.Database.Name = ReadUserInput "Database Name" $config.Database.Name
		$config.Database.HostAddress = ReadUserInput "Database Host Address" $config.Database.HostAddress
		$config.Database.HostPort = ReadUserInput "Database Host Port" $config.Database.HostPort
		$config.Database.UserName = ReadUserInput "Database Username" $config.Database.UserName
		$config.Database.Password = ReadUserInput "Database Password" $config.Database.Password $False		
		Write-Host ""
		
		$config.Peer.Language = PromptForUserChoice "Select Language:" $Languages
		Write-Host ""
		
		$config.Peer.RegionCountry = PromptForUserChoice "Select Region / Country:" $Countries
		Write-Host ""
		
		$config.Peer.TimeZone = PromptForUserChoice "Select Time Zone:" $Countries
		Write-Host ""
		
		$config.Peer.FirstName = Read-Host "First Name"
		$config.Peer.LastName = Read-Host "Last Name"
		
		$config.Peer.EmailAddress = Read-Host "Email Address"
		$config.Peer.PhoneCode = Read-Host "Phone Code"
		$config.Peer.PhoneNumber = Read-Host "Phone Number"
		
		$config.Peer.InstanceUsername = Read-Host "Instance Username"
		$config.Peer.InstancePassword = Read-Host "User Password" -AsSecureString
		
		Write-Host ""
	}
	catch
	{
		exit -1
	}
}

function WriteEmptyElementString
{
	Param(
		[System.XML.XmlWriter]$xmlWriter,
		[string]$NodeName
	)
	
	$xmlWriter.WriteStartElement($NodeName)
	$xmlWriter.WriteRaw("")
	$xmlWriter.WriteFullEndElement()
}

function GetInstallationDirectory
{
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$WebServer = "Self"
	)
	
	$ApplicationDirectoryName = $config.WebServer.ContainerName
	$InstallationDirectory = ""
	
	$WebServerLowered = $WebServer.ToLower()
	
	if($WebServerLowered -eq "iis")
	{
		$InstallationDirectory = [IO.Path]::Combine($env:SystemDrive, "inetpub", "wwwroot", $ApplicationDirectoryName)
	}	
	else
	{
		if($IsWindows)
		{
			if($WebServerLowered -eq "self")
			{
				$InstallationDirectory = [IO.Path]::Combine($env:programfiles, $ApplicationDirectoryName)
			}
			elseif($WebServerLowered -eq "nginx")
			{
				$InstallationDirectory = [IO.Path]::Combine($env:SystemDrive, "web", "html", $ApplicationDirectoryName)
			}
		}
		elseif($IsLinux)
		{			
			if($WebServerLowered -eq "self")
			{
				$InstallationDirectory = [IO.Path]::Combine("opt", $ApplicationDirectoryName)
			}
			elseif($WebServerLowered -eq "nginx")
			{
				$InstallationDirectory = [IO.Path]::Combine("usr", "local", "nginx")
			}
			
			$InstallationDirectory = $InstallationDirectory.ToLower()
		}	
	}
	
	return $InstallationDirectory
}

function CleanUpInstallationFiles
{
	Write-Host "Cleaning up Installation files... " -ForegroundColor Cyan -NoNewLine
	
	if(Test-Path -PathType container $PackageExtractionPath)
	{
		Remove-Item $PackageExtractionPath -Force -Recurse
	}
	
	Write-Host "Complete" -ForegroundColor Green
	
	return $True
}

function ExtractPackage
{
	Write-Host "Extracting Installation Packages... " -ForegroundColor Cyan -NoNewLine
	
	$PackageArchivePath = [IO.Path]::Combine($ScriptDirectory, "setup", $config.Application.PackageArchiveName)
	
	if(-not $PackageArchivePath.EndsWith("zip"))
	{
		throw "Package is in an invalid format."
	}
	
	if(-not (Test-Path -PathType leaf $PackageArchivePath))
	{
		throw "$($PackageArchivePath) does not exist."
	}
	
	if(-not (Test-Path -PathType container $PackageExtractionPath))
	{
		New-Item -ItemType Directory -Path $PackageExtractionPath
	}
	else
	{
		Get-ChildItem -Path $PackageExtractionPath -Recurse | Remove-Item -Force -Recurse
	}
	
	try
	{
		Expand-Archive -LiteralPath $PackageArchivePath -DestinationPath $PackageExtractionPath
		
		Write-Host "Complete" -ForegroundColor Green
		
		return $True
	} 
	catch 
	{
		Write-Host "Fail" -ForegroundColor Red
		$_
	}
		
	return $False
}

function CopyApplicationFiles
{
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$DestinationPath
	)
	
	Write-Host "Copying Application Files... " -ForegroundColor Cyan
	
	if(-not (Test-Path -PathType container $PackageApplicationExtractionPath))
	{
		throw "$PackageApplicationExtractionPath does not exist."
	}
	
	if(-not (Test-Path -PathType container $DestinationPath))
	{
		New-Item -ItemType Directory -Path $DestinationPath
	}
	else
	{
		if($RemoveExisting.IsPresent)
		{
			Get-ChildItem -Path $DestinationPath -Recurse | Remove-Item -Force -Recurse
		}
	}
	
	if((Get-ChildItem $DestinationPath | Measure-Object).count -gt 0)
	{
		throw "$PackageApplicationExtractionPath already contains content."
	}
	
	Write-Host "   $PackageApplicationExtractionPath => $DestinationPath ... " -ForegroundColor White -NoNewLine
	
	try
	{
		Copy-Item -Path ([IO.Path]::Combine($PackageApplicationExtractionPath, "*")) -Destination $DestinationPath -Recurse
		Write-Host "Complete" -ForegroundColor Green
		
		return $True
	} 
	catch 
	{
		Write-Host "Fail" -ForegroundColor Red
		Write-Host $_.Exception
	}
		
	return $False
}

function GetDatabaseConnectionString
{
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseProvider,
		
		[bool]
		$ConnectivityOnly = $False
	)
	
	$DatabaseProviderLowered = $DatabaseProvider.ToLower()
	
	$ConnectionString = ""
	
	if($DatabaseProviderLowered -eq $DatabaseProviders.MSSQLServer.Id)
	{		
		if($ConnectivityOnly)
		{
			$ConnectionString = "Server=$($config.Database.HostAddress);Database=master;Integrated Security=SSPI;Encrypt=False;"
		}
		else
		{
			$ConnectionString = "Server=$($config.Database.HostAddress);Database=$($config.Database.Name);User Id=$($config.Database.UserName);Password=$($config.Database.Password);Encrypt=False;TrustServerCertificate=True;"
		}
	}
	elseif($DatabaseProviderLowered -eq $DatabaseProviders.Postgresql.Id)
	{
		if($ConnectivityOnly)
		{
			$ConnectionString = ""
		}
		else
		{
			$ConnectionString = "Host=$($config.Database.HostAddress);"
			
			if(-not ([string]::IsNullOrEmpty($config.Database.HostPort)))
			{
				$ConnectionString = "$($ConnectionString)Port=$($config.Database.HostPort);"	
			}
			
			$ConnectionString = "$($ConnectionString)Database=$($config.Database.Name);User Id=$($config.Database.UserName);Password=$($config.Database.Password);"	
		}
	}
	elseif($DatabaseProviderLowered -eq $DatabaseProviders.MySQL.Id)
	{
		if($ConnectivityOnly)
		{
			$ConnectionString = ""
		}
		else
		{
			$ConnectionString = "Server=$($config.Database.HostAddress);"
			
			if(-not ([string]::IsNullOrEmpty($config.Database.HostPort)))
			{
				$ConnectionString = "$($ConnectionString)Port=$($config.Database.HostPort);"
			}
			
			$ConnectionString = "$($ConnectionString)Database=$($config.Database.Name);Uid=$($config.Database.UserName);Pwd=$($config.Database.Password);"	
		}
	}
	
	return $ConnectionString
}

function UpdateAppSettingsFile
{
	$filePath = [IO.Path]::Combine((GetInstallationDirectory $config.WebServer.Host.Provider), $AppSettingsFileName)
	
	Write-Host "Updating Application Settings File... " -ForegroundColor Cyan -NoNewLine
	
	try
	{
		$json = Get-Content $filePath -Raw | ConvertFrom-Json
		
		if(-not ($json -eq $null))
		{
			$json.SetupMode = "ON"
			
			$json.DatabaseProvider = $config.Database.Provider
			
			$json.ConnectionStrings.MSSqlServer = GetDatabaseConnectionString $DatabaseProviders.MSSQLServer.Id
			$json.ConnectionStrings.PostgreSQL = GetDatabaseConnectionString $DatabaseProviders.Postgresql.Id
			$json.ConnectionStrings.MySQL = GetDatabaseConnectionString $DatabaseProviders.MySQL.Id
			
			foreach($serilogWriter in $json.Serilog.WriteTo)
			{
				if($serilogWriter.Name -eq "MSSqlServer")
				{
					$serilogWriter.Args.connectionString = GetDatabaseConnectionString $DatabaseProviders.MSSQLServer.Id
				}
				elseif($serilogWriter.Name -eq "PostgreSQL")
				{
					$serilogWriter.Args.connectionString = GetDatabaseConnectionString $DatabaseProviders.Postgresql.Id
				}
				elseif($serilogWriter.Name -eq "MySQL")
				{
					$serilogWriter.Args.connectionString = GetDatabaseConnectionString $DatabaseProviders.MySQL.Id
				}
			}
			
			$json | ConvertTo-Json -Depth 64 | Set-Content $filePath
			
			Write-Host "Complete" -ForegroundColor Green
			
			return $True
		}
	} 
	catch 
	{
		Write-Host "Fail" -ForegroundColor Red
		Write-Host $_.Exception
	}
	
	return $False
}

function Test-DatabaseConnection
{
    [OutputType([bool])]
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseProvider,
		
		[Parameter(Mandatory = $True)]
		[string]
		$ConnectionString
	)
	
	$DatabaseProviderLowered = $DatabaseProvider.ToLower()

    try
    {
		if($DatabaseProviderLowered -eq $DatabaseProviders.MSSQLServer.Id)
		{
			$sqlConnection = New-Object System.Data.SqlClient.SqlConnection
			$sqlConnection.ConnectionString = $ConnectionString.Replace("@", "`@")
			
			$sqlConnection.Open()
			$sqlConnection.Close()

			return $True;
		}
		elseif($DatabaseProviderLowered -eq $DatabaseProviders.Postgresql.Id)
		{
			return $False;
		}
		elseif($DatabaseProviderLowered -eq $DatabaseProviders.MySQL.Id)
		{
			return $False;
		}
    }
    catch
    {
		Write-Host $_.Exception
		
		Write-Host $_ -ForegroundColor Red
        return $False;
    }
}

function ExecuteSQL
{
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseProvider,
		
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseHostAddress,
		
		[string]
		$Query,
		
		[string]
		$FilePath,
		
		[string]
		$DatabaseName
	)
	
	$DatabaseProviderLowered = $DatabaseProvider.ToLower()
	$ConnectionString = GetDatabaseConnectionString $DatabaseProvider
	
	$SqlSource = ""	
	if([string]::IsNullOrEmpty($Query) -and [string]::IsNullOrEmpty($FilePath))
	{
		throw "SQL Query or Script must be specified."
	}
	else
	{
		if(-not ([string]::IsNullOrEmpty($Query)))
		{
			$SqlSource = "query"
		}
		else
		{
			$SqlSource = "file"
		}		
	}
	
    try
    {
		if($DatabaseProviderLowered -eq $DatabaseProviders.MSSQLServer.Id)
		{
			if($SqlSource -eq "query")
			{
				if([string]::IsNullOrEmpty($DatabaseName))
				{	
					Invoke-Sqlcmd -ServerInstance $DatabaseHostAddress -Query $Query
				}
				else
				{
					Invoke-Sqlcmd -ServerInstance $DatabaseHostAddress -Database $DatabaseName -Query $Query
				}
			}
			elseif($SqlSource -eq "file")
			{
				if([string]::IsNullOrEmpty($DatabaseName))
				{
					Invoke-Sqlcmd -ServerInstance $DatabaseHostAddress -InputFile $FilePath
				}
				else
				{
					Invoke-Sqlcmd -ServerInstance $DatabaseHostAddress -Database $DatabaseName -InputFile $FilePath
				}
			}
		}
		elseif($DatabaseProviderLowered -eq $DatabaseProviders.Postgresql.Id)
		{
			if($SqlSource -eq "query")
			{
				if([string]::IsNullOrEmpty($DatabaseName))
				{
					# TODO
				}
				else
				{
					# TODO
				}
			}
			elseif($SqlSource -eq "file")
			{
				if([string]::IsNullOrEmpty($DatabaseName))
				{
					# TODO
				}
				else
				{
					# TODO
				}
			}
		}
		elseif($DatabaseProviderLowered -eq $DatabaseProviders.MySQL.Id)
		{
			if($SqlSource -eq "query")
			{
				if([string]::IsNullOrEmpty($DatabaseName))
				{
					# TODO
				}
				else
				{
					# TODO
				}
			}
			elseif($SqlSource -eq "file")
			{
				if([string]::IsNullOrEmpty($DatabaseName))
				{
					# TODO
				}
				else
				{
					# TODO
				}
			}
		}
    }
    catch
    {
		Write-Host $_ -ForegroundColor Red
    }
}

function GetDropDatabaseQuery
{
    [OutputType([string])]
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseProviderId,
		
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseName
	)
	
	$DatabaseProviderIdLowered = $DatabaseProviderId.ToLower()
	
	$ScriptFilePath = ([IO.Path]::Combine($PackageDatabaseExtractionPath, $DropDatabaseScriptFileName.Replace($PLACEHOLDER_DATABASE_PROVIDER_ID, $DatabaseProviderIdLowered)))
	
	$Query = Get-Content -Path $ScriptFilePath -Raw
	$Query = $Query.Replace($PLACEHOLDER_DATABASE_NAME, $DatabaseName)
	
	return "$Query"
}

function GetCreateDatabaseQuery
{
    [OutputType([string])]
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseProviderId,
		
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseName
	)
	
	$DatabaseProviderIdLowered = $DatabaseProviderId.ToLower()
	
	$ScriptFilePath = ([IO.Path]::Combine($PackageDatabaseExtractionPath, $CreateDatabaseScriptFileName.Replace($PLACEHOLDER_DATABASE_PROVIDER_ID, $DatabaseProviderIdLowered)))
	
	$Query = Get-Content -Path $ScriptFilePath -Raw
	$Query = $Query.Replace($PLACEHOLDER_DATABASE_NAME, $DatabaseName)
	
	if($DatabaseProviderIdLowered -eq $DatabaseProviders.MSSQLServer.Id)
	{
		$DataPath = (Invoke-Sqlcmd -ServerInstance "$($config.Database.HostAddress)" -Query "SELECT SERVERPROPERTY('InstanceDefaultDataPath') AS Path").Path
		$LogsDataPath = (Invoke-Sqlcmd -ServerInstance "$($config.Database.HostAddress)" -Query "SELECT SERVERPROPERTY('InstanceDefaultLogPath') AS Path").Path
		
		if([string]::IsNullOrEmpty($DataPath))
		{
			throw "Could not determine database data file directory path."
		}
		
		if([string]::IsNullOrEmpty($LogsDataPath))
		{
			throw "Could not determine database logs file directory path."
		}
		
		$Query = $Query.Replace($PLACEHOLDER_DATABASE_DATA_PATH, $DataPath)
		$Query = $Query.Replace($PLACEHOLDER_DATABASE_LOGS_DATA_PATH, $LogsDataPath)
	}
	
	return "$Query"
}

function GetCreateDatabaseUserQuery
{
    [OutputType([string])]
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseProviderId,
		
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseName,
		
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseUsername,
		
		[Parameter(Mandatory = $True)]
		[string]
		$DatabasePassword
	)
	
	$DatabaseProviderIdLowered = $DatabaseProviderId.ToLower()
	
	$ScriptFilePath = ([IO.Path]::Combine($PackageDatabaseExtractionPath, $CreateDatabaseUserScriptFileName.Replace($PLACEHOLDER_DATABASE_PROVIDER_ID, $DatabaseProviderIdLowered)))
	
	$Query = Get-Content -Path $ScriptFilePath -Raw
	$Query = $Query.Replace($PLACEHOLDER_DATABASE_NAME, $DatabaseName)
	$Query = $Query.Replace($PLACEHOLDER_DATABASE_USERNAME, $DatabaseUsername)
	$Query = $Query.Replace($PLACEHOLDER_DATABASE_PASSWORD, $DatabasePassword)
		
	return "$Query"
}

function GetDatabaseMigrationsScriptPath
{
    [OutputType([string])]
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$DatabaseProviderId
	)
	
	$DatabaseProviderIdLowered = $DatabaseProviderId.ToLower()
	
	return [IO.Path]::Combine($PackageDatabaseExtractionPath, $ApplyDatabaseMigrationsScriptFileName.Replace($PLACEHOLDER_DATABASE_PROVIDER_ID, $DatabaseProviderIdLowered))
}

function CreateDatabase
{
	$DatabaseProviderFriendlyName = ""
	foreach($item in $DatabaseProvider.Values)
	{
		if($item["Id"] -eq $config.Database.Provider)
		{
			$DatabaseProviderFriendlyName = $item["FriendlyName"]
			break
		}
	}
	
	Write-Host "Setting up Astrana Database [$($DatabaseProviderFriendlyName)]" -ForegroundColor Cyan
	
	$ConnectionString = GetDatabaseConnectionString $config.Database.Provider
	
	Write-Host "   Testing Database Connection...    " -ForegroundColor White -NoNewLine
	
	if(Test-DatabaseConnection $config.Database.Provider (GetDatabaseConnectionString $config.Database.Provider $True))
	{
		Write-Host "Connected" -ForegroundColor Green
		
		if($RemoveExisting.IsPresent)
		{
			# Drop Database
			Write-Host "   Dropping Existing Database...     " -ForegroundColor White -NoNewLine
			ExecuteSQL -DatabaseProvider $config.Database.Provider -DatabaseHostAddress $config.Database.HostAddress -Query (GetDropDatabaseQuery $config.Database.Provider $config.Database.Name)
			Write-Host "Complete" -ForegroundColor Green
			Start-Sleep -Seconds 1
		}
		
		# Create Database
		Write-Host "   Creating Database...              " -ForegroundColor White -NoNewLine
		ExecuteSQL -DatabaseProvider $config.Database.Provider -DatabaseHostAddress $config.Database.HostAddress -Query (GetCreateDatabaseQuery $config.Database.Provider $config.Database.Name)
		Write-Host "Complete" -ForegroundColor Green
		Start-Sleep -Seconds 1
		
		# Apply Database Migrations
		Write-Host "   Applying Database Migrations...   " -ForegroundColor White -NoNewLine
		ExecuteSQL -DatabaseProvider $config.Database.Provider -DatabaseHostAddress $config.Database.HostAddress -File (GetDatabaseMigrationsScriptPath $config.Database.Provider) -DatabaseName $config.Database.Name
		Write-Host "Complete" -ForegroundColor Green
		Start-Sleep -Seconds 1
		
		# Create Database User
		Write-Host "   Creating Database User...         " -ForegroundColor White -NoNewLine
		ExecuteSQL -DatabaseProvider $config.Database.Provider -DatabaseHostAddress $config.Database.HostAddress -Query (GetCreateDatabaseUserQuery $config.Database.Provider $config.Database.Name $config.Database.UserName $config.Database.Password) -DatabaseName $config.Database.Name
		Write-Host "Complete" -ForegroundColor Green
		Start-Sleep -Seconds 1			
	
		return $True
	}
	else
	{
		Write-Host "Unable to Connect" -ForegroundColor Red
		
		return $False
	}
	
	Write-Host "Complete" -ForegroundColor Green
	
	return $False
}

function ConfigureWebServerContainer
{
	Param
	(
		[Parameter(Mandatory = $True)]
		[string]
		$InstallationDirectory
	)
	
	if(-not (Test-Path -PathType container $InstallationDirectory))
	{
		New-Item -ItemType Directory -Path $InstallationDirectory
	}
	
	if($config.WebServer.Host.Provider.ToLower() -eq $WebServerProviders.Self.Id)
	{
		Write-Host "Configuring Web Server [$($WebServerProviders.Self.FriendlyName)]... " -ForegroundColor Cyan
		
		if($IsWindows)
		{
			Write-Host "   Installing Astrana Windows Service... " -ForegroundColor White -NoNewLine
			Start-Sleep -Seconds 3
			Write-Host "NOT IMPLEMENTED YET" -ForegroundColor Yellow
			
			Write-Host "   Starting Astrana Windows Service... " -ForegroundColor White -NoNewLine
			Start-Sleep -Seconds 1
			Write-Host "NOT IMPLEMENTED YET" -ForegroundColor Yellow
		}
		else
		{
			Write-Host "   Installing Astrana Daemon... " -ForegroundColor White -NoNewLine
			Start-Sleep -Seconds 1
			Write-Host "NOT IMPLEMENTED YET" -ForegroundColor Yellow
			
			Write-Host "   Starting Astrana Daemon... " -ForegroundColor White -NoNewLine
			Start-Sleep -Seconds 1
			Write-Host "NOT IMPLEMENTED YET" -ForegroundColor Yellow
		}
		
		return $True
	}
	elseif($config.WebServer.Host.Provider.ToLower() -eq $WebServerProviders.IIS.Id -and $IsWindows)
	{
		Write-Host "Configuring Web Server [$($WebServerProviders.IIS.FriendlyName)]... " -ForegroundColor Cyan -NoNewLine
		
		$scriptPath = [IO.Path]::Combine($ScriptDirectory, "setup", "webserver", "iis", "iis-setup.ps1")
		$arguments = " -AppName ""$($config.WebServer.ContainerName)"" -RootDirectory ""$($InstallationDirectory)"" -Domain ""$($config.WebServer.Host.Domain)"""
		
		 $argumentGrantDirectoryAccess = "-GrantFullAccessToDirectories ""temp,temp\files,files"""
	
		try
		{
			if($RemoveExisting.IsPresent)
			{
				$cmdOutput = & powershell $scriptPath "$($config.WebServer.ContainerName)" "$($InstallationDirectory)" "$($config.WebServer.Host.Domain)" $argumentGrantDirectoryAccess "-RemoveExisting"
			}
			else
			{
				$cmdOutput = & powershell $scriptPath "$($config.WebServer.ContainerName)" "$($InstallationDirectory)" "$($config.WebServer.Host.Domain)"  $argumentGrantDirectoryAccess
			}
			
			Write-Host "Complete" -ForegroundColor Green 
			
			return $True
		} 
		catch 
		{
			Write-Host "Fail" -ForegroundColor Red
			$_
		}
	}
	else
	{
		Write-Host "Unsupported Web Server Provider Specified" -ForegroundColor Yellow
	}
	
	Write-Host ""
	
	return $False
}

function OpenSetupPage
{
	Write-Host "Opening Setup Screen... " -ForegroundColor Cyan -NoNewLine
		
	$url = "https://$($config.WebServer.Host.Domain)"
	
	if(($config.WebServer.Host.Port -gt 0) -and (-not ($config.WebServer.Host.Port -eq 80)))
	{
		 $url = "$($url):$($config.WebServer.Host.Port)"
	}
	
	$url = "$url/setup"
	
	Start-Process $url
	
	Write-Host "Complete" -ForegroundColor Green
}

function CreateSelfSignedDevCer
{
	New-SelfSignedCertificate -CertStoreLocation Cert:\LocalMachine\My -DnsName "astrana.local" -FriendlyName "AstranaLocalSiteCert" -NotAfter (Get-Date).AddYears(10)
}

$CommandLowered = $Command.ToLower()

try
{
	if($CommandLowered -eq "setconfig")
	{
		if(CheckPrequisites "create-configuration")
		{
			Write-Host ""
			
			if($GenerateConfigFile.IsPresent)
			{
				Write-Host "Creating new installer configuration file (installer.config)... " -ForegroundColor DarkCyan -NoNewLine
				
				CreateDefaultConfigurationFile
				
				Write-Host "Complete" -ForegroundColor Green
				Write-Host ""
			}
			
			if($InteractiveMode.IsPresent)
			{
				CaptureInteractiveInput
				UpdateConfigurationFile $config
			}
		}
	}
	elseif($CommandLowered -eq "preinstallcheck")
	{
		if(CheckPrequisites "preinstallcheck")
		{
			Write-Host ""
			
			if(RunPreInstallChecks)
			{
				Write-Host ""
				Write-Host "Pre-installation checks are all successful." -ForegroundColor Green
			}
			else
			{
				Write-Host ""
				Write-Host "Some pre-installation checks failed." -ForegroundColor Red
			}
		}
	}
	elseif($CommandLowered -eq "install")
	{
		if(CheckPrequisites "execute-install")
		{
			Write-Host ""
			
			if(RunPreInstallChecks)
			{
				Write-Host ""			
				Write-Host $BeginningInstallMessage -ForegroundColor DarkCyan
				Write-Host ""
				
				$InstallDirectory = GetInstallationDirectory $config.WebServer.Host.Provider
				
				if(ExtractPackage)
				{
					if(CopyApplicationFiles $InstallDirectory)
					{
						Write-Host ""
						
						if(UpdateAppSettingsFile)
						{
							Write-Host ""
							if(CreateDatabase)
							{					
								Write-Host ""
								if(ConfigureWebServerContainer $InstallDirectory)
								{
									Write-Host ""
									$cleanUpResult = CleanUpInstallationFiles
									
									Write-Host ""
									OpenSetupPage
								}
								else
								{
									Write-Host "Installation Failed: Unable to create the Web Server Container." -ForegroundColor Red
									exit 1
								}
							}
							else
							{
								Write-Host "Installation Failed: Unable to Create Database." -ForegroundColor Red
								exit 1
							}
						}
					}
					else
					{
						Write-Host "Installation Failed: Unable to Copy Application Files." -ForegroundColor Red
						exit 1
					}
				}
				else
				{
					Write-Host "Installation Failed: Unable to Copy Application Files." -ForegroundColor Red
					exit 1
				}
			}
		}
	}	
	elseif($CommandLowered -eq "installpsmodules")
	{
		InstallPowerShellModules
	}
}
catch
{
	Write-Host $_ -ForegroundColor Red
}
finally
{
	Set-Location $ScriptDirectory
	Write-Host ""
}