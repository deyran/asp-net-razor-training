# [MASTERCLASS - ASP.NET Razor na prática](https://www.youtube.com/watch?v=UNMfTGiAR2c)

* A framework is a structure foundation upon which developers can build applications. It provides a set of tools, libraries, and best practices that allow developers to speed up the developement process by reusing commom functionalities and solving recurring problems.

* Razor Pages is a server-side web development framework introduced as part of ASP.Net Core. It provides a simplified approach for building dynamic, data-driven web pages with a clean separation of concerns.

* C# is the language used to build applications using Razor Pages framework
  
## [Basic structure of a Razor solution](https://youtu.be/UNMfTGiAR2c?t=894)

### The program.cs file

The *program.cs* file is a critical part of the applications' startup process.

* In the file *Program.cs* we can see the following lines of code

1. *var builder = WebApplication.CreateBuilder(args);*

    1. *WebApplication.CreateBuilder(args);*: This method creates a *builder* instance for configuring and building the application.
    2. The *args* parameter typically contains commad-line arguments passed to the application.

2. *var app:WebApplication = builder.Build();*
   
    1. *builder*: variable created in the previous item. The builder contains information about services, configuration, logging, and other aspects of the app.
   
    2. *Build()*: creates an instance of the *WebApplication*. It finalizes the configuration an sets up the application to handle incoming requests
   
    3. *var app:WebApplication*: Is a WebApplication instance assigned in the app variable that represents the ASP.NET Core web application.

### The .csproj file extension

* Talking about the *.csproj* file extension.
    1. Each Visual Studio project has its own *.csproj* file.
    2. The *.csproj* is a component that managing the project's configuration, dependencies and build process