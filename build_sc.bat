"D:\sonar-scanner-msbuild-5.0.0.23533-net46\SonarScanner.MSBuild.exe" begin /k:"WebApplication2-" /o:"budzow-github" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="73c56cf51072a07dee47c081e20b460d51ca6e4c"
msbuild.exe /t:rebuild
"D:\sonar-scanner-msbuild-5.0.0.23533-net46\SonarScanner.MSBuild.exe" end /d:sonar.login="73c56cf51072a07dee47c081e20b460d51ca6e4c"
