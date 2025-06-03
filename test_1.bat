@echo off
echo --- User Information --- > C:\result.txt
whoami >> C:\result.txt

echo. >> C:\result.txt
echo --- IP Configuration --- >> 
ipconfig >> C:\result.txt