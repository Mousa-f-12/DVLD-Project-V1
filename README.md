# 🚗 Driver & Vehicle Licensing Department (DVLD) System

A comprehensive Windows desktop application designed to manage and automate core operations for a Driver and Vehicle Licensing Department. Built using **C#**, **.NET Framework**, and **SQL Server**, this system follows a clean **3-Tier Architecture** to ensure maintainability, scalability, and robust separation of concerns.

---

## 🎯 Key Features

* **Person & User Management:** Complete CRUD operations, user role assignments, authentication, and custom search/filter controls.
* **Local & International Driving Licenses:** End-to-end processing for issue, renewal, replacement (lost/damaged), and detaining/releasing licenses.
* **Application & Test Tracking:** Full workflow management for written, vision, and street driving tests with structured appointment scheduling.
* **Driver Records & History:** Consolidated historical tracking of driver licenses, violations, and active statuses.
* **Custom UI Controls:** Modular Windows Forms user controls for consistent data rendering across multiple workflow screens.

---

## 🏗️ Software Architecture

The project is structured into three main layers to decouple business logic from data access and presentation:

1. **Presentation Layer (`DVLD/` / `PresentationLayer`)**
   * Windows Forms UI components, custom controls, and input validation logic.
2. **Business Layer (`BusinessLayer`)**
   * Enforces system logic, validation rules, state transitions, and workflow execution.
3. **Data Access Layer (`DataAccessLayer`)**
   * Direct database communication via ADO.NET using parameterized SQL queries for security and performance.

---

## 🛠️ Tech Stack & Tools

* **Language:** C# (.NET Framework)
* **UI Framework:** Windows Forms (WinForms)
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataReader`, `DataView`)
* **Version Control:** Git & GitHub
