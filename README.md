# 🚗 CarBook | ASP.NET Core 8.0 + Onion Architecture

### Full-Stack Car Rental System | Onion Architecture | Enterprise-Grade Backend

---

##📌 About the Project

CarBook is **a full-featured Car Rental System Web Application built with ASP.NET Core 8.0.**
This project stands as a significant milestone in my backend development journey — developed through an intensive 39-hour, 314-lesson Udemy course led by [Murat Yücedağ](https://www.udemy.com/course/aspnet-core-api-8-onion-architecture-ile-bookcar-projesi/) , where I actively coded, debugged, and expanded upon the tutorial to simulate a real-world vehicle rental platform inspired by companies like **Avis Budget Group and Enterprise.**

The application allows users to **filter cars based on location and various criteria**, make reservations, and enables administrators to **manage all rental operations through an Admin Dashboard.**

My focus was not merely to build a project but to understand **enterprise-level software architecture, security, and API-driven development.**

---

## 🛠️ Screenshots

---

## 🚀 What This Project Taught Me

- Applying **Onion Architecture** and building scalable enterprise applications
- Designing **multi-layered backend systems**
- Using **CQRS, Mediator, and Repository** design patterns in production
- Implementing **JWT-based authentication and authorization**
- Working with **Entity Framework Core** (Code First & Migrations)
- Conducting API tests using **Swagger and Postman**
- Applying **Fluent Validation** for advanced data integrity
- Integrating **SignalR** for real-time communication
- Building Dashboard and reporting systems using **SQL Pivot Tables**
- Utilizing **ADO.NET** within ASP.NET Core for low-level database operations

---

## 🛠️ Technologies Used

| Category                    | Technologies                          |
| ---------------------------- | ------------------------------------- |
| **Framework**                | ASP.NET Core 8.0                      |
| **Architecture**             | Onion Architecture (6-layer solution) |
| **Database**                 | Microsoft SQL Server                  |
| **ORM**                      | Entity Framework Core                 |
| **Design Patterns**          | CQRS, Mediator, Repository            |
| **Security**                 | JWT (JSON Web Token)                  |
| **Validation**               | FluentValidation                      |
| **Real-Time Communication**  | SignalR                               |
| **API Testing**              | Swagger & Postman                     |
| **Data Reporting**           | SQL Pivot Tables                      |
| **Utilities**                | ADO.NET, Dashboard modules            |

---

## 🧱 Project Architecture – UdemyCarBook

This project is structured based on the principles of **Clean Architecture** and **Onion Architecture**, ensuring a clear separation of concerns and maintainable code structure.  
Each layer has a specific responsibility, and dependencies always flow **inward** — from outer layers (UI, Infrastructure) toward the **Core** (Domain & Application).

---

### 📂 Solution Overview

| Layer / Folder | Description |
|----------------|-------------|
| **Core** | Contains the application's core logic and domain model layers. |
| ├── **Application/** | Business logic, CQRS handlers, interfaces, and DTOs. |
| │ ├── Interfaces/ | Abstractions for services and repositories. |
| │ ├── Services/ | Core services, Mediator handlers, and CQRS implementations. |
| │ ├── DTOs/ | Data Transfer Objects for communication. |
| │ └── Features/ | Command & Query definitions (CQRS pattern). |
| ├── **Domain/** | Core domain models, rules, and value objects. |
| │ ├── Entities/ | Domain entities such as Car, Reservation, Customer, etc. |
| │ ├── Enums/ | Enumerations for status, category, and constants. |
| │ ├── ValueObjects/ | Strongly-typed immutable data structures. |
| │ └── Base/ | Shared domain base entities. |
| └── Core.csproj | Core project file. |
| **Infrastructure** | Provides persistence and dependency injection configurations. |
| └── **UdemyCarBook.Persistence/** | EF Core setup and database context. |
| &nbsp;&nbsp;&nbsp;&nbsp;├── Context/ | Database context and configuration classes. |
| &nbsp;&nbsp;&nbsp;&nbsp;├── Repositories/ | Generic and custom repositories. |
| &nbsp;&nbsp;&nbsp;&nbsp;├── EntityConfigurations/ | Fluent API entity configuration. |
| &nbsp;&nbsp;&nbsp;&nbsp;├── DependencyInjection/ | Service registration for DI container. |
| &nbsp;&nbsp;&nbsp;&nbsp;└── UdemyCarBook.Persistence.csproj | Project file for persistence layer. |
| **Presentation** | API presentation and controller endpoints. |
| └── **UdemyCarBook.WebApi/** | Main RESTful API project. |
| &nbsp;&nbsp;&nbsp;&nbsp;├── Controllers/ | Cars, Reservations, and Testimonials controllers. |
| &nbsp;&nbsp;&nbsp;&nbsp;├── DTOs/ | API-specific DTOs. |
| &nbsp;&nbsp;&nbsp;&nbsp;├── Extensions/ | Swagger configuration and extensions. |
| &nbsp;&nbsp;&nbsp;&nbsp;└── appsettings.json / Program.cs | API configuration files. |
| **Frontends** | MVC / Razor frontends for users and admin. |
| ├── **UdemyCarBook.WebUI/** | Client-side application (MVC views, static files). |
| └── **UdemyCarBook.AdminUI/** | Admin dashboard for backend management. |
| **UdemyCarBook.sln** | Root solution file linking all projects. |
---

### 🧩 Layer Responsibilities

| **Layer** | **Folder** | **Responsibility / Description** |
|------------|-------------|----------------------------------|
| **Core** | `Core/` | The heart of the application. Contains the **Domain** (Entities, Enums, Value Objects) and **Application** (Business logic, DTOs, Interfaces). It is completely independent of external technologies. |
| **Infrastructure** | `Infrastructure/UdemyCarBook.Persistence/` | Implements data access logic using **Entity Framework Core**. Contains the **DbContext**, repository implementations, and **dependency injection configurations** for persistence. |
| **Presentation** | `Presentation/UdemyCarBook.WebApi/` | Exposes RESTful endpoints for API consumers. Handles HTTP requests and responses. Includes **Swagger**, **CORS**, **middleware configuration**, and **controller-based API logic**. |
| **Frontends** | `Frontends/` | Contains the **WebUI** (customer-facing site) and **AdminUI** (management panel). Uses **ASP.NET Core MVC/Razor** for presentation and consumes WebAPI endpoints. |
| **Dependency Flow** | → | **Frontends → WebApi → Persistence → Core** (no circular dependencies). |

---

### 🛠️ Technologies Used per Layer

| **Layer** | **Main Technologies & Tools** |
|------------|-------------------------------|
| **Core** | C#, .NET 8, Domain-Driven Design (DDD), DTOs, Interfaces |
| **Infrastructure (Persistence)** | Entity Framework Core, SQL Server, Repository Pattern, LINQ |
| **Presentation (WebApi)** | ASP.NET Core Web API, Swagger UI, Dependency Injection, RESTful Services |
| **Frontends (WebUI/AdminUI)** | ASP.NET Core MVC, Razor Pages, Bootstrap, HTML/CSS/JS |

---

### 🔄 Data Flow Summary

1. **Client/UI (Frontends)** sends a request to **WebApi**.  
2. **WebApi** controller calls **Application services** in the **Core** layer.  
3. **Application layer** interacts with the **Persistence layer** (Infrastructure) through **interfaces** defined in the Core.  
4. **Persistence** executes database operations via **EF Core** and returns results upward.  
5. **WebApi** returns a structured response (DTO) back to the client/UI.  

This architecture enforces **loose coupling**, **high testability**, and **separation of concerns**, ensuring that UI or database changes don’t break the business logic.

---

### ✅ Key Benefits

- 🔹 Modular, testable, and maintainable codebase  
- 🔹 Clear separation between layers  
- 🔹 Scalable architecture — suitable for adding microservices later  
- 🔹 Centralized dependency injection and configuration management  
- 🔹 Easy to replace or extend persistence (e.g., swap SQL Server with PostgreSQL)

---

### 🔐 Security & Authorization

- The project employs JWT-based authentication to manage secure access between API and UI.
- Role-based authorization ensures that only permitted users (Admin/User) can perform specific actions.

---

### 📊 Real-Time Features

- SignalR is integrated to simulate real-time notifications, dashboard updates, and data synchronization.
The system architecture supports:
  - Live status updates
  - Admin-side monitoring
  - Real-time analytics

---

### ⚙️ API Development & Testing

- All APIs were built using REST principles, tested through:
  - Swagger UI (for in-browser endpoint verification)
  - Postman (for advanced test automation scenarios)

---

### 🧱 Design Patterns in Use

- The system combines multiple enterprise patterns to improve flexibility and maintainability:
  - CQRS (Command–Query Responsibility Segregation)
  - Mediator (via MediatR library)
  - Repository Pattern (generic data access layer)
 
---

### 🧭 Next Steps (Optional Enhancements)

If you want to make the architecture even more robust:
- Add a dedicated **Application** project under `Core/` (separate from Domain).  
- Introduce **CQRS pattern** (with MediatR).  
- Add **FluentValidation** for DTOs.  
- Integrate **AutoMapper** between layers.  
- Add **Unit Tests** for `Core.Application` and `Infrastructure` layers.

---

## 🌿 Summary

The UdemyCarBook solution is designed following a **clean and maintainable architecture**, aligning with enterprise-grade ASP.NET Core best practices.  
It cleanly separates **Domain, Application, Infrastructure, Presentation,** and **Frontend** concerns while maintaining scalability and flexibility for future features.

---

## 🧪 Course Details

- 🎓 Course: [ASP.NET Core 8 + Onion Architecture with BookCar Project by Murat Yücedağ](https://www.udemy.com/course/aspnet-core-api-8-onion-architecture-ile-bookcar-projesi/)
- 📚 Lessons: 314
- 🕒 Duration: 39 hours
- 💻 Platform: Udemy

---

## ⭐️ For Recruiters

If you're searching for a backend developer who is:

- 🧰 Inquisitive and driven
- 👩‍💻 Dedicated to writing clean, scalable code
- 🌐 Skilled in API design and integration
- 🛠️ Familiar with enterprise practices and real-world scenarios
- 🧠 Analytical and architecture-minded
- ⚙️ Passionate about enterprise-level backend development
- 💬 Skilled in .NET, SQL, and API-driven systems
- 🚀 Committed to writing clean, maintainable code

Let’s connect and build something great together! 💼

Feel free to connect.  
**Let’s build something great together!** 🚀

- 📧 **Contact**: [LinkedIn – Merve Kıratlı](https://www.linkedin.com/in/merve-kiratli-0b049a187)

