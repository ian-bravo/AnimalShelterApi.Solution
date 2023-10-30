# _Animal Shelter API_

#### By _**Ian Bravo**_

#### _This web API will list the available cats and dogs at the local animal shelter._

## Technologies Used

* _C# 10.0_
* _HtmL_
* _css_
* _Bootstrap_
* _.Net 6.0_
* _ASP.NET Core MVC 6.0_
* _Entity Framework Core_
* _MySQL Community Server_


## Description

This C# web API will allow the local animal shelter to design any front-end application using this back-end application. This web API has many different endpoints as stated below. All CRUD function is implemented. 

## Setup/Installation Requirements

Installing/Configuring MySQL:

1. Follow the instructions on this <a href="https://full-time-pre-october.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql">page</a> for installing and configuring MySQL.

Installing Postman:
1. Follow the instructions <a href="https://www.postman.com/downloads/">here,</a> for installing Postman to use for API calling.


Installing dotnet-ef:
1. Run the following command to globally install dotnet-ef tools which will allow you to create migrations and create databases:    
   `$ dotnet tool install --global dotnet-ef --version 6.0.0`

Cloning the Repo:
1. Open the terminal.
2. Change your directory to where you would want the cloned directory.
3. Input the following command into your terminal:  
 `$ git clone https://github.com/ian-bravo/AnimalShelterApi.Solution.git`
4. Using the terminal, navigate to the production directory: "AnimalShelterApi" and create a new file called appsettings.json
5. Within appsettings.json, put in the following code while also replacing the following values with your own values as shown in the code snippet below:
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* [YOUR-USERNAME-HERE] with your username
* [YOUR-PASSWORD-HERE] with your password
* [YOUR-DB-NAME] with the name of your database

Generating the database:
1. Navigate to the project's production directory "AnimalShelterApi" using the terminal.
2. Run the following command to update the database:    
  `$ dotnet ef database update`

Launch the API:
1. Navigate to the project's production directory "AnimalShelterApi" using the terminal.
2. Run the following command to grant access for the browser/Postman to use the API:      
  `$ dotnet run`

## API Documentation
Explore the API endpoints via Postman.

### Pagination:
This API is currently a WIP for developing the pagination feature when displaying multiple return query.

----------------------------------------------------------------

### Endpoints:
Base URL: 
```
https://localhost:5000
```
----------------------------------------------------------------

### HTTP Request Structure:
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example GET query:
```
https://localhost:5000/api/dogs/2
```

#### Sample JSON Response:
```
{
        "dogId": 2,
        "name": "Winky",
        "size": "Small",
        "sex": "Male",
        "age": 3
    }
```

----------------------------------------------------------------

### Cats

#### Http Request:
```
GET http://localhost:5000/api/cats
GET http://localhost:5000/api/cats/{id}
POST http://localhost:5000/api/cats
PUT http://localhost:5000/api/cats/{id}
DELETE http://localhost:5000/api/cats/{id}
```

#### Path Parameters:
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | true | Return matches by name.
| size | string | none | true | Return any cat by size description. |
| sex | string | none | true | Return any cat by sex. |
| age | int | none | true | Return any cat with a minimum age. |

#### Example GET query:
```
http://localhost:5000/api/cats?sex=Female&minimumAge=5
```

#### Sample JSON Response:
```
[
    {
        "catId": 1,
        "name": "Anya",
        "size": "Large",
        "sex": "Female",
        "age": 7
    },
    {
        "catId": 2,
        "name": "Faith",
        "size": "Medium",
        "sex": "Female",
        "age": 10
    }
]
```
----------------------------------------------------------------

### Dogs

#### Http Request:
```
GET http://localhost:5000/api/dogs
GET http://localhost:5000/api/dogs/{id}
POST http://localhost:5000/api/dogs
PUT http://localhost:5000/api/dogs/{id}
DELETE http://localhost:5000/api/dogs/{id}
```

#### Path Parameters:
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | true | Return matches by name.
| size | string | none | true | Return any dog by size description. |
| sex | string | none | true | Return any dog by sex. |
| age | int | none | true | Return any dog with a minimum age. |

#### Example GET query:
```
http://localhost:5000/api/dogs?sex=Female&minimumAge=5
```

#### Sample JSON Response:
```
[
    {
        "dogId": 1,
        "name": "Beatrice",
        "size": "Large",
        "sex": "Female",
        "age": 5
    },
    {
        "dogId": 5,
        "name": "Jessica",
        "size": "Medium",
        "sex": "Female",
        "age": 7
    }
]
```

## Known Bugs

* _Pagination is under development_

## License

MIT License  

Copyright (c) 27-Oct-2023 Ian Bravo

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:  

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.  

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

_For questions or concerns, please email me at bravo.ian@gmail.com_