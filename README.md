﻿# Order Menu

This project is a .NET Web application written using C# and Blazor. It renders a page allowing users to order drinks.

![Preview](./Menu/Static/preview.png)

# Prerequisites

The project is written in C# and targets .NET 8. It requires the [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download). 
## Project structure
```console
.
├── ...
├── README.md
├── Menu                    
│   ├── Menu.csproj
│   ├── Components
│   │    ├── Layout
│   │    ├── Models
│   │    └── ...
│   └── ...
│  
├── Tests
│   ├── Tests.csproj
│   ├── HomeTests.Cs
│   └── ...
└── ...
```
## Run Tests
```console
dotnet test
```

## Build and Run Solution

- Terminal:
```console
dotnet build
dotnet run
```
- Visual Studio
    - Open ```Menu.sln``` in Visual Studio
    - Testing: Test > Rull All Tests
    - Run: Debug > Start Debugging
## Run
The application opens automatically. [Click here](http://localhost:3000) if the application does not open.
```
Sample discount codes: 
[1] abc10: 10%
[2] xyz20: 20%
```