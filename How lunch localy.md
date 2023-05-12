Install dotnet7
Go to project for example ..\src\backend\PersonalTaskManager.Core.Api

run project
dotnet run --launch-profile <profile-name>
    - example "dotnet run --launch-profile https"

To open Swagger (Open API Explorer), in your browser type 'https://localhost:5250/swagger/index.html'.

If you recive certificat error, add dev certificat 'dotnet dev-certs https --trust