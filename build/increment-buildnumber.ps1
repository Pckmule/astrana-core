#Requires -PSEdition Core

Param(
	[Parameter(Mandatory = $True)]
	[Alias('f')]
	[string]$ProjectDirectory,
	
	[Alias('m')]
	[string]$Mode
)

$ScriptDirectory = $PWD

function IncrementBuildVersion
{
	Param(
		[Parameter(Mandatory = $True)]
		[string]$FilePath
	)

	if(Test-Path -PathType leaf $FilePath)
	{
		$lines = Get-Content $FilePath
		
		$pattern = "([0-9].[0-9].[0-9].[0-9])"
		
		foreach($line in $lines)
		{
			if ($line.Contains("AssemblyFileVersionAttribute") -or $line.Contains("AssemblyInformationalVersionAttribute") -or $line.Contains("AssemblyVersionAttribute"))
			{
				Write-Host $line -ForegroundColor Yellow
				if($line -match $pattern) 
				{
					Write-Host $matches[0];
				}
			}	
		}
	}
}

function Execute
{
	$AssemblyInfoFilePaths = (Get-ChildItem -Recurse -Path $ProjectDirectory -Include *.AssemblyInfo.cs | Where {$_.PSIsContainer -eq $false}).fullname

	foreach($AssemblyInfoFilePath in $AssemblyInfoFilePaths)
	{
		IncrementBuildVersion $AssemblyInfoFilePath
	}
}

try
{
	Execute
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