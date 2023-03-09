# C# Cellar

#### By Henry Sullivan

#### A web app for cellar inventory.

## Technologies Used

* C#
* .Net 6
* ASP.Net Core 6 MVC
* EF Core 6
* SQL
* MySQL
* MySQL Workbench
* LINQ
* Identity
* X.PagedList
***

## Description

A web app for keeping track of wines in cellar along with the wine details. Also has an education tab to learn more about various wine regions. Can view tasting notes from other users as well.
***

## Setup/Installation Requirements

#### Connect to CSharpCellarAPI
1. Clone the `CSharpCellarApi` to your machine (https://github.com/hbsullivan/CSharpCellarApi.git)
2. Navigate to the `CSharpCellarApi` project directory
3. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
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
    "DefaultConnection": "Server=localhost;Port=3306;database=cellar_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
4. Install dependencies by running in the project directory
```
$ dotnet restore
```
5. Build local copy of database by running in the project directory
```
$ dotnet ef database update
```
6. Build & run API in development by running in the project directory
 ```
 $ dotnet run
 ```
#### Open project
1. Navigate to the `Cellar` directory.
2. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=c_sharp_cellar;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
```
3. Install dependencies within the `Cellar` directory
```
$ dotnet restore
```

4. To build & run program in development mode 
 ```
 $ dotnet run
 ```

5. To build & run program in production mode 
 ```
 dotnet run --launch-profile "production"
 ```
***

## Known Bugs

* 'Sort' functionality does not work
* If you find any other bugs please email me at sullivanbhenry@gmail.com
***

### Research & Planning Log
#### Friday, 02/17
* 9:00-9:30 -- Research on building MVC application
* 9:30-10:00 -- Look through LHTP C# lessons
* 10:00-10:30 -- Continue reviewing C#/.Net concepts
* 10:30-11:00 -- Build out directories
* 11:00-11:30 -- Set up database
* 11:30-12:00 -- Research different controller actions
* 1:00-2:00 -- Watch video about MVC
* 2:00-2:30 -- Start building out some routes
* 2:30-3:30 -- Pause on routes, need to plan more. Start working on a figma
* 3:30-4:15 -- Continue working on figma
* 4:15-4:30 -- EOD: Figma is complete, will begin coding next Friday

#### Friday, 02/24
* 8:00-8:30 -- Day Two. Start CRUD functionality
* 8:30-9:00 -- Research how to implement different controller routes
* 9:00-10:00 -- Try to add 'Drink' route
* 10:00-11:15 -- Add Authentication and Authorization
* 11:15-12:00 -- Associate Wines with users
* 1:00-1:30 -- Research conditionals in controllers
* 1:30-2:00 -- Add 'consumed' route and second details page
* 2:00-2:30 -- Add community tasting notes to home page
* 2:30-3:00 -- Start researching Tailwind
* 3:00-3:45 -- Continue researching Tailwind
* 3:45-4:45 -- EOD: Update figma with new objectives and plan for next week

#### Friday, 03/03
* 8:00 -- Start of Day!
* 8:00-8:30 -- Review Figma and To-Do's for today
* 8:30-9:00 -- Add delete functionality to consumed page
* 9:00-10:00 -- Research potential Wine Api's for education section
* 10:00-10:30 -- Decided and started to build out own API 
* 10:30-11:00 -- Build out basic READ functionality for API
* 11:00-12:00 -- Connect Cellar application to Cellar Api
* 1:00-1:30 -- Start adding more data to API
* 1:30-2:30 -- Organize data on education page
* 2:30-3:00 -- WIP: Trying to install Tailwind
* 3:00-3:45 -- Project broke. Not sure what's wrong.
* 3:45-4:15 -- Fixed project. Tailwind not installed.
* 4:15-4:45 -- EOD: Re-visit figma and plan for next week

#### Tuesday, 03/07
* 8:00 -- Start of Day!
* 8:00-8:30 -- Review Figma and To-Do's for today
* 8:30-9:00 -- Research new styling options, might just do CSS
* 9:00-9:30 -- Can't find any styling options I like. Will come back to this
* 9:30-10:30 -- Research adding a search bar 
* 10:30-11:00 -- WIP: adding search bar to home controller
* 11:00-12:00 -- Add search by vintage functionality to home controller
* 1:00-1:45 -- Add full search functionality to home controller
* 1:45-2:30 -- Add full search funcionality to cellar
* 2:30-3:00 -- Update search funcionality to use .Contains
* 3:00-3:45 -- Research sorting and pagination
* 3:45-4:15 -- Continue researching sorting and pagination
* 4:15-4:30 -- EOD: Re-visit figma and plan for tomorrow

#### Wednesday, 03/08
* 8:00 -- Start of Day!
* 8:00-8:30 -- Review Figma and To-Do's for today
* 8:30-9:15 -- WIP: adding sorting to app
* 9:15-10:00 -- WIP: still adding sorting
* 10:00-11:00 -- WIP: trying to add sorting
* 11:00-11:30 -- Will come back to sorting. Can't get it to work
* 11:30-12:00 -- Research pagination
* 1:00-1:45 -- WIP: adding pagination
* 1:45-2:45 -- add pagination to home page
* 2:45-3:30 -- add pagination to cellar
* 3:30-3:45 -- Look at sorting again
* 3:45-4:15 -- Career Services meeting
* 4:15-4:45 -- EOD: Re-visit figma and plan for tomorrow

#### Thursday, 03/09
* 8:00 -- Start of Day!
* 8:00-9:00 - Work on README

***
## License

MIT License

Copyright (c) 2023 Henry Sullivan

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.