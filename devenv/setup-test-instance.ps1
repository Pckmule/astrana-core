#Requires -PSEdition Core
#Requires -RunAsAdministrator

Param(
	[Parameter(Mandatory = $True)]
	[Alias('c')]
	[string]$Command
)

$ScriptDirectory = $PWD

$ScriptMajorVersion = 1
$ScriptMinorVersion = 0
$ScriptPatchVersion = 0

$ScriptVersion = "$($ScriptMajorVersion).$($ScriptMinorVersion).$($ScriptPatchVersion)"

Write-Host "Astrana Instance Setup Utility $ScriptVersion" -ForegroundColor White
Write-Host ""

function SetupInstances
{
	
}

try
{
	SetupInstances
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