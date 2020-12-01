color B

del  .PublishFiles\*.*   /s /q

dotnet restore

dotnet build

cd LYProjectApi.Api

dotnet publish -o ..\LYProjectApi.Api\bin\Debug\netcoreapp3.1\

md ..\.PublishFiles

xcopy ..\LYProjectApi.Api\bin\Debug\netcoreapp3.1\*.* ..\.PublishFiles\ /s /e 

echo "Successfully!!!! ^ please see the file .PublishFiles"

cmd