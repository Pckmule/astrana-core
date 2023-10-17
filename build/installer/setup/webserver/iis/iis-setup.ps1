#Requires -RunAsAdministrator
#Requires -PSEdition Desktop

Param
(
    [Parameter(Mandatory = $true)]
	[string]$AppName,

    [Parameter(Mandatory = $true)]
	[string]$RootDirectory,

	[string]$Domain,

	[int]$Port = 80,
	
	[string]$GrantFullAccessToDirectories = "",
	
	[Alias('re')]
	[switch]$RemoveExisting
)

$Host.UI.RawUI.WindowTitle = "Astrana Web Server Setup"

$ScriptDirectory = $PWD

$AppNameLowerCase = $AppName.ToLower()

$AppPoolName = "$($AppName)AppPool"
$SiteName = $AppName.Replace(" ", "")
$PhysicalPath = $RootDirectory

$HostHeader = "localhost"
if(-not ([string]::IsNullOrEmpty($Domain)))
{
	$HostHeader = $Domain
}

function Check-IISExists
{
	# Import-Module ServerManager
	<# 
	if ((Get-WindowsFeature Web-Server).InstallState -eq "Installed") 
	{
		Write-Host "Windows IIS" -ForegroundColor DarkYellow
		return $True;
	} 
	elseif((Get-WindowsOptionalFeature -Online -FeatureName "IIS-WebServerRole").State -eq "Enabled") 
	{
		Write-Host "Windows 10 IIS" -ForegroundColor DarkYellow
		return $True;
	}
	
	return $False; #>
	
	return $True
}

try
{	
	Import-Module WebAdministration
	
	if(-not (Check-IISExists))
	{
		throw "IIS is not installed."
	}
	
	if($RemoveExisting.IsPresent)
	{
		Remove-IISSite -Name $SiteName -Confirm:$False
		Remove-WebAppPool -Name $AppPoolName -Confirm:$False
	}
	
	if(Test-Path IIS:\AppPools\$AppPoolName)
	{
		Write-Host "IIS Application Pool called $AppPoolName already exists." -ForegroundColor DarkYellow
	}
	else
	{
		New-WebAppPool -Name $AppPoolName
		Set-ItemProperty -Path IIS:\AppPools\$AppPoolName managedRuntimeVersion "v4.0"

		New-WebSite -Name $SiteName -Port $Port -HostHeader $HostHeader -PhysicalPath $PhysicalPath
		New-IISSiteBinding -Name $SiteName -BindingInformation "*:443:" -CertificateThumbPrint "ffb9cce9a2db39bcd5ed9e849cf6d7a9a01936fb" -CertStoreLocation "Cert:\LocalMachine\My" -Protocol https

		New-WebApplication -Name $AppPoolName -Site $SiteName -PhysicalPath $PhysicalPath -ApplicationPool $AppPoolName
		
		$DirectoriesToGrantFullAccessRightsTo = ($GrantFullAccessToDirectories -Split ",")
		
		foreach($directory in $DirectoriesToGrantFullAccessRightsTo)
		{
			$dir = ([IO.Path]::Combine($PhysicalPath, $directory.Trim()))
			
			if(-not (Test-Path -PathType container $dir))
			{
				New-Item -ItemType Directory -Path $dir
			}

			Write-Host "Granting full access rights to $($dir)..."			
			& icacls $dir /grant "IIS AppPool\$($AppPoolName):F" /inheritancelevel:E
			Write-Host "Granted" -ForegroundColor Green		
		}
			
		exit 0
	}
}
catch
{
	Write-Host $_ -ForegroundColor Red
	exit 2
}
finally
{
	Set-Location $ScriptDirectory
}