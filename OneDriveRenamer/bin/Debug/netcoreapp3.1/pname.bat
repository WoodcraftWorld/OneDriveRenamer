@echo off
powershell -Command "& {Add-Type -AssemblyName Microsoft.VisualBasic; [Microsoft.VisualBasic.Interaction]::InputBox('Enter what you would like to rename your OneDrive Personal to:', 'OneDrive Rename Tool')}" > %TEMP%\out.tmp
set /p value=<%TEMP%\out.tmp
echo Windows Registry Editor Version 5.00>%TEMP%\temp.reg
more reg>>%TEMP%\temp.reg
echo [HKEY_CURRENT_USER\Software\Classes\CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}]>>%TEMP%\temp.reg
echo @="%value%">>%TEMP%\temp.reg
%TEMP%\temp.reg
del %TEMP%\temp.reg