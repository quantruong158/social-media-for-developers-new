# ASP .NET CORE WEB API

The Backend of the Social Media for Developers Website using ASP. NET Core Web API, Entity Framework Core with PostgreSQL, and Identity.

## Project Structure

The app uses the 3-tier architecture, inspired by [aghayeffemin's repository](https://github.com/aghayeffemin/aspnetcore.ntier)

### API

This is the startup project of the backend. It includes the entry file: `Program.cs` and the Controllers inside `Controllers` folder

### BLL

This represents the Business Logic Layer, where the `Services` are placed. This project also includes the mapping between `DTOs` and `Entities`

### DAL

The Data Access Layer defines the `Entities`, `Database Context`, `Database Migrations`, and the `Repositories` to access the database. 

### DTO

This contains the `Data Transfer Objects` between the Client and this Server.