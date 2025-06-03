@echo off
 
schtasks /create /tn "TestTask" /tr "cmd.exe /c whoami > C:\whoami.txt" /sc once /st 14:00