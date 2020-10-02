@echo off
REM Moves libraries into their own folder.

REM Check if lib folder exists first.
IF EXIST UXL-Launcher\bin\Debug\lib\ (
REM If it exists, re-create the folder.
rmdir /s /q UXL-Launcher\bin\Debug\lib
mkdir UXL-Launcher\bin\Debug\lib
REM Start moving.
GOTO STARTMOVE
) ELSE (
REM Folder doesn't exist, so create it.
mkdir UXL-Launcher\bin\Debug\lib
REM Start moving.
GOTO STARTMOVE
)

:STARTMOVE

REM Move all DLL files in the bin\Debug directory into the "lib" folder.
move UXL-Launcher\bin\Debug\*.dll UXL-Launcher\bin\Debug\lib\

REM Exit the script so VS doesn't say we exited with code 1.
exit