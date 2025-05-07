# EmployeeCRUD Console App 🧑‍💼

A simple console-based CRUD application built using C# and MySQL to manage employee data. Created as part of a selection process for a company task.

## 🛠️ Tech Stack
- **Language:** C#
- **Database:** MySQL
- **ORM/Library:** MySql.Data
- **IDE:** Visual Studio / VS Code

## Prerequisites

Before running this project, make sure you have the following installed:

- **.NET SDK** - [Download .NET SDK](https://dotnet.microsoft.com/download/dotnet)
- **MySQL Server** - [Download MySQL](https://dev.mysql.com/downloads/installer/)
- **MySQL Workbench (optional)** - [Download MySQL Workbench](https://dev.mysql.com/downloads/workbench/)


## 📦 Features
- Add new employees
- View all employees
- Update employee details
- Delete employee by roll number
- View statistics like:
  - Total employees
  - Average salary
  - Top performer by salary


## ⚙️ Setup Instructions

1. **Clone this repo:**
   ```bash
   git clone https://github.com/Houshic19/EmployeeCRUD.git
   cd EmployeeCRUD


Set up MySQL database:

CREATE DATABASE EmployeeDB;

USE EmployeeDB;

CREATE TABLE Employees (
  RollNumber INT PRIMARY KEY,
  Name VARCHAR(100),
  Age INT,
  Marks INT,
  Salary DOUBLE
);


Update the connection string in EmployeeRepository.cs:

private readonly string _connectionString = "server=localhost;user=root;password=YOUR_PASSWORD;database=EmployeeDB;";


Open the solution in Visual Studio.

Press Ctrl + F5 or run via terminal:


This project was created and submitted as part of the hiring process. If you need any clarifications, feel free to reach out.

