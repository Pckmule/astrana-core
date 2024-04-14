#Requires -PSEdition Core
#Requires -RunAsAdministrator

Param(
	[string]$Platform,
	[string]$ExecutablePath
)

$Platform = $Platform.ToLower()


$ServiceName = "Astrana"
$ServiceDisplayName = "Astrana Application Service"
$ServiceDescription = "The Astrana application service."

$ServiceUserName = "${$ServiceName}User"

Write-Host "Installing the $ServiceName daemon/service on $Platform..." -ForegroundColor Cyan

if($Platform -eq "windows")
{
	$service = Get-Service -Name $ServiceName -ErrorAction SilentlyContinue

	if ($service.Length -gt 0) 
	{
		if ($service.Status -eq "Running")
		{
			Stop-Service -Name $ServiceName
		}

		Remove-Service -Name $ServiceName
	}

	New-Service -Name $ServiceName -DisplayName $ServiceDisplayName -Description $ServiceDescription -BinaryPathName $ExecutablePath -StartupType "Automatic"
	
	if ($service.Status -eq "Stopped")
	{
		Start-Service -Name $ServiceName
	}
}

function CreateServiceUserAccount
{
	New-LocalUser -Name $ServiceUserName
}