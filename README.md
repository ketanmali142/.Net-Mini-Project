# Employee Management API (.NET Core)

## Overview

This is a simple .NET Core Web API project that allows basic **CRUD operations** (Create, Read, Update, Delete) for managing employees using SQL Server, Entity Framework Core, and Swagger UI.

---

## Required NuGet Packages

Run these commands in **NuGet Package Manager Console** or install via NuGet GUI:

```bash
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Swashbuckle.AspNetCore
```

---

## Default Swagger Port

Once the project runs, open in browser:

```
https://localhost:50472/swagger
```

You can also find the port number in `launchSettings.json` under `applicationUrl`.

---

## API Testing (Postman or Swagger)

* Use Swagger UI: `https://localhost:50472/swagger`
* Or test using Postman with these endpoints:

| Method | Endpoint            | Description         |
| ------ | ------------------- | ------------------- |
| GET    | /api/employees      | Get all employees   |
| GET    | /api/employees/{id} | Get employee by ID  |
| POST   | /api/employees      | Create new employee |
| PUT    | /api/employees/{id} | Update existing     |
| DELETE | /api/employees/{id} | Delete by ID        |

---

##  Database Creation in SQL Server (SSMS)

1. Open SQL Server Management Studio
2. Create a new DB manually (e.g. `EmployeeDB`)
3. Or let EF Core create it automatically via migration

---

##  Connection String (`appsettings.json`)

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

Replace `YOUR_SERVER_NAME` with your local SQL instance.

---

##  Migration Commands (NuGet Console)

```bash
Add-Migration InitialCreate
Update-Database
```

This creates the database and tables automatically using your model classes.

## Run the Project

```
Press F5 or click Run

Swagger will open at:
https://localhost:50472/swagger
```


