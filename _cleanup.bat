@ECHO OFF

FOR /d /r . %%d IN (bin,obj) DO @IF EXIST "%%d" RD /s /q "%%d"