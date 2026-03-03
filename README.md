# Task Management Application

## 1. Overview

This project is a Task Management Application built using ASP.NET Core MVC and Entity Framework Core.

The application allows users to:

- Create new tasks
- Read existing tasks
- Update tasks
- Delete tasks
- Search tasks

The system is designed using MVC architecture and follows a Code First database approach.

---

## 2. Database Design

### 2.1 Entity Relationship (ER) Diagram

Since the current version of the application manages only one entity, no foreign key relationships exist in this implementation.

+-------------------+
| Task |
+-------------------+
| Id (PK) |
| TaskTitle |
| TaskDescription |
| TaskDueDate |
| TaskStatus |
| TaskRemarks |
| CreatedOn |
| LastUpdatedOn |
| CreatedBy |
| LastUpdatedBy |
+-------------------+

Primary Key:- Id
------------------

### 2.2 Data Dictionary

| Field Name      | Data Type   | Required | Description |
|---------------|------------|----------|-------------|
| Id | int | Yes | Primary Key (Auto Increment) |
| TaskTitle | string | Yes | Title of the task |
| TaskDescription | string | No | Detailed task description |
| TaskDueDate | DateTime | Yes | Task due date |
| TaskStatus | string | Yes | Status of task (Pending / Completed) |
| TaskRemarks | string | No | Additional remarks |
| CreatedOn | DateTime | Yes | Timestamp when task was created |
| LastUpdatedOn | DateTime | No | Timestamp when task was last updated |
| CreatedBy | string | No | Name/Id of user who created task |
| LastUpdatedBy | string | No | Name/Id of user who updated task |

---
Currently, CreatedBy and LastUpdatedBy are implemented as string fields. In future enhancement, this can be normalized into a separate User entity with proper foreign key relationships.

### 2.3 Indexes Used

- Primary Key index on `Id`
- Additional indexes can be added on `TaskTitle` and `TaskStatus` for faster search optimization (future enhancement)

---

### 2.4 Code First or DB First?

This project uses **Code First Approach** with Entity Framework Core.

Reason:
- Better control over domain models
- Easy migration management
- Faster development cycle
- Clean separation between model and database schema

---

## 3. Application Structure

The application follows the **MVC (Model-View-Controller)** pattern.

- Models → Define Task entity
- Controllers → Handle business logic
- Views → Razor-based server-side rendering
- Data → DbContext and database configuration

This project uses **Standard MVC Server-Side Rendering (MPA)** approach.

No SPA framework has been used.

---

## 4. Frontend Structure

Frontend is built using:

- Razor Views
- Bootstrap 5
- HTML5
- CSS

Reason for choosing this structure:
- Lightweight
- Clean UI
- Faster development
- Fully integrated with ASP.NET MVC

---

## 5. Features Implemented

- Create Task
- View Task List
- Edit Task
- Delete Task (with confirmation)
- Search Task by Title or Status
- Display task status with badges
- Track Created and Updated timestamps

---

## 6. Build and Install Instructions

### 6.1 Environment Details

- .NET 8
- Visual Studio 2022
- SQL Server Express
- Entity Framework Core

### 6.2 Dependencies

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

---

### 6.3 Steps to Run the Project

1. Clone the repository:
git clone https://github.com/tashugupta-dev/TaskManagementApp.git

2. Open project in Visual Studio

3. Update the connection string in:
appsettings.json

4. Run Migration:
Add-Migration InitialCreate
Update-Database

5. Run the project

----------------------------------------------

## 7. Future Enhancements

- User Authentication & Authorization
- Role-based access
- Pagination
- Dashboard statistics
- API version of application
- Advanced search filters

---

## 8. Conclusion

This project demonstrates:

- MVC pattern implementation
- CRUD operations
- Search functionality
- Entity Framework Code First approach
- Proper database structure design
- Clean UI implementation
- Documentation standards

---

## Author

Tanu Gupta  
B.Tech CSE  
.NET Developer
