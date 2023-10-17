#Requires -PSEdition Core
#Requires -RunAsAdministrator

Param(
	[Parameter(Mandatory = $True)]
	[Alias('c')]
	[ValidateSet("app", "setup", IgnoreCase = $True)]
	[string]$Command,
	
	[Parameter(Mandatory = $True)]
	[Alias('p')]
	[ValidateSet("any", "windows", "linux", "macos", IgnoreCase = $True)]
	[string]$Platform,
	
	[Parameter(Mandatory = $True)]
	[Alias('vn')]
	[string]$PackageVersion,
	
	[Alias('s')]
	[string]$SourceDirectory = $PWD
)

$ScriptDirectory = $PWD

$ScriptMajorVersion = 1
$ScriptMinorVersion = 0
$ScriptPatchVersion = 0

$ScriptVersion = "$($ScriptMajorVersion).$($ScriptMinorVersion).$($ScriptPatchVersion)"

Write-Host "Astrana Release Packaging Utility $ScriptVersion" -ForegroundColor White
Write-Host ""

$PlatformName = "Unknown"
$PlatformEdition = "Any"

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

function CreateApplicationPackage
{
	$ApplicationName = "Astrana"
	
	$PackageNameParts = @("Astrana", $PackageVersion)		
	
	if($Platform -eq "windows")
	{
		$PackageNameParts += "win"
	}
	elseif($Platform -eq "linux")
	{
		$PackageNameParts += "linux"		
	}
	elseif($Platform -eq "macos")
	{
		$PackageNameParts += "osx"		
	}
	
	if($PlatformEdition -eq "x64")
	{
		$PackageNameParts += "x64"
	}
	elseif($PlatformEdition -eq "x32")
	{
		$PackageNameParts += "x32"		
	}
	
	$DatabaseSourceDirectoryPath = [IO.Path]::Combine($SourceDirectory, "dist", "database")
	$AppSourceDirectoryPath = [IO.Path]::Combine($SourceDirectory, "dist", "application")
	
	$PackagesDirectoryPath = [IO.Path]::Combine($ScriptDirectory, "packages")
	
	$PackageDirectoryPath = [IO.Path]::Combine($PackagesDirectoryPath, ($PackageNameParts | Join-String -Separator "-").ToLower())
	$PackageApplicationDirectoryPath = [IO.Path]::Combine($PackageDirectoryPath, "application")
	$PackageDatabaseDirectoryPath = [IO.Path]::Combine($PackageDirectoryPath, "database")
	
	$CompressedPackageFileName = "$($PackageDirectoryPath).zip"
	
	$AppSettingsFilePath = [IO.Path]::Combine($AppSourceDirectoryPath, "appsettings.json")
	$RuntimeConfigFilePath = [IO.Path]::Combine($AppSourceDirectoryPath, "$($ApplicationName).runtimeconfig.json")
	$DepsConfigFilePath = [IO.Path]::Combine($AppSourceDirectoryPath, "$($ApplicationName).deps.json")
	$WebConfigFilePath = [IO.Path]::Combine($AppSourceDirectoryPath, "web.config")
	
	# Create Package Directory
	if(-not (Test-Path -PathType container $PackageDirectoryPath))
	{
		New-Item -ItemType Directory -Path $PackageDirectoryPath
		
		New-Item -ItemType Directory -Path $PackageApplicationDirectoryPath
		New-Item -ItemType Directory -Path $PackageDatabaseDirectoryPath
	}
	else
	{
		Get-ChildItem -Path $PackageDirectoryPath -Recurse | Remove-Item -Force -Recurse
		
		New-Item -ItemType Directory -Path $PackageApplicationDirectoryPath
		New-Item -ItemType Directory -Path $PackageDatabaseDirectoryPath
	}
	
	# Remove existing package file
	if(Test-Path -PathType leaf $CompressedPackageFileName)
	{
		Get-ChildItem -Path $CompressedPackageFileName | Remove-Item -Force -Recurse
	}
	
	# Copy Database SQL Files
	Copy-Item -Path ([IO.Path]::Combine($DatabaseSourceDirectoryPath, "*")) -Destination $PackageDatabaseDirectoryPath -Recurse
	
	# Copy runtimes Directory
	Copy-Item -Path ([IO.Path]::Combine($AppSourceDirectoryPath, "runtimes")) -Destination $PackageApplicationDirectoryPath -Recurse
	
	# Copy wwwroot Directory
	Copy-Item -Path ([IO.Path]::Combine($AppSourceDirectoryPath, "wwwroot")) -Destination $PackageApplicationDirectoryPath -Recurse
	
	# Copy wwwroot Directory
	Copy-Item -Path ([IO.Path]::Combine($AppSourceDirectoryPath, "clientapp")) -Destination $PackageApplicationDirectoryPath -Recurse
	
	# Copy File Storage Directories
	Copy-Item -Path ([IO.Path]::Combine($AppSourceDirectoryPath, "temp")) -Destination $PackageApplicationDirectoryPath -Recurse
	Copy-Item -Path ([IO.Path]::Combine($AppSourceDirectoryPath, "files")) -Destination $PackageApplicationDirectoryPath -Recurse
	
	# Copy Application Libraries and Executables
	Get-ChildItem -Path ([IO.Path]::Combine($AppSourceDirectoryPath, "*")) -Include "*.dll" -Recurse | Copy-Item -Destination $PackageApplicationDirectoryPath
	
	# Copy Configuration Files
	Copy-Item -Path $AppSettingsFilePath -Destination $PackageApplicationDirectoryPath
	Copy-Item -Path $RuntimeConfigFilePath -Destination $PackageApplicationDirectoryPath
	Copy-Item -Path $DepsConfigFilePath -Destination $PackageApplicationDirectoryPath
	Copy-Item -Path $WebConfigFilePath -Destination $PackageApplicationDirectoryPath
	
	# Create Compressed Package File
	Compress-Archive -Path ([IO.Path]::Combine($PackageDirectoryPath, "*")) -DestinationPath $CompressedPackageFileName -CompressionLevel Optimal
	
	#Remove the Temporay Package Directory
	Remove-Item $PackageDirectoryPath -Force -Recurse
}

function CreateSetupPackage
{
	
}

try
{
	if($Command -eq "app")
	{
		CreateApplicationPackage
	}
	elseif($Command -eq "setup")
	{
		CreateSetupPackage
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