M-Suite

📌 Project Overview

M-Suite is a robust enterprise application designed to streamline business operations, including sales, warehousing, inventory management, and user authentication. The platform leverages ASP.NET Core MVC and Entity Framework Core to provide a scalable and secure system for managing transactions and user activities.

🚀 Features

🔐 User Authentication: Secure login system using cookies authentication.

🏬 Warehouse & Inventory Management: Track products and transactions efficiently.

📊 Sales & Order Processing: Manage orders and customer interactions.

📍 Geo-Location Tracking: Monitor deliveries and field operations.

📈 Reporting & Analytics: Generate real-time insights.

🛠️ Tech Stack

Framework: ASP.NET Core MVC

Database: Microsoft SQL Server (EF Core - Database First)

Authentication: Cookie-based authentication

Frontend: HTML / CSS / JAVASCRIPT

Version Control: Git & GitHub

🏗️ Setup Instructions

1️⃣ Clone the Repository

git clone https://github.com/MALIA/M-Suite.git
cd M-Suite

2️⃣ Configure Database Connection

Update the appsettings.json file with your SQL Server connection string:

"ConnectionStrings": {
  "MSuiteContext": "Server=YOUR_SERVER;Database=YOUR_DB;Trusted_Connection=True;TrustServerCertificate=True;"
}

3️⃣ Install Dependencies

dotnet restore

4️⃣ Apply Migrations (If Needed)

dotnet ef database update

5️⃣ Run the Application

dotnet run

📝 Contribution Guidelines

We welcome contributions! Please follow these steps:

Fork the Repository

Create a New Branch: git checkout -b feature-name

Commit Changes: git commit -m "Your commit message"

Push to GitHub: git push origin feature-name

Create a Pull Request (PR)



