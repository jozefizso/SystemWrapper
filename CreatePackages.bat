@echo off
.nuget\NuGet.exe install .nuget\packages.config -OutputDirectory packages -Source "https://www.nuget.org/api/v2"
powershell.exe -NoProfile -ExecutionPolicy unrestricted -Command "& {Import-Module '.\packages\psake.*\tools\psake.psm1'; invoke-psake .\psake-project.ps1 -Task Pack %*; if ($LastExitCode -and $LastExitCode -ne 0) {write-host "ERROR CODE: $LastExitCode" -fore RED; exit $lastexitcode} }"
