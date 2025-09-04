# 🌸 Perfume Store Management System

Welcome to the **Perfume Store Management System**! This is a **desktop application** built using **Visual Studio (C# Windows Forms)** for the frontend and **MSSQL Server** for the database backend.  

This system allows admins and users to manage perfumes, brands, customers, sales, and orders efficiently. Perfect for learning **C#, Windows Forms, and SQL database integration**. 💻🛒

---

## 🗂️ Features

### 👨‍💼 Admin Module
- **Add / Update / Delete Brands** 🌟  
- **Add / Update / Delete Perfumes** 🌸  
- **Add / Update / Delete Customers** 🧑‍🤝‍🧑  
- **Add / Update / Delete Orders & Sales** 💳  
- **View Sales Items & Table Views** 📊  
- **Manage User Access / Roles** 🔑  

### 🧑 User Module
- **Place Orders** 🛍️  
- **View Table Data (Brands, Perfumes, Orders, Sales)** 📋  
- **Access Page for Login & Role Management** 🔒  

### 🛠️ Backend
- **MSSQL Server Database** with tables:  
  - `Brands` 🏷️  
  - `Perfumes` 🌸  
  - `Customers` 👤  
  - `Sales` 💰  
  - `Sale_Items` 📝  
  - `Orders` 🛒  
  - `order_items` 🛍️  
- **Stored Procedure**: Update perfume stock after a sale ⚡  
- **Triggers**: Automatically update stock when orders are added 🔄  
- **Roles**: `AdminRole` (full access) & `UserRole` (read-only) 🛡️  

---

## 🖥️ Technologies Used

- **Frontend**: Visual Studio C# Windows Forms 🎨  
- **Backend**: MSSQL Server 🗄️  
- **Languages**: C#, T-SQL 📜  

---

## 📂 File Structure

- `Admin_Add_Brand.cs` + `Designer` 🏷️  
- `Admin_Add_Customers.cs` + `Designer` 👤  
- `Admin_Add_Perfumes.cs` + `Designer` 🌸  
- `Admin_Add_Order.cs` + `Designer` 🛒  
- `Admin_Add_Sales.cs` + `Designer` 💰  
- `Admin_Add_SalesItems.cs` + `Designer` 📝  
- `Admin_TableView.cs` + `Designer` 📊  
- `Admin_AccessPage.cs` + `Designer` 🔑  
- `FrontPage.cs` + `Designer` 🏠  
- `User_Order.cs` + `Designer` 🛍️  
- `User_TableView.cs` + `Designer` 📋  
- `User_AccessPage.cs` + `Designer` 🔒  

---

## 🚀 How to Run

1. Open the solution in **Visual Studio** 🖥️  
2. Ensure your **SQL Server instance** is running and update the connection strings in the C# files if necessary 🔗  
3. Create the database **`Perfume_store`** and execute all SQL scripts in the following order:  
   1. Tables (`Brands`, `Perfumes`, `Customers`, `Sales`, `Sale_Items`, `Orders`, `order_items`)  
   2. Roles and users (`AdminRole`, `UserRole`)  
   3. Stored procedures and triggers  
4. Run the application and login as **Admin** or **User** to test features 🏁  

---

## 🔑 Default Users

| Username       | Role       | Password       |
|----------------|------------|----------------|
| `User_Admin`   | Admin      | `User_Admin`   |
| `User_Normal`  | User       | `User_Normal`  |

---

## 🌟 Key Features Summary

- ✅ Full **CRUD operations** for all tables  
- ✅ **Automatic stock updates** via triggers and stored procedures  
- ✅ **Role-based access control** for Admin and User  
- ✅ **User-friendly GUI** using Windows Forms  
- ✅ Integration of **Frontend (C#)** + **Backend (MSSQL)**  

---

## 🤝 Contributing

Contributions are welcome! You can:  
- Add new features like **report generation** 📄  
- Optimize database queries 🧮  
- Improve **UI/UX** 🎨  

---

## 📄 License

This project is **open-source** for educational purposes and learning. 🎓❤️
```

---
