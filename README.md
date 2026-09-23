# 🎓 E-Learning Platform - C#

<div align="center">

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![OOP](https://img.shields.io/badge/OOP-Object--Oriented-blue?style=for-the-badge)
![Console](https://img.shields.io/badge/Console-Application-black?style=for-the-badge)
![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)

A simple **Console-Based E-Learning Platform** built with **C#** and **Object-Oriented Programming (OOP)** concepts.

This project represents the **first version** of an educational platform where students can enroll in courses, instructors can create courses, courses contain lessons, students can make payments, and students can add reviews.

> 🚀 This version is intentionally implemented **without SOLID principles**.
>
> The main purpose is to first build the project using a simple and direct approach, then refactor the same project later by applying the **5 SOLID principles**.

</div>

---

## 📌 Project Overview

The **E-Learning Platform** is a C# Console Application designed to simulate the basic operations of an online learning system.

The system contains several main entities:

| Entity | Description |
|--------|-------------|
| 👨‍🎓 **Student** | A student registered on the platform |
| 👨‍🏫 **Instructor** | The person who creates and manages courses |
| 📚 **Course** | An educational course available on the platform |
| 🗂️ **Category** | The category of a course |
| 📖 **Lesson** | A lesson inside a course |
| 📝 **Enrollment** | Registration of a student in a course |
| 💳 **Payment** | A payment made for an enrollment |
| ⭐ **Review** | A student's review of a course |

The project focuses on understanding:

- ✅ Classes and Objects
- ✅ Constructors
- ✅ Properties
- ✅ Encapsulation
- ✅ Object Relationships
- ✅ Collections
- ✅ Basic OOP
- ✅ Entity Relationships
- ✅ C# Programming Fundamentals

---

## 🎯 Project Goals

1. Practice C# programming.
2. Understand Object-Oriented Programming.
3. Create classes that represent real-world entities.
4. Understand relationships between objects.
5. Build a simple E-Learning system.
6. Practice creating and using objects.
7. Understand the problems that can appear in a project without SOLID.
8. Prepare the project for a future SOLID refactoring.

---

## 🏗️ Project Structure

```text
E-Learning-Platform
│
├── E-Learning-Platform.sln
│
├── Models
│   ├── Student.cs
│   ├── Instructor.cs
│   ├── Category.cs
│   ├── Course.cs
│   ├── Lesson.cs
│   ├── Enrollment.cs
│   ├── Payment.cs
│   └── Review.cs
│
├── Services
│   ├── StudentService.cs
│   ├── CourseService.cs
│   ├── EnrollmentService.cs
│   └── PaymentService.cs
│
├── Interfaces
│   ├── IPaymentMethod.cs
│   └── ...
│
├── Program.cs
│
└── README.md
```

---

## 🔗 Entity Relationships

```text
Instructor
    │ 1
    │ N
    ▼
  Course
    │
    ├───────────────┐
    │ N             │ N
    ▼               ▼
 Lesson         Enrollment
                    │
                    ▼
                 Payment

Category
    │ 1
    │ N
    ▼
  Course

Student
    ├───────────────► Enrollment
    └───────────────► Review

Course
    ├───────────────► Enrollment
    ├───────────────► Lesson
    └───────────────► Review
```

### Relationship Summary

| Relationship | Type | Description |
|--------------|------|-------------|
| Instructor → Course | 1 : N | One instructor can create many courses |
| Category → Course | 1 : N | One category can contain many courses |
| Course → Lesson | 1 : N | One course can contain many lessons |
| Student → Enrollment | 1 : N | One student can enroll in many courses |
| Course → Enrollment | 1 : N | One course can have many enrollments |
| Enrollment → Payment | 1 : 1 | Each enrollment can have its own payment |
| Student → Review | 1 : N | One student can write multiple reviews |
| Course → Review | 1 : N | One course can have multiple reviews |
| Student ↔ Course | N : N | Represented through **Enrollment** |

---

## 🧩 Entities Details

### 👨‍🎓 Student

**Properties:** `StudentID`, `Name`, `Email`

```csharp
Student student1 = new Student(1, "Ahmed Mohamed", "ahmed@gmail.com");
Student student2 = new Student(2, "Mohamed Ali", "mohamed@gmail.com");
Student student3 = new Student(3, "Ali Mohamed", "ali@gmail.com");
```

The student can **enroll in courses** and **write reviews** for courses.

---

### 👨‍🏫 Instructor

**Properties:** `InstructorID`, `Name`, `Email`

```csharp
Instructor instructor1 =
    new Instructor(1, "Ahmed Hassan", "ahmed@academy.com");
```

An instructor can create **multiple courses**.

---

### 🗂️ Category

**Examples:** Programming, Web Development, Database, Software Engineering, Data Science.

**Properties:** `CategoryID`, `CategoryName`

```csharp
Category category1 = new Category(1, "Programming");
```

A category can contain **many courses**.

---

### 📚 Course

**Properties:** `CourseID`, `CourseName`, `Description`, `Price`, `InstructorID`, `CategoryID`

```csharp
Course course1 =
    new Course(
        1,
        "C# Programming",
        "Learn C# from Beginner to Advanced",
        500,
        1,
        1
    );
```

A course belongs to **one instructor** and **one category**, and can contain **multiple lessons**.

---

### 📖 Lesson

**Properties:** `LessonID`, `LessonTitle`, `Content`, `CourseID`

```csharp
Lesson lesson1 =
    new Lesson(
        1,
        "Introduction to C#",
        "C# is a modern programming language...",
        1
    );
```

---

### 📝 Enrollment

**Properties:** `EnrollmentID`, `StudentID`, `CourseID`, `EnrollmentDate`

```csharp
Enrollment enrollment1 =
    new Enrollment(
        1,
        1,
        1,
        DateTime.Now
    );
```

> 💡 The Enrollment entity is important because it connects students with courses.

---

### 💳 Payment

**Properties:** `PaymentID`, `EnrollmentID`, `Amount`, `PaymentDate`, `PaymentMethod`

```csharp
Payment payment1 =
    new Payment(
        1,
        1,
        500,
        DateTime.Now,
        "Visa"
    );
```

---

### ⭐ Review

**Properties:** `ReviewID`, `StudentID`, `CourseID`, `Rating`, `Comment`

```csharp
Review review1 =
    new Review(
        1,
        1,
        1,
        5,
        "Very useful course."
    );
```

---

## 🧩 Database / ERD Concept

```text
Student
---------
StudentID PK
Name
Email


Instructor
---------
InstructorID PK
Name
Email


Category
---------
CategoryID PK
CategoryName


Course
---------
CourseID PK
CourseName
Description
Price
InstructorID FK
CategoryID FK


Lesson
---------
LessonID PK
LessonTitle
Content
CourseID FK


Enrollment
---------
EnrollmentID PK
StudentID FK
CourseID FK
EnrollmentDate


Payment
---------
PaymentID PK
EnrollmentID FK
Amount
PaymentDate
PaymentMethod


Review
---------
ReviewID PK
StudentID FK
CourseID FK
Rating
Comment
```

---

## 🧠 OOP Concepts Used

### 1️⃣ Classes

```csharp
public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}
```

### 2️⃣ Objects

```csharp
Student student1 =
    new Student(1, "Ahmed Mohamed", "ahmed@gmail.com");
```

### 3️⃣ Constructors

```csharp
public Student(int studentID, string name, string email)
{
    StudentID = studentID;
    Name = name;
    Email = email;
}
```

### 4️⃣ Properties

```csharp
public int StudentID { get; set; }
public string Name { get; set; }
public string Email { get; set; }
```

### 5️⃣ Encapsulation

```csharp
public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public Student(int studentID, string name, string email)
    {
        StudentID = studentID;
        Name = name;
        Email = email;
    }
}
```

---

## 💻 Example of Creating Objects

```csharp
// Students
Student student1 = new Student(1, "Ahmed Mohamed", "ahmed@gmail.com");
Student student2 = new Student(2, "Mohamed Ali", "mohamed@gmail.com");
Student student3 = new Student(3, "Ali Mohamed", "ali@gmail.com");

// Instructor
Instructor instructor1 =
    new Instructor(1, "Ahmed Hassan", "ahmed@academy.com");

// Category
Category category1 = new Category(1, "Programming");

// Course
Course course1 =
    new Course(
        1,
        "C# Programming",
        "Learn C# from Beginner to Advanced",
        500,
        1,
        1
    );
```

---

## 🚫 Version 1 - Without SOLID

The first version of this project is **intentionally written without applying SOLID principles**.

```text
Course
   ↓
Payment
   ↓
Student
   ↓
Enrollment
```

### ⚠️ Problems Without SOLID

| # | Problem | Description |
|---|---------|-------------|
| 1 | **Too Many Responsibilities** | A single class may handle data, validation, payment, email, and registration |
| 2 | **Difficult to Add New Features** | Adding new payment methods requires modifying existing code |
| 3 | **Tight Coupling** | Classes directly create and depend on other classes |
| 4 | **Difficult Testing** | Strongly connected classes are hard to test independently |
| 5 | **Large Interfaces** | Unrelated methods forced into a single interface |

---

## 🧱 SOLID Version - Future Refactoring

### 🔵 1. SRP - Single Responsibility Principle

> *A class should have one main responsibility.*

```text
Student
StudentValidator
PaymentService
EnrollmentService
EmailService
```

---

### 🟢 2. OCP - Open/Closed Principle

> *Software should be open for extension but closed for modification.*

```csharp
public interface IPaymentMethod
{
    void Pay(decimal amount);
}

public class VisaPayment : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Payment using Visa");
    }
}

public class PayPalPayment : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Payment using PayPal");
    }
}
```

---

### 🟡 3. LSP - Liskov Substitution Principle

> *Objects of a child class should be usable wherever the parent class is expected.*

```csharp
public class Payment
{
    public virtual void Pay() { }
}
```

---

### 🟠 4. ISP - Interface Segregation Principle

> *A class should not be forced to implement methods that it does not need.*

```csharp
public interface ILogin { void Login(); }
public interface ICourseCreator { void CreateCourse(); }
public interface IPayment { void Pay(); }
```

---

### 🔴 5. DIP - Dependency Inversion Principle

> *High-level classes should depend on abstractions rather than concrete implementations.*

```csharp
public class PaymentService
{
    private IPaymentMethod paymentMethod;

    public PaymentService(IPaymentMethod paymentMethod)
    {
        this.paymentMethod = paymentMethod;
    }

    public void MakePayment(decimal amount)
    {
        paymentMethod.Pay(amount);
    }
}
```

---

## 📊 SOLID Summary

| Principle | Meaning | Main Problem Solved |
|-----------|---------|---------------------|
| **SRP** | Single Responsibility | Too many responsibilities |
| **OCP** | Open/Closed | Difficult feature extension |
| **LSP** | Liskov Substitution | Incorrect inheritance behavior |
| **ISP** | Interface Segregation | Large interfaces |
| **DIP** | Dependency Inversion | Tight coupling |

---

## 🔄 Development Plan

### Stage 1 - Basic Version

```text
C#
 ↓
Classes
 ↓
Objects
 ↓
Constructors
 ↓
Properties
 ↓
Relationships
 ↓
Basic Application
```

### Stage 2 - SOLID Version

```text
Existing Project
       ↓
Analyze Problems
       ↓
Apply SRP
       ↓
Apply OCP
       ↓
Apply LSP
       ↓
Apply ISP
       ↓
Apply DIP
       ↓
Refactored Project
```

---

## ▶️ How to Run the Project

### 1. Clone the Repository

```bash
git clone https://github.com/EbrahimElghazaly/E-_Learning_Platform.git
```

### 2. Open the Project

Open the project using **Visual Studio** or **Visual Studio Code**.

### 3. Build the Project

```bash
dotnet build
```

### 4. Run the Project

```bash
dotnet run
```

---

## 🛠️ Technologies Used

- **C#**
- **.NET**
- **Object-Oriented Programming**
- **Console Application**
- **Git**
- **GitHub**

---

## 📚 Concepts Practiced

```text
C# Fundamentals
        ↓
Classes
        ↓
Objects
        ↓
Constructors
        ↓
Properties
        ↓
Encapsulation
        ↓
Object Relationships
        ↓
Collections
        ↓
OOP
        ↓
SOLID
```

---

## 🌱 Future Improvements

- 🔐 User Authentication (Login / Register, Password Hashing)
- 🔍 Course Search & Filtering
- 📊 Student Dashboard
- 👨‍🏫 Instructor Dashboard
- 🛠️ Admin Dashboard
- 📈 Course Progress
- 🎓 Certificates
- 💳 Payment Integration (Multiple Payment Methods)
- 🗄️ Database Integration (Entity Framework Core, SQL Server)
- 🌐 ASP.NET Core Web API
- 🔑 JWT Authentication
- 🏛️ Repository Pattern
- 💉 Dependency Injection
- 🧪 Unit Testing
- 🧼 Clean Architecture

---

## 🗄️ Future Database

The project can later be connected to **SQL Server**.

Possible database tables:

```text
Students
Instructors
Categories
Courses
Lessons
Enrollments
Payments
Reviews
```

---

## 🔌 Future ASP.NET Core API

Possible API endpoints:

```http
GET     /api/students
POST    /api/students

GET     /api/courses
POST    /api/courses
GET     /api/courses/{id}

POST    /api/enrollments

POST    /api/payments

POST    /api/reviews
GET     /api/courses/{id}/reviews
```

---

## 🧪 Testing

Testing can be added later using:

- **xUnit**
- **NUnit**
- **MSTest**

The SOLID version will make testing individual components easier.

---

## 🔀 Git Workflow

```bash
# Initialize Repository
git init

# Add Files
git add .

# Create Commit
git commit -m "Initial commit"

# Rename Branch
git branch -M main

# Add GitHub Remote
git remote add origin https://github.com/EbrahimElghazaly/E-_Learning_Platform.git

# Push Project
git push -u origin main
```

---

## 🚫 .gitignore

```gitignore
.vs/
bin/
obj/
*.user
*.suo
*.userosscache
*.sln.docstates
```

---

## 📌 Important Note

This project is intentionally divided into **two versions**.

### Version 1

```text
Basic C# Implementation
+
OOP
+
No SOLID
```

### Version 2

```text
Same Project
+
Refactoring
+
SOLID Principles
```

**S** → Single Responsibility Principle
**O** → Open/Closed Principle
**L** → Liskov Substitution Principle
**I** → Interface Segregation Principle
**D** → Dependency Inversion Principle

---

## 🎓 Learning Outcome

By completing this project, the developer will gain practical experience in:

- ✅ Building a C# application from scratch.
- ✅ Modeling real-world entities using classes.
- ✅ Creating relationships between objects.
- ✅ Understanding Object-Oriented Programming.
- ✅ Identifying problems in tightly coupled code.
- ✅ Understanding why software design principles are important.
- ✅ Refactoring an existing project.
- ✅ Applying SOLID principles to an existing application.
- ✅ Preparing a project for future database and API integration.

---

## 👨‍💻 Author

**Ibrahim Mohamed Elghazaly**

- 🎓 Computer Science Student
- 💻 Full Stack .NET Developer

---

## 📫 Project

**E-Learning Platform**

Built with:

- C#
- .NET
- OOP
- Git
- GitHub

---

## ⭐ Future Vision

```text
Console Application
        ↓
Clean C# Code
        ↓
SOLID Principles
        ↓
SQL Server
        ↓
Entity Framework Core
        ↓
ASP.NET Core Web API
        ↓
Authentication & Authorization
        ↓
Frontend Application
        ↓
Complete E-Learning Platform
```

---

## ⭐ If You Like This Project

Feel free to explore the source code, learn from it, and improve it.

More features and improvements can be added as the project evolves.

---

<div align="center">

### 🌟 Don't forget to Star the repository if you found it useful! 🌟

Made with ❤️ by **Ibrahim Mohamed Elghazaly**

</div>
