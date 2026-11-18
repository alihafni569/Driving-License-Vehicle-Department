# DVLD – Driving & Vehicle License Department Management System

DVLD is a desktop application designed to manage driving license services and administrative operations within a Driving & Vehicle License Department. The system streamlines the process of managing applicants, processing license applications, conducting tests, and issuing driving licenses.

The project was developed using **C#, Windows Forms, SQL Server, and ADO.NET**, following a **3-Tier Architecture** to ensure clean separation of concerns, maintainability, and scalability.

## 🚀 Features

### 👤 Applicant Management
- Add, update, and manage applicant information.
- Search for applicants and retrieve their details.
- Maintain applicant records in the database.

### 🚗 License Management
- Manage different driving license classes.
- Issue new driving licenses.
- View and manage existing licenses.
- Handle license-related operations.

### 📝 Application Management
- Create and manage driving license applications.
- Track application status.
- Manage different types of license applications.

### 🧪 Test Management
- Schedule and manage driving tests.
- Record test results.
- Track applicants' progress through required tests.

## 🛠️ Technologies Used

- **C#** – Main programming language.
- **Windows Forms (WinForms)** – Desktop user interface.
- **.NET Framework** – Application development platform.
- **SQL Server** – Relational database management.
- **ADO.NET** – Database connectivity and data access.
- **3-Tier Architecture** – Separation of application responsibilities.

## 🏗️ Project Architecture

The application follows a 3-Tier Architecture:

1. **Presentation Layer (PL)**
   - Windows Forms user interface.
   - Handles user interactions and displays information.

2. **Business Logic Layer (BLL)**
   - Contains business rules and application logic.
   - Validates data and coordinates operations between layers.

3. **Data Access Layer (DAL)**
   - Handles database operations using ADO.NET.
   - Executes SQL queries and stored procedures.
   - Communicates with SQL Server.

## 🗄️ Database

The application uses Microsoft SQL Server to store and manage system data, including:

- Applicants and individuals.
- Users and permissions.
- License applications.
- Driving licenses.
- Test appointments and results.
- License classes and application types.

## ⚙️ Getting Started

### Prerequisites

Make sure you have installed:

- Visual Studio.
- .NET Framework (the version targeted by the project).
- Microsoft SQL Server.
- SQL Server Management Studio (SSMS).

### Installation

1. Clone the repository:

   ```bash
   git clone YOUR_REPOSITORY_URL
   ```

2. Open the solution file (`.sln`) in Visual Studio.

3. Configure the SQL Server connection string according to your local database configuration.

4. Create or restore the project database using the provided database scripts or backup, if available.

5. Build and run the application.

## 🎯 Project Goals

This project was developed to strengthen practical experience in:

- Object-Oriented Programming (OOP).
- Database design and management.
- SQL Server and T-SQL.
- ADO.NET and database connectivity.
- 3-Tier Architecture.
- Building real-world desktop applications.
- Applying business logic and data validation.

## 👨‍💻 Developer

**Ali Mohamed**

- GitHub: [Ali Mohamed](https://github.com/alihafni569)

---

⭐ If you find this project interesting, feel free to explore the repository and give it a star!
