msbuild.exe SystemInterface\SystemInterface.csproj /p:Configuration="Release 4.5" /p:Platform="AnyCPU" /t:Build;Package;Publish

msbuild.exe SystemWrapper\SystemWrapper.csproj /p:Configuration="Release 4.5" /p:Platform="AnyCPU" /t:Build;Package;Publish

