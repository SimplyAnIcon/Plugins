@echo Off
set config=%1
if "%config%" == "" (
   set config=Release
)
 
set version=1.0.0
if not "%PackageVersion%" == "" (
   set version=%PackageVersion%
)

set nuget=
if "%nuget%" == "" (
	set nuget=nuget
)

call %NuGet% restore SimplyAnIcon.Plugins.sln -NonInteractive
msbuild SimplyAnIcon.Plugins.sln /p:Configuration="%config%" /p:DebugSymbols=true /p:DebugType=full /p:Platform="Any CPU" /p:GenerateDocumentation=true /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=diag /nr:false

mkdir Build
mkdir Build\lib
mkdir Build\lib\net461

%nuget% pack "Plugins.nuspec" -NoPackageAnalysis -verbosity detailed -o Build -Version %version% -p Configuration="%config%"
