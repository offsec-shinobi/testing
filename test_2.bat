@echo off
set "outfile=%TEMP%\result.txt"

echo --- User Information --- > "%outfile%"
whoami >> "%outfile%" 

echo. >> "%outfile%"
echo --- IP Configuration --- >> "%outfile%"
ipconfig >> "%outfile%" 