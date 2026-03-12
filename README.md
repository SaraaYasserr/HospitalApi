
🏥 Hospital Management System (HMS)
A modern, full-stack Hospital Management System built to streamline medical workflows, patient records, and doctor-patient interactions. This project demonstrates a robust integration between a .NET 8 Web API and an Angular frontend.

🚀 Key Features
Doctor Dashboard: Comprehensive view of patient lists, appointments, and medical status.

Patient Management: Full CRUD operations for managing patient data (Names, Fees, Urgency, etc.).

Pharmacy/Medicine Module: API-driven inventory management for medicines.

Admin Dashboard: High-level overview and system-wide management.

Real-time Data Fetching: Seamless communication between the backend API and Angular frontend.

🛠️ Tech Stack
Backend: ASP.NET Core Web API (.NET 8)

Frontend: Angular (v16+)

Database: SQL Server (Entity Framework Core)

Testing & Documentation: Swagger UI & Postman

Security: DTOs (Data Transfer Objects) for secure data flow.

📸 Project Snapshots
1. API Documentation (Swagger)
The project uses Swagger for easy testing and clear API documentation.

[Insert your screenshot (1175) here - it shows the 200 OK response]

2. Database Design
Integrated with SQL Server using EF Core Migrations for reliable data persistence.

[Insert a screenshot of your SQL Tables or SQL Explorer]

⚙️ Backend Setup
Clone the repo:

Bash
git clone https://github.com/YourUsername/HospitalAPI.git
Update Connection String: Update appsettings.json with your local SQL Server instance.

Run Migrations:

Bash
Update-Database
Run the Project: Press F5 in Visual Studio or use dotnet run.

💻 Frontend Setup
Navigate to the client folder.

Install dependencies: npm install.

Start the server: ng serve.

Open http://localhost:4200 in your browser.

💡 Lessons Learned
During development, I focused on:

Implementing Data Validation to ensure data integrity.

Debugging complex Entity Framework migration issues.

Optimizing API responses using Asynchronous programming (async/await).
