git pull;
rm -rf .PublishFiles;
dotnet build;
dotnet publish -o /home/LYProjectApi/LYProjectApi.Api/bin/Debug/netcoreapp3.1;
cp -r /home/LYProjectApi/LYProjectApi.Api/bin/Debug/netcoreapp3.1 .PublishFiles;
echo "Successfully!!!! ^ please see the file .PublishFiles";