echo Restoring packages
nuget restore RiaServices.sln

IF %ERRORLEVEL% NEQ 0 (
 echo Restore failed ERRORLEVEL = %ERRORLEVEL%
 exit /B 1
)

echo Building Release version
msbuild RiaServices.sln /t:Rebuild /p:Configuration=Release /verbosity:minimal /m

IF %ERRORLEVEL% NEQ 0 (
 echo Release Build failed ERRORLEVEL = %ERRORLEVEL%
 exit /B 2
)
echo Release Build succeeded

echo Building Signed  version
msbuild RiaServices.sln /t:Rebuild /p:Configuration=Signed /verbosity:minimal /m

IF %ERRORLEVEL% NEQ 0 (
 echo Signed Build failed ERRORLEVEL = %ERRORLEVEL%
 exit /B 3
)

echo Signed Build succeeded