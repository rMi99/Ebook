````markdown
# 📚 Ebook Management System

An **ASP.NET Core 8.0** web application for managing ebooks with full **CRUD functionality** (Create, Read, Update, Delete).  
Built with **Entity Framework Core**, **MySQL**, and **MVC architecture**.

---

## 🚀 Tech Stack

- **Backend**: ASP.NET Core 8.0 (C#)
- **Database**: MySQL (Pomelo.EntityFrameworkCore.MySql)
- **ORM**: Entity Framework Core
- **Architecture**: MVC (Model–View–Controller)
- **Frontend**: Razor Views (HTML, CSS, Bootstrap)

---

## 📌 Features

- 📥 **Add New Ebooks** – Upload and store ebook details.
- 📖 **View Ebook List** – Display all ebooks in a clean interface.
- ✏️ **Edit Ebook Details** – Update title, author, description, etc.
- ❌ **Delete Ebooks** – Remove unwanted ebook entries.
- 🔍 **Search & Filter** – Easily find specific ebooks.
- 🗄 **MySQL Integration** – Store and manage data efficiently.
- 🛠 **Entity Framework Core Migrations** – Version-controlled DB schema.

---

## 🛠 Prerequisites

Make sure you have installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [MySQL Server](https://dev.mysql.com/downloads/)  
  *(or any MySQL-compatible DB)*
- IDE: [Visual Studio](https://visualstudio.microsoft.com/), [VS Code](https://code.visualstudio.com/), or [JetBrains Rider](https://www.jetbrains.com/rider/)

---

## 📂 Project Setup

### 1️⃣ Clone the Repository
```bash
git clone https://github.com/rMi99/Ebook.git
cd Ebook
````

### 2️⃣ Configure Database Connection

* Create a **MySQL database** (example: `ebook_db`)
* Update `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ebook_db;User=root;Password=your_password;"
  }
}
```

### 3️⃣ Apply Migrations

```bash
dotnet ef database update
```

### 4️⃣ Run the Application

```bash
dotnet run
```

Open your browser and visit:
➡️ **[https://localhost:5001](https://localhost:5001)** or **[http://localhost:5000](http://localhost:5000)**

---

## 📂 Project Structure

```
Ebook/
├── Controllers/       # MVC Controllers for CRUD operations
├── Models/            # Data Models (Ebook.cs, etc.)
├── Views/             # Razor Views (List, Create, Edit, Delete)
├── Migrations/        # EF Core Database Migrations
├── wwwroot/           # Static files (CSS, JS, Images)
├── appsettings.json   # Configuration file
└── Program.cs         # Application entry point
```

---

## 🧪 CRUD Operations Overview

| Operation  | HTTP Method | Route Example         | Description          |
| ---------- | ----------- | --------------------- | -------------------- |
| **Create** | POST        | `/Ebooks/Create`      | Add new ebook entry  |
| **Read**   | GET         | `/Ebooks`             | View list of ebooks  |
| **Update** | POST        | `/Ebooks/Edit/{id}`   | Update ebook details |
| **Delete** | POST        | `/Ebooks/Delete/{id}` | Remove ebook entry   |

---

## 📝 Development Notes

* Uses **Pomelo.EntityFrameworkCore.MySql** for MySQL support
* **Entity Framework Core** handles ORM & migrations
* Supports **Dependency Injection**
* Nullable reference types are enabled for better type safety

---

## 📜 License

[MIT License](LICENSE) – You’re free to use, modify, and distribute this project.

---

💡 **Author:** [Ramisha](https://github.com/rMi99)
📧 For issues or questions, open a GitHub issue or contact me.

```

