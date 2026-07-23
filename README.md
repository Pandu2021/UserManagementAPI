# UserManagementAPI

# User Management API

A simple **ASP.NET Core Web API** project built with the help of Microsoft Copilot.  
This project demonstrates back-end development skills including CRUD operations, debugging, validation, and middleware implementation (logging, error handling, authentication).

---

## 🚀 Features
- **CRUD Endpoints** for managing users:
  - `GET /api/user` → Retrieve all users
  - `GET /api/user/{id}` → Retrieve a user by ID
  - `POST /api/user` → Add a new user
  - `PUT /api/user/{id}` → Update an existing user
  - `DELETE /api/user/{id}` → Delete a user by ID
- **Validation** using FluentValidation (ensures valid name, email, and role).
- **Error Handling** with standardized JSON responses.
- **Logging Middleware** to record requests and responses.
- **JWT Authentication Middleware** to secure endpoints.

---

## 🛠️ Tech Stack
- **.NET 8.0** (ASP.NET Core Web API)
- **Entity Framework Core** (SQL Server provider)
- **FluentValidation** (input validation)
- **Swagger / Swashbuckle** (API documentation)
- **JWT Authentication** (secure endpoints)

---

## 📂 Project Structure
UserManagementAPI/
├── Controllers/       # API endpoints
├── Models/            # User entity
├── Data/              # DbContext
├── Validators/        # Input validation rules
├── Middleware/        # Logging, error handling, authentication
├── Program.cs         # Entry point
└── appsettings.json   # Configuration (DB, JWT)

