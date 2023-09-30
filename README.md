#### Installation Instructions
- Clone repository
- Create appsettings.json file. Update the contents with 
```
{
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE_NAME];uid=[YOUR_ID];pwd=[YOUR_PASSWORD];"
    }
}
```
- In your terminal run `dotnet build`
- Once the project builds with no errors, run `dotnet ef database update` to update your database.
- In your terminal run `dotnet watch run` to launch on a local server


-------------------------------------------------------------

## To do list
- add week # endpoint
- add email and episode total columns