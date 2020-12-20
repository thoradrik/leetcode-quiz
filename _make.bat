@ECHO OFF

CD %~dp0

IF "%~1"=="" GOTO :usage
IF "%~2"=="" GOTO :usage

    SET n=0000%1
    SET d=%n:~-4%_%2

    MD %d%

    COPY _Template\_Template.csproj %d%\%2.csproj
    COPY _Template\Program.cs %d%\Program.cs
    COPY _Template\Solution.cs %d%\Solution.cs

    GOTO :eof

:usage
    ECHO Usage: %~n0 Number Name
    EXIT 1
