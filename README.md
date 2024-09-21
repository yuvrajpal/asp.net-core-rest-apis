# Basic CRUD API

A simple RESTful API built with ASP.NET Core that performs basic CRUD operations using Entity Framework Core and SQLite as the database.

## Table of Contents

- [Description](#description)
- [Technologies Used](#technologies-used)
- [Setup Instructions](#setup-instructions)
- [API Endpoints](#api-endpoints)
- [License](#license)

## Description

This project demonstrates a basic CRUD (Create, Read, Update, Delete) API for managing users. The API supports operations like fetching all users, fetching a single user by ID, creating a new user, updating an existing user, and deleting a user.

## Technologies Used

- **ASP.NET Core 8.0** (latest SDK)
- **Entity Framework Core**
- **SQLite** for local data storage
- **Swagger** for API documentation

## Setup Instructions

### Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download)
- SQLite installed (if running locally)
- [Postman](https://www.postman.com/) or curl for testing API endpoints

### How to Set Up the Project

1. **Clone the repository**:

   ```bash
   git clone <repository-url>
   ```

2. **Navigate to the project directory**:

   ```bash
   cd BasicCrudApi
   ```

3. **Install dependencies**:

   ```bash
   dotnet restore
   ```

4. **Run the database migrations**:

   ```bash
   dotnet ef database update
   ```

5. **Run the application**:

   ```bash
   dotnet run
   ```

6. **Access Swagger for API documentation**:
   - Open your browser and navigate to `https://localhost:<port>/swagger`.

## API Endpoints

### GET /api/user

- **Description**: Fetch all users.
- **Response**: List of users.

### GET /api/user/{id}

- **Description**: Fetch a user by ID.
- **Response**: Single user object.

### POST /api/user

- **Description**: Create a new user.
- **Request Body**: User object in JSON format.

  ```json
  {
    "name": "John Doe",
    "email": "johndoe@example.com"
  }
  ```

### PUT /api/user/{id}

- **Description**: Update an existing user by ID.
- **Request Body**: User object in JSON format.

  ```json
  {
    "id": 1,
    "name": "John Doe Updated",
    "email": "updatedemail@example.com"
  }
  ```

### DELETE /api/user/{id}

- **Description**: Delete a user by ID.

---

## Steps Taken to Create the Project

1. **Create the Project**:

   - Run the following command to create a new ASP.NET Core Web API project:
     ```bash
     dotnet new webapi -n BasicCrudApi
     ```

2. **Add SQLite and Entity Framework Core**:

   - Install necessary NuGet packages:
     ```bash
     dotnet add package Microsoft.EntityFrameworkCore.Sqlite
     dotnet add package Microsoft.EntityFrameworkCore.Tools
     ```

3. **Configure Database Context**:

   - Create `AppDbContext` class and configure it to use SQLite.

4. **Create the User Model**:

   - Define a `User` class with properties such as `Id`, `Name`, and `Email`.

5. **Create UserController**:

   - Implement API routes for CRUD operations (`GET`, `POST`, `PUT`, and `DELETE`) in the `UserController`.

6. **Set Up Database Migrations**:

   - Create and apply migrations to set up the SQLite database:
     ```bash
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```

7. **Test the API**:

   - Use Postman or curl to test the various endpoints (GET, POST, PUT, DELETE).

8. **Set Up Swagger**:

   - Enable Swagger in `Program.cs` for API documentation and testing.

9. **Run the Application**:

   - Run the project using:
     ```bash
     dotnet run
     ```

10. **Git Ignore Configuration**:
    - Add a `.gitignore` file to exclude `bin/`, `obj/`, and SQLite database files.
