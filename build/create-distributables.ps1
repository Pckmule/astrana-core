#Requires -PSEdition Core
#Requires -RunAsAdministrator

Param(
	[Parameter(Mandatory = $True)]
	[Alias('c')]
	[ValidateSet("full", "webui", "core", IgnoreCase = $True)]
	[string]$Command
)

$ScriptDirectory = $PWD

$ScriptMajorVersion = 1
$ScriptMinorVersion = 0
$ScriptPatchVersion = 0

$ScriptVersion = "$($ScriptMajorVersion).$($ScriptMinorVersion).$($ScriptPatchVersion)"

$WebUiSourceDirectory = "D:\repos\Astrana\Pckmule\astrana-webui"
$WebUiSourcePublishDirectory = "D:\repos\Astrana\Pckmule\astrana-webui\build"

$CoreSourceClientAppDirectory = "D:\repos\Astrana\Pckmule\astrana-core\src\Astrana.Core.Application\clientapp"
$CoreSourceCSProjFilePath = "D:\repos\Astrana\Pckmule\astrana-core\src\Astrana.Core.Application\Astrana.csproj"
$CoreSourcePublishProfileFilePath = "D:\repos\Astrana\Pckmule\astrana-core\src\Astrana.Core.Application\Properties\PublishProfiles\Portable-Release.pubxml"

$PublishOutputDirectory = "D:\repos\Astrana\Pckmule\astrana-core\dist\application"

Write-Host "Astrana Source Publishing Utility $ScriptVersion" -ForegroundColor White
Write-Host ""

function PublishWebUI
{
	Write-Host "Publishing Web UI Solution... " -ForegroundColor Cyan
	Write-Host ""

	Set-Location $WebUiSourceDirectory
	yarn build
	Set-Location $ScriptDirectory
	
	Write-Host ""
	
	ls ([IO.Path]::Combine($CoreSourceClientAppDirectory, "build"))
	
	Remove-Item ([IO.Path]::Combine($CoreSourceClientAppDirectory, "build")) -Force -Recurse
	Copy-Item -Path $WebUiSourcePublishDirectory -Destination $CoreSourceClientAppDirectory -Force -Recurse
	
	Write-Host ""
	Write-Host "Complete" -ForegroundColor Green
	Write-Host ""
}

function PublishCoreApplication
{
	Write-Host "Publishing Core Solution... " -ForegroundColor Cyan
	Write-Host ""

	dotnet publish $CoreSourceCSProjFilePath --configuration Release -p:PublishProfile=$CoreSourcePublishProfileFilePath
	
	Copy-Item -Path $CoreSourceClientAppDirectory -Destination ([IO.Path]::Combine($PublishOutputDirectory, "clientapp")) -Force -Recurse
	
	Write-Host ""
	Write-Host "Complete" -ForegroundColor Green
	Write-Host ""
}

function Publish
{
	PublishWebUI
	PublishCoreApplication
}

try
{
	if($Command -eq "full")
	{
		Publish
	}
	
	if($Command -eq "webui")
	{
		PublishWebUI
	}
	
	if($Command -eq "core")
	{
		PublishCoreApplication
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