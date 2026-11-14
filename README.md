# 📅 BookIt Lite – Appointment Booking System

## 📖 Project Overview

**BookIt Lite** is a web-based appointment scheduling application developed using **Blazor and the Microsoft .NET technology stack**.

**https://trello.com/invite/b/6af7a1383bcb317b35090ea5/ATTI11b3d594fe0b2ed7abe99719d082784705E0E7AC/cse-325**

The application is designed to help small businesses and independent service providers manage appointments efficiently while providing customers with a simple and convenient way to book services online.

Customers can browse available services, select appointment dates and times, manage their reservations, and cancel appointments when necessary. Service providers can manage their services, configure available appointment slots, and monitor upcoming bookings.

This project is being developed as part of the **BYU–Idaho CSE 325 .NET Software Development course**, demonstrating full-stack web development, database management, user authentication, CRUD operations, and collaborative software development.

---

## 🎯 Project Objectives

The primary goal of BookIt Lite is to design, develop, test, and deploy a functional appointment booking application using the .NET ecosystem.

The project aims to:

- Develop an interactive web application using **Blazor and C#**.
- Implement secure user authentication and role-based authorization.
- Provide CRUD (Create, Read, Update, Delete) functionality.
- Design and manage a relational database using Entity Framework Core.
- Allow customers to book and manage appointments.
- Prevent double bookings and scheduling conflicts.
- Create a responsive and accessible user interface.
- Follow software development best practices.
- Collaborate using GitHub and Trello.
- Test and deploy the application to a cloud hosting service.

---

## 👥 Target Audience

BookIt Lite is designed for:

**Customers**
- Individuals who want to schedule appointments online.
- Customers who prefer to check availability without contacting a provider.
- Users who need to review or cancel upcoming appointments.

**Service Providers**
- Independent tutors.
- Consultants.
- Personal trainers.
- Barbers and other small service businesses.

The initial version supports one service provider and multiple customers.

---

## ✨ Main Features

### 🔐 User Authentication
- Customer registration.
- Secure login and logout.
- Role-based access for customers and the service provider.
- Protected pages and user-specific information.

### 🛠️ Service Management
- Create new services.
- View available services.
- Update service information.
- Remove or deactivate services.
- Define service duration, description, and price.

### 📆 Availability Management
- Create available appointment time slots.
- View and update available slots.
- Remove unbooked time slots.
- Prevent overlapping schedules.

### ✅ Appointment Booking
- Browse available services.
- Select an available appointment time.
- Confirm a booking.
- Prevent multiple customers from booking the same time slot.

### 📋 Appointment Management
- View upcoming and previous appointments.
- Cancel existing appointments.
- Allow the service provider to review scheduled appointments.
- Mark appointments as completed.

### 📱 Responsive Design
- Mobile-friendly user interface.
- Consistent navigation and visual design.
- Accessible forms and interactive components.
- Support for desktop, tablet, and mobile browsers.

---

## 🧰 Technology Stack

| Technology | Purpose |
|---|---|
| C# | Application programming language |
| .NET / ASP.NET Core | Backend framework |
| Blazor | Interactive web user interface |
| Entity Framework Core | Object-relational mapping and data access |
| PostgreSQL | Relational database |
| ASP.NET Core Identity | Authentication and authorization |
| Bootstrap / CSS | Responsive interface design |
| xUnit | Unit testing |
| bUnit | Blazor component testing |
| Git & GitHub | Version control and collaboration |
| Trello | Project and task management |
| Azure | Cloud application deployment |

---

## 🏗️ Application Architecture

BookIt Lite follows a layered application architecture to organize responsibilities and support maintainability.

**Presentation Layer**
- Blazor pages and reusable components.
- Forms, navigation, and appointment interfaces.

**Business Logic Layer**
- Service management.
- Appointment booking and cancellation.
- Availability validation.
- User authorization checks.

**Data Access Layer**
- Entity Framework Core.
- Database models and migrations.
- Database queries and updates.

**Database Layer**
- PostgreSQL database.
- Users, services, availability slots, and appointment records.

### Database Entities

The main application entities are:

| Entity | Description |
|---|---|
| ApplicationUser | Stores application user information using ASP.NET Core Identity |
| Service | Stores services offered by the provider |
| AvailabilitySlot | Stores available appointment dates and time slots |
| Appointment | Stores customer reservations and appointment statuses |

