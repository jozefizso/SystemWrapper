msbuild.exe SystemInterface\SystemInterface.csproj /p:Configuration="Release 4.0" /t:Build
msbuild.exe SystemInterface\SystemInterface.csproj /p:Configuration="Release 4.5" /t:Build;Package;Publish

msbuild.exe SystemWrapper\SystemWrapper.csproj /p:Configuration="Release 4.0" /t:Build
msbuild.exe SystemWrapper\SystemWrapper.csproj /p:Configuration="Release 4.5" /t:Build;Package;Publish

