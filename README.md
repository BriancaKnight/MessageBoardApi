<br>
<p align="center">
  <u><big>|| <b>MessageBoard Api </b> ||</big></u>
</p>
<p align="center">
    <!-- Project Avatar/Logo -->
    <br>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/BriancaKnight">
            <strong>Brianca Knight</strong>
        </a>
        |
                <a href="https://github.com/Christopher-Quattrocchi">
            <strong>Christopher Quattrocchi</strong>
        </a>
        |
                <a href="https://github.com/boboflofo">
            <strong>Jonathan Song</strong>
        </a>
        |
                <a href="https://github.com/ZuriGa">
            <strong>Zuri Gallegos</strong>
        </a>
    </p>
    <!-- Project Shields -->
    <p align="center">
        <a href="https://github.com/BriancaKnight/MessageBoardApi/graphs/contributors">
            <img src="https://img.shields.io/github/contributors/BriancaKnight/MessageBoardApi.svg?style=plastic">
        </a>
        ¨
        <a href="https://github.com/BriancaKnight/MessageBoardApi/stargazers">
            <img src="https://img.shields.io/github/stars/BriancaKnight/MessageBoardApi.svg?color=yellow&style=plastic">
        </a>
        ¨
        <a href="https://github.com/BriancaKnight/MessageBoardApi/issues">
            <img src="https://img.shields.io/github/issues/BriancaKnight/MessageBoardApi?style=plastic">
        </a>
        ¨
        <a href="https://github.com/BriancaKnight/MessageBoardApi/blob/master/LICENSE.txt">
            <img src="https://img.shields.io/github/license/BriancaKnight/MessageBoardApi?color=orange&style=plastic">
        </a>
        ¨
    </p>    
</p>

<p align="center">
  <small>Initiated February 20th, 2024. Updated February 22nd, 2024.</small>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/BriancaKnight/MessageBoardApi.git"><big>Project Docs</big></a> ·
    <a href="https://github.com/BriancaKnight/MessageBoardApi/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/BriancaKnight/MessageBoardApi/issues"><big>Request Feature</big></a>
</p>

------------------------------
### <u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#🤝-contributors">Contributors</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
    * <a href="#🌟-acknowledgements">Acknowledgements</a>
    
------------------------------

## 🌐 About the Project

### 📖 Description
a message board service that can be accessed via your API. Users should be able to GET and POST messages for specific message boards. WIP

### 🦠 Known Bugs

* If any bugs are discovered, please contact the author(s).

### 🛠 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL 8.0.20 for Linux](https://dev.mysql.com/)
* [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger - NSwag 13.3.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)

<!-- ### 🔍 Preview -->

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
     * [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [BriancaKnight MessageBoardApi repository here](https://github.com/BriancaKnight/MessageBoardApi).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/BriancaKnight/MessageBoardApi`
  5) Run the command `cd MessageBoardApi` to enter into the project directory.
  6) Run the command `code .` to open the project in VisualStudio Code for review and editing.


  #### AppSettings

  1) Create a new file in the MessageBoardApi project directory named `appsettings.json`
  
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=coffee_tracker_api;uid=root;pwd=YourPassword;"
    }
}
  ```

  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to MessageBoardApi directory in your Terminal 
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to production directory named `MessageBoardApi` in your terminal.
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the MessageBoardApi with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.
* Open Postman and create a POST request using the URL: `http://localhost:5000/api/users/authenticate`
* Add the following query to the request as raw data in the Body tab:
```
{
    "UserName": "CoffeeAdmin",
    "Password": "epicodus"
}
```
* The token will be generated in the response. Copy and paste it as the Token paramenter in the Authorization tab.

