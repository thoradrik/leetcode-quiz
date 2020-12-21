@ECHO OFF

CD %~dp0

IF "%~1"=="" GOTO :usage
IF "%~2"=="" GOTO :usage

    SET n=0000%1
    SET d=%n:~-4%_%2

    MD %d%

    COPY libs\Template\Template.csproj problems\%d%\%2.csproj
    COPY libs\Template\Program.cs problems\%d%\Program.cs
    COPY libs\Template\Solution.cs problems\%d%\Solution.cs

    GOTO :eof

:usage
    ECHO Usage: %~n0 Number Name
    EXIT 1
