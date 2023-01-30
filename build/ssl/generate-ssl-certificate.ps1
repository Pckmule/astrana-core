#Requires -PSEdition Core
#Requires -RunAsAdministrator

Param(
	[string]$OutputDirectory,
	[string]$ValidityPeriodInDays,	
	[string]$CertificateName
)

if([string]::IsNullOrEmpty($CertificateName))
{
	$CertificateName = "Astrana"
}

$CertificateNameLowerCase = $CertificateName.ToLower()

if([string]::IsNullOrEmpty($OutputDirectory))
{
	$OutputDirectory = "$PWD\certificate"
}

if (-not (Test-Path $OutputDirectory -PathType Container)) 
{
    New-Item $OutputDirectory -ItemType Directory
}

if($ValidityPeriodInDays -lt 1)
{
	$ValidityPeriodInDays = 356
}

Write-Host "Generating $CertificateName SSL Certificate..." -ForegroundColor Cyan
Write-Host ""

Write-Host "Output directory: $OutputDirectory" -ForegroundColor Yellow
Write-Host ""

Write-Host "Generating certificate key..." -ForegroundColor Yellow
Invoke-Expression -Command "openssl genpkey -out $OutputDirectory/$CertificateNameLowerCase.key -algorithm RSA -pkeyopt rsa_keygen_bits:2048"
Write-Host ""

Write-Host "Generating certificate CSR..." -ForegroundColor Yellow
Invoke-Expression -Command "openssl req -new -key $OutputDirectory/$CertificateNameLowerCase.key -out $OutputDirectory/$CertificateNameLowerCase.csr"
Write-Host ""

Write-Host "CSR Text:" -ForegroundColor Yellow
Invoke-Expression -Command "openssl req -text -in $OutputDirectory/$CertificateNameLowerCase.csr -noout"
Write-Host ""

Write-Host "Self signing certificate..." -ForegroundColor Yellow
Invoke-Expression -Command "openssl x509 -req -days $ValidityPeriodInDays -in $OutputDirectory/$CertificateNameLowerCase.csr -signkey $OutputDirectory/$CertificateNameLowerCase.key -out $OutputDirectory/$CertificateNameLowerCase.crt"
Write-Host ""

Write-Host "Exporting PFX..." -ForegroundColor Yellow
Invoke-Expression -Command "openssl pkcs12 -export -in $OutputDirectory/$CertificateNameLowerCase.crt -inkey $OutputDirectory/$CertificateNameLowerCase.key -out $OutputDirectory/$CertificateNameLowerCase.pfx"
Write-Host ""

Write-Host "Creating PEM file from PFX..." -ForegroundColor Yellow
Invoke-Expression -Command "openssl pkcs12 -in $OutputDirectory/$CertificateNameLowerCase.pfx -out $OutputDirectory/$CertificateNameLowerCase.pem -nodes"
Write-Host ""
