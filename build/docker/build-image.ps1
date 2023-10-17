#Requires -PSEdition Core
#Requires -RunAsAdministrator

Param(
	[Parameter(Mandatory=$true)]        
	[int]$ImageVersion,     
	[string]$SslCertificateName,
	[Switch]$GenerateSsl
)

$ScriptDirectory = $PSScriptRoot

if([string]::IsNullOrEmpty($SslCertificateName))
{
	$SslCertificateName = ""
}

function Check-AppExists
{
	Param([Parameter(Position=0, Mandatory=$true)] [string]$appName)
	
	return [bool] (Get-Command -ErrorAction Ignore -Type Application $appName)
}

function Check-Prerequisites
{
	Write-Host "Checking Prerequisites... " -ForegroundColor Cyan -NoNewLine
		
	$result = $True;
	
	$missingPrerequisites = New-Object System.Collections.Generic.List[string]
    
	if(!(Check-AppExists "docker"))
	{
		$missingPrerequisites.Add("Docker")
		$result = $False
	}

	if($GenerateSsl.IsPresent)
	{
		if(!(Check-AppExists "openssl"))
		{
			$missingPrerequisites.Add("OpenSSL")
			$result = $False
		}
	}
	
	if($result)
	{
		Write-Host "Passed" -ForegroundColor Green
		Write-Host ""
	}
	else
	{
		Write-Host "Failed" -ForegroundColor Red
		
		Write-Host ""		
		Write-Host "The following prerequisites were not found on the system:" -ForegroundColor Yellow
		foreach ($applicationName in $missingPrerequisites)
		{
			Write-Host " - "$applicationName -ForegroundColor Yellow
		}
		Write-Host ""
	}
	
	return $result
}

if(!(Check-Prerequisites))
{
	exit -1;
}

if($GenerateSsl.IsPresent)
{
	Write-Host "Generate Self-Signed SSL Certificate..." -ForegroundColor Cyan

	.\..\ssl\generate-ssl-certificate.ps1 -OutputDirectory "$ScriptDirectory\release\config\ssl-certificate" -CertificateName $SslCertificateName

	Write-Host ""
}

Write-Host "Creating Astrana Docker Image..." -ForegroundColor Cyan

docker build --tag "astrana" .

Write-Host ""