---

## 👨‍💻 Development Team

This project is developed collaboratively by a team of four students.

| Team Member | Primary Responsibility |
|---|---|
| Carlos De Avila | Project setup, authentication, authorization, and navigation |
| Denton Coy Flake | Database design, Entity Framework Core, and service management |
| Quelitho Gabriel | Availability management and appointment booking |
| Rocio Maryorie Apaza | Appointment management UI, testing, and cloud deployment |

---

## 🗓️ Development Timeline

The project follows a seven-week development schedule.

| Week | Development Activities |
|---|---|
| 1 | Project planning, GitHub setup, Trello board, wireframes, and initial Blazor application |
| 2 | Authentication, user roles, database configuration, and Entity Framework Core |
| 3 | Service CRUD functionality and availability management |
| 4 | Appointment booking and double-booking prevention |
| 5 | Customer and provider appointment management |
| 6 | Testing, accessibility improvements, responsive design, and cloud deployment |
| 7 | Final testing, documentation, bug fixes, and project presentation |

---

## 🧪 Testing and Quality Assurance

BookIt Lite will be tested to ensure reliability, usability, and security.

Testing activities include:

- Unit testing of business logic using xUnit.
- Blazor component testing using bUnit.
- Authentication and authorization testing.
- CRUD functionality testing.
- Appointment booking and cancellation testing.
- Double-booking prevention testing.
- Responsive design testing.
- Accessibility testing using Lighthouse and axe DevTools.
- Validation and error-handling testing.

The application will be developed with the goal of meeting **WCAG 2.2 Level AA accessibility standards**.

---

## 🚀 Deployment

The application is planned to be deployed to a cloud hosting platform such as **Microsoft Azure**.

Once deployed, users will be able to access BookIt Lite through a public web address.

**Live Application:** To be added after deployment.

---

## 💻 Local Development

### Prerequisites

To develop or run the application locally, the following tools are expected to be required:

- .NET SDK compatible with the project.
- Visual Studio or Visual Studio Code with C# tooling.
- PostgreSQL.
- Git.
- Entity Framework Core CLI tools.

### Getting Started

1. Clone the GitHub repository.

   ```bash
   git clone https://github.com/caarloosdab/BookIt.Net_project.git
   ```

2. Navigate to the project directory.

   ```bash
   cd BookIt-Lite
   ```

3. Restore the required .NET dependencies.

   ```bash
   dotnet restore
   ```

4. Configure the PostgreSQL database connection using local user secrets or environment variables.

5. Apply Entity Framework Core migrations after the database configuration and project structure are finalized.

6. Run the Blazor application.

   ```bash
   dotnet run --project src/BookIt.Web
   ```

7. Open the localhost URL displayed in the terminal.

**Note:** These instructions represent the planned project structure. They will be updated as development progresses.

---

## 🤝 Collaboration and Version Control

The development team uses **GitHub** for source control and **Trello** for task organization.

The team will follow a feature-branch workflow:

- `main` – Stable application code.
- `feature/authentication` – Authentication functionality.
- `feature/service-management` – Service CRUD.
- `feature/appointment-booking` – Booking and availability logic.
- `feature/appointment-management` – Customer and provider appointment pages.

Changes should be submitted through pull requests and reviewed before merging into the main branch.

### Development Guidelines

- Write readable, maintainable C# code.
- Use meaningful variable and method names.
- Add comments when explaining non-obvious logic.
- Follow consistent formatting conventions.
- Test features before submitting pull requests.
- Keep commits focused and descriptive.
- Never commit passwords, secrets, or database credentials.

---

## 📌 Project Status

**Status:** Planning / Early Development

**Current Goal:** Establish the project structure, database design, authentication system, and initial Blazor components.

The README will be updated throughout development as features are implemented and deployment information becomes available.

---

## 🔮 Potential Future Enhancements

The following features are outside the initial project scope but may be considered for future development:

- Email appointment notifications.
- Appointment rescheduling.
- Interactive calendar views.
- Multiple service providers.
- Recurring weekly schedules.
- Appointment reminders.
- Customer ratings and reviews.
- Reporting and analytics.
