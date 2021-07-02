"D:\sonar-scanner-msbuild-5.0.0.23533-net46\SonarScanner.MSBuild.exe" begin /k:"WebApplication2" /d:"sonar.host.url=http://localhost:8000" /d:sonar.password=sonar /d:sonar.login=sonar
msbuild.exe /t:rebuild
"D:\sonar-scanner-msbuild-5.0.0.23533-net46\SonarScanner.MSBuild.exe" end /d:sonar.login=sonar /d:sonar.password=sonar
