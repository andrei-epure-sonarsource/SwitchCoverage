# SwitchCoverage

Test case for https://github.com/SonarSource/sonar-dotnet/pull/3302

Commands to run

```
nuget restore .\SwitchCoverage.sln

msbuild .\SwitchCoverage.sln /t:Rebuild

OpenCover.Console.exe -output:"opencover.xml" -register:administrator -target:"C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" -targetargs:".\SwitchCoverageTest1\bin\Debug\netcoreapp3.1\SwitchCoverageTest1.dll .\NUnitTestProject1\bin\Debug\netcoreapp3.1\NUnitTestProject1.dll"
```
