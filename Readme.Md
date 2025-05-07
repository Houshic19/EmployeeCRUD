# EmployeeCRUD Console App 

A simple console-based CRUD application built using C# and MySQL to manage employee data. Created as part of a selection process for a company task.

## 🛠️ Tech Stack
- **Language:** C#
- **Database:** MySQL
- **ORM/Library:** MySql.Data
- **IDE:** Visual Studio 2022

## Prerequisites

Before running this project, make sure you have the following installed:

- **.NET SDK** - [Download .NET SDK](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks)
- **MySQL Server** - [Download MySQL](https://dev.mysql.com/downloads/installer/)
- **MySQL Workbench (optional)** - [Download MySQL Workbench](https://dev.mysql.com/downloads/workbench/)
- **Visual Studio 2022** - [Download Visual Studio 2022](https://visualstudio.microsoft.com/vs/community//)


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


## 🧠 Database Setup

To set up the MySQL database:

1. Open MySQL Workbench or your preferred MySQL client.
2. Run the script provided in [`schema.sql`](./schema.sql) to create the `EmployeeDB` database and the `Employees` table.

Alternatively, if you want to manually create the table, here’s the SQL:

```sql

CREATE DATABASE EmployeeDB;
USE EmployeeDB;
CREATE TABLE Employees (
    RollNumber INT PRIMARY KEY,
    Name VARCHAR(50) not null,
    Age INT not null,
    Mark double not null,
    Salary double not null
    
);

Update the connection string in EmployeeRepository.cs:

private readonly string _connectionString = "server=localhost;user=root;password=YOUR_PASSWORD;database=EmployeeDB;";


Open the solution in Visual Studio.

Press Ctrl + F5 or run via terminal:


This project was created and submitted as part of the hiring process. If you need any clarifications, feel free to reach out.

