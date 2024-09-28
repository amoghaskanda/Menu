# Order Menu

This project is a .NET Web application written using C# and Blazor. It renders a page allowing users to order drinks.

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
│   │    └── Pages            # Page layouts
│   │         └── ...
│   └── ...
│  
├── Tests
│   ├── Tests.csproj
│   ├── HomeTests.Cs          # Unit tests
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