### Note on CORS
CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature, CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS.
For more information or to see how CORS functions, see the [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2#how-cors).

### Note on Pagination
The CoffeeTracker API returns a default of 25 results per page at a time, up to a maximum of 1000.

To modify this, use the query parameters `limit` and `start` to alter the response results displayed. The `limit` parameter will specify how many results will be displayed, and the `start` parameter will specify which element in the response the limit should start counting.

#### Example Query
```
https://localhost:5000/api/beverage/?name=mocha&limit=200&start=20
```

To use default, _don't include_ `limit` and `start` or set them equal to zero.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https://localhost:5000/api/recipe/131
```

#### Sample JSON Response
```
{
    "Id": 131,
    "Name": "Spiced Cold Brew",
    "Ingredient": "Cinnamon, Nutmeg, Cayenne",
    "Recipe Text: "Coffee is the answer to all solutions in the known universe as proven by leading scientists.",
}
```

..........................................................................................

### Coffee Beans
Access information on coffee beans from around the world.

#### HTTP Request
```
GET /api/bean
POST /api/bean
GET /api/bean/{id}
PUT /api/bean/{id}
DELETE /api/bean/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.
| origin | string | none | false | Return any bean from a specific country or region of origin. |
| flavor | string | none | false | Return bean matches with a specific flavor profile. |

#### Example Query
```
https://localhost:5000/api/bean/?origin=brazil&flavor=robust
```

#### Sample JSON Response
```
{
    "Id": 114,
    "Name": "Café Saboroso",
    "Origin": "Brazil",
    "Flavor: "Sweet, Cherry, Robust"
}
```

..........................................................................................

### Beverages
Access information about popular coffee beverages.

#### HTTP Request
```
GET /api/beverage
POST /api/beverage
GET /api/beverage/{id}
PUT /api/beverage/{id}
DELETE /api/beverage/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.
| temp | string | none | false | Return beverage matches with a specific served temperature. |
| topping | string | none | false | Return beverage matches with a specific topping. |
| year | int | none | false | Return beverage matches with a specific year of invention. |

#### Example Query
```
https://localhost:5000/api/beverage/?name=latte&temp=iced&year=1840
```

#### Sample JSON Response
```
{
    "Id": 33,
    "Name": "Iced Latte",
    "Temp": "Iced",
    "Topping: "Wipped Cream",
    "Year": 1840
}
```

..........................................................................................

### Recipes
Access recipes to recreate popular coffee beverages.

#### HTTP Request
```
GET /api/recipe
POST /api/recipe
GET /api/recipe/{id}
PUT /api/recipe/{id}
DELETE /api/recipe/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.
| ingredient | string | none | false | Return any recipe with a specific ingredient. |

#### Example Query
```
https://localhost:5000/api/recipe/?name=latte&ingredient=chocolate
```

#### Sample JSON Response
```
{
    "Id": 52,
    "Name": "Mocha Latte",
    "Ingredient": "Chocolate",
    "Recipe Text: "Make good coffee, add chocolate, crash after experiencing the awesome power of both.",
}
```

------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Shawn Lunsford](https://linkedin.com/in/LunsfordSpace) | [LunsfordSpace](https://github.com/LunsfordSpace) |  [lunsford.sk@gmail.com](mailto:lunsford.sk@gmail.com) |

------------------------------

### ✉️ Contact and Support

If you have any feedback or concerns, please contact one of the contributors.

<p>
    <a href="https://github.com/LunsfordSpace/CoffeeTrackerAPI.Solution-API-ReadMe-Example/issues">Report Bug</a> ·
    <a href="https://github.com/LunsfordSpace/CoffeeTrackerAPI.Solution-API-ReadMe-Example/issues">Request Feature</a>
</p>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2021 Shawn Lunsford. All Rights Reserved.

```
MIT License

Copyright (c) 2021 Brianca Knight, Jonathan Song, Zuri Gallegos, and Christopher Quattrocchi.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

------------------------------

### 🌟 Acknowledgments

#### [Epicodus](https://www.epicodus.com/)
>"A school for tech careers... to help people learn the skills they need to get great jobs."

#### [The Internet](https://webfoundation.org/)
> "...the first thing that humanity has built that humanity doesn't understand..."
> - Eric Schmidt, Google (Alphabet Inc.)

------------------------------

<center><a href="#">Return to Top</a></center>


