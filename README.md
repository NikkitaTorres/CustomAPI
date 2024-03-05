# ShoeStore 
by Nikkita Torres<nikkitatorres@yahoo.com>

### Description

This is a project for adding shoes to a Shoe Store. A user is able to create, read, update, and delete any of the shoes that are placed in the store.

### Setup/Installation Requirements

* .NET must be installed. Latest version can be found [here](https://dotnet.microsoft.com/en-us/).
* To run locally on your computer, clone the main branch of this [repository](https://github.com/NikkitaTorres/CustomAPI.git).
* In your terminal, navigate to the root folder of this project (ShoeStoreAPI.Solution) and run `dotnet restore`.
* Create a new file in the "ShoeStoreApi" directory called "appsettings.json".
* In `appsettings.json`, enter the following, replacing `USERNAME` and `PASSWORD` to match the settings of your local MySQL server. Replace `DATABASE-NAME` with whatever you would like to name your database.
  
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
        "DefaultConnection": "Server=localhost;Port=3306;database=DATABASE-NAME;uid=USERNAME;pwd=PASSWORD;"
    },
    "JWT": {
        "ValidAudience": "example-audience",
        "ValidIssuer": "example-issuer",
        "Secret": "SecretPassword12"
    }
}
```
* In your terminal, navigate to the "ShoeStoreApi" directory and run `dotnet ef database update` to create a local database.
* To view the project's API end points in a web browser, navigate to the "ShoeStoreApi" directory and run `dotnet watch run`.

### Built With
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![MySQL](https://img.shields.io/badge/mysql-%2300f.svg?style=for-the-badge&logo=mysql&logoColor=white)
![Git](https://img.shields.io/badge/git-%23F05033.svg?style=for-the-badge&logo=git&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Swagger](https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white)
![Postman](https://img.shields.io/badge/Postman-FF6C37?style=for-the-badge&logo=postman&logoColor=white)
![Markdown](https://img.shields.io/badge/Markdown-000000?style=for-the-badge&logo=markdown&logoColor=white)
![npm](https://img.shields.io/badge/npm-CB3837?style=for-the-badge&logo=npm&logoColor=white)
[ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
[Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

### API Endpoints
*Any mention of {id} below will be a variable that changes with relation to the user's specific object id that autoincrements and cannot be accounted for below*

ShoeStore Requests:

`GET https://localhost:5001/api/Shoes` This will create a request to return all shoe objects.

`GET http://localhost:5001/api/Shoes/{id}` This will create a request to return a specific shoe object based on its ShoeId property.

`POST http://localhost:5001/api/Shoes` This will add a new shoe to our database and requires a request body with an object literal of a shoe.
Here is an example of what the request body should look like:
{
  "shoeId": 0,
  "name": "string",
  "brand": "string",
  "colors": "string"
}

`PUT http://localhost:5001/api/Shoes/{id}` This will create a request to update information for a specific shoe by its ShoeId.
Here is an example of what the request body should look like:
{
  "shoeId": 0,
  "name": "string",
  "brand": "string",
  "colors": "string"
}

`DELETE http://localhost:5001/api/Shoes/{id}` This will create a request to delete a specific shoe by its ShoeId.

### Known Issues/Bugs

No known bugs at this time.

### License
MIT License

Copyright (c) 2023

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.