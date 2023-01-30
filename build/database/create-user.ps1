#requires -PSEdition Core

Param
(
	[Parameter(Mandatory=$true)]
	[ValidateSet("PostgreSQL", "MySQL", "MSSQLServer", IgnoreCase = $true)]
	[String] 
	$DatabaseProvider,
	
	[Parameter(Mandatory=$true)] 
	[String] 
	$ServerAddress,
	
	[Parameter(Mandatory=$true)] 
	[String] 
	$DbName,
	
	[Parameter(Mandatory=$true)] 
	[String] 
	$DbUsername,
	
	[Parameter(Mandatory=$true)] 
	[String] 
	$DbPassword
) 

$DatabaseProviderLowered = $DatabaseProvider.ToLower();
$SqlFilePath = "$PSScriptRoot\$DatabaseProviderLowered\create-user.sql";

$SqlQuery = Get-Content -Raw $SqlFilePath;
$SqlQuery = $SqlQuery -Replace "{Database_Name}", $DbName;
$SqlQuery = $SqlQuery -Replace "{Database_Username}", $DbUsername;
$SqlQuery = $SqlQuery -Replace "{Database_Password}", $DbPassword;

if($DatabaseProviderLowered -eq "postgresql")
{
	Write-Host "Checking for PSQL executable... " -ForegroundColor Cyan -NoNewLine
	if ((Get-Command "psql" -ErrorAction SilentlyContinue) -eq $null) 
	{ 
		Write-Host "Not Found" -ForegroundColor Red
	}
	else
	{
		Write-Host "Found" -ForegroundColor Green
	}
}
else
{
	Write-Host "Checking for SqlCmd PowerShell module... " -ForegroundColor Cyan -NoNewLine
	if (Get-Module -ListAvailable -Name "SqlServer") 
	{
		Write-Host "Found" -ForegroundColor Green
	}
	else 
	{
		Write-Host "Installing SqlServer module... " -ForegroundColor Cyan -NoNewLine
		
		try
		{
			Install-Module -Name "SqlServer"
			Write-Host "Success" -ForegroundColor Green
		}
		catch 
		{
			Write-Host "Failed" -ForegroundColor Red
			exit -1;
		}
	}

	Write-Host "Creating database user... " -ForegroundColor Cyan -NoNewLine
	try
	{
		Invoke-SqlCmd -ServerInstance $ServerAddress -Database $DbName -Query $SqlQuery -ErrorAction 'Stop' 
		Write-Host "Success" -ForegroundColor Green
	}
	catch 
	{
		Write-Host "Failed" -ForegroundColor Red
	}
}

Write-Host "Complete"