# [MASTERCLASS - ASP.NET Razor na prática](https://www.youtube.com/watch?v=UNMfTGiAR2c)

* Razor Pages is a server-side web development framework introduced as part of ASP.Net Core. It provides a simplified approach for building dynamic, data-driven web pages with a clean separation of concerns.

* A framework is a structure foundation upon which developers can build applications. It provides a set of tools, libraries, and best practices that allow developers to speed up the developement process by reusing commom functionalities and solving recurring problems.

* C# is the language used to build applications using Razor Pages framework
  
## [Basic structure and file of a Razor solution](https://youtu.be/UNMfTGiAR2c?t=894)

### The program.cs file

When the Razor application runs, the first thing executed is the program.cs file (entry point). This program is responsible for configuring **web host** and **services** and **initializing the application**. In the file *Program.cs* we can see the following lines of code:

```
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Support to create URL customized and to finding a simple page
app.UseRouting();
app.MapRazorPages();

app.UseAuthorization();

app.Run();
```

1. **var builder = WebApplication.CreateBuilder(args);**

    1. *WebApplication.CreateBuilder(args);*: This method creates a *builder* instance for configuring and building the application.
    2. The *args* parameter typically contains commad-line arguments passed to the application.

2. **var app:WebApplication = builder.Build();**
   
    1. *builder*: variable created in the previous item. The builder contains information about services, configuration, logging, and other aspects of the app.
   
    2. *Build()*: creates an instance of the *WebApplication*. It finalizes the configuration an sets up the application to handle incoming requests
   
    3. *var app:WebApplication*: Is a WebApplication instance assigned in the app variable that represents the ASP.NET Core web application.
   
3. *builder.Services.AddRazorPages();*

Adds services for Razor Pages to the app.
   
In the code below we can see an example of the content of the program.cs file

### The .csproj file

The *.csproj* file serves as the project file that defines the project structure, dependencies, build settings, and other essential details. We can see the content of a .csproj file in the code below

```
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net7.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <Folder Include="wwwroot\imgs\" />
  </ItemGroup>

</Project>
```

## Overview

* "~/" root of application
* Dynamic pages in the Page folder create the actual files in the wwwroot folder.
* Partial View are snippets of code that repeat. They are placed in the Shared folder.
* To add Partial Views on Razor page you need to use Tag Helpers as showed in the code below
  
  ```
  @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

  ...

  <partial name="Shared/NavMenuPartial" />
  ```



* AAAA
