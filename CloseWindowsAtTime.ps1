# Author: Michał Flisikowski
$TimeToOff = Read-Host "Enter time in 24 hour format that PC should shut down [xx:xx]"
Write-Host "Now computer will be closed automatically."
Write-Host "Waiting..."
$TimeNow = Get-Date -Format HH:mm
While(Compare-Object -ReferenceObject $TimeToOff $TimeNow)
{
   Start-Sleep -s 60 
   $TimeNow = Get-Date -Format HH:mm
}
Write-Host "Turning off... Goodbye! :)" -ForegroundColor red
Start-Sleep -s 15 
Stop-Computer
