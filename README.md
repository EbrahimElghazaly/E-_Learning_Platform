# 🎓 E-Learning Platform

A C# / .NET Console-based E-Learning Platform designed to demonstrate Object-Oriented Programming (OOP) concepts and the practical application of the five SOLID principles through clean code and refactoring.

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![OOP](https://img.shields.io/badge/OOP-58a6ff?style=for-the-badge)
![SOLID](https://img.shields.io/badge/SOLID-bc8cff?style=for-the-badge)
![Console App](https://img.shields.io/badge/Console-App-3fb950?style=for-the-badge)
![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)

---

## 📑 Table of Contents

1. [Project Overview](#-project-overview)
2. [Team Members](#-team-members)
3. [Project Goals](#-project-goals)
4. [Technologies Used](#️-technologies-used)
5. [Project Structure](#-project-structure)
6. [OOP Concepts](#-oop-concepts)
7. [SOLID Principles](#-solid-principles)
8. [SOLID Summary](#-solid-summary)
9. [Entity Relationships](#-entity-relationships)
10. [Main Entities](#-main-entities)
11. [ConsolePrinter](#️-consoleprinter)
12. [Course Pricing Demonstration](#-course-pricing-demonstration)
13. [How to Run the Project](#️-how-to-run-the-project)
14. [Expected Output](#-expected-output)
15. [Project Versions](#-project-versions)
16. [Future Improvements](#-future-improvements)
17. [Future API Endpoints](#-future-api-endpoints)
18. [Learning Outcomes](#-learning-outcomes)
19. [Architecture Roadmap](#️-architecture-roadmap)
20. [Important Design Notes](#-important-design-notes)
21. [Team](#-team)
22. [Project Vision](#-project-vision)
23. [Final Message](#️-final-message)

---

## 📌 Project Overview

This project is an educational **E-Learning Platform** built using **C#** and **.NET** as a **Console Application**.

The project demonstrates:

- Object-Oriented Programming (OOP)
- Encapsulation
- Inheritance
- Polymorphism
- Abstraction
- SOLID Principles
- Refactoring
- Clean Code Concepts
- Relationships between real-world entities

The project was developed in two main stages:

- **Version 1:** Basic C# and OOP implementation without SOLID
- **Version 2:** Refactored version with practical application of the five SOLID principles

The second version focuses on improving maintainability, extensibility, and separation of responsibilities.

---

## 👨‍💻 Team Members

| Role | Name | Responsibility |
|------|------|----------------|
| 🏗️ Project Owner & Base Code | **Ibrahim Mohamed Elghazaly** | Project idea and initial implementation |
| 🔵 SRP | Mohamed Saeed | Single Responsibility Principle |
| 🟢 OCP | Ziad Elfeky | Open/Closed Principle |
| 🟡 LSP | Ahmed Khalifa | Liskov Substitution Principle |
| 🟠 OOP / Inheritance | Ghofran Mohamed | Inheritance and OOP concepts |
| 🔴 DIP | Youssef Hegazy | Dependency Inversion Principle |
| 🟣 ISP | Team | Interface Segregation Principle |

---

## 🎯 Project Goals

The main goals of this project are:

- ✅ Practice C# and .NET
- ✅ Understand OOP concepts
- ✅ Model real-world entities
- ✅ Understand relationships between objects
- ✅ Apply the five SOLID principles
- ✅ Refactor an existing codebase
- ✅ Improve code maintainability
- ✅ Prepare the project for future API and database integration

---

## 🛠️ Technologies Used

- **C#**
- **.NET**
- **Object-Oriented Programming (OOP)**
- **SOLID Principles**
- **Console Application**
- **Git**
- **GitHub**

---

## 🧱 Project Structure
E-Learning-Platform
│
├── E-Learning-Platform.sln
│
├── Models
│ ├── Instructor.cs
│ ├── Student.cs
│ ├── Category.cs
│ ├── Course.cs
│ ├── FreeCourse.cs
│ ├── CertificateCourse.cs
│ ├── DiscountCourse.cs
│ ├── Lesson.cs
│ ├── Enrollment.cs
│ ├── Payment.cs
│ └── Review.cs
│
├── Interfaces
│ ├── ICourseDisplay.cs
│ ├── ILessonManagement.cs
│ ├── IEnrollmentDisplay.cs
│ ├── IPaymentDisplay.cs
│ ├── IReviewDisplay.cs
│ └── IEnrollment.cs
│
├── Services
│ └── ConsolePrinter.cs
│
├── Program.cs
│
└── README.md

text

---

## 🧠 OOP Concepts

The project uses the main Object-Oriented Programming concepts.

### 1. Encapsulation

Each entity stores its related data and behavior inside a class.

**Examples:** `Student`, `Instructor`, `Course`, `Lesson`, `Enrollment`, `Payment`, `Review`.

### 2. Inheritance

> **Note:** Inheritance is an OOP concept, **not one of the five SOLID principles**.

The project uses inheritance to create specialized course types from the base `Course` class.

```csharp
public class Course
{
    public virtual double GetFinalPrice()
    {
        return Price;
    }
}

public class FreeCourse : Course
{
    public override double GetFinalPrice()
    {
        return 0;
    }
}

public class CertificateCourse : Course
{
    public override double GetFinalPrice()
    {
        return Price + CertificateFee;
    }
}

public class DiscountCourse : Course
{
    public override double GetFinalPrice()
    {
        return Price - (Price * DiscountPercentage / 100);
    }
}
This allows specialized classes to reuse common properties and behavior from Course.

3. Polymorphism
Polymorphism is demonstrated by storing different course types in a collection of the base type:

csharp
List<Course> allCourses =
    new List<Course>
    {
        course1,
        course2,
        course3,
        freeCourse,
        certificateCourse,
        discountCourse
    };
Then:

csharp
foreach (Course course in allCourses)
{
    Console.WriteLine(course.GetFinalPrice());
}
The same method GetFinalPrice() can produce different results depending on the actual object type.

4. Abstraction
The project uses interfaces to define contracts without exposing implementation details.

csharp
public interface IEnrollment
{
    string StudentName { get; }
    string CourseTitle { get; }
}
The Payment class can work with the abstraction instead of directly depending on the concrete Enrollment class.

🧩 SOLID Principles
The project demonstrates all five SOLID principles:

S → Single Responsibility Principle

O → Open/Closed Principle

L → Liskov Substitution Principle

I → Interface Segregation Principle

D → Dependency Inversion Principle

🔵 1. SRP — Single Responsibility Principle
Responsible: Mohamed Saeed

Definition: A class should have one reason to change.

The project separates the responsibility of displaying information from the entity classes.

csharp
public class ConsolePrinter
{
    public void ShowStudent(Student student)
    {
        Console.WriteLine("Student ID: " + student.StudentID);
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Email: " + student.Email);
    }

    public void ShowCourse(Course course)
    {
        // Display course information
    }
}
ConsolePrinter has one main responsibility: Displaying system data in the Console.

The models represent the application's data, while ConsolePrinter handles presentation.

Benefits:

Easier maintenance

Easier modification

Better separation of responsibilities

Easier future testing

🟢 2. OCP — Open/Closed Principle
Responsible: Ziad Elfeky

Definition: Software entities should be open for extension but closed for modification.

The base Course class defines common pricing behavior:

csharp
public virtual double GetFinalPrice()
{
    return Price;
}
New course types can extend this behavior without modifying the original Course implementation.

csharp
public class DiscountCourse : Course
{
    public double DiscountPercentage;

    public override double GetFinalPrice()
    {
        return Price - (Price * DiscountPercentage / 100);
    }
}
Other course types include:

text
Course
├── FreeCourse
├── CertificateCourse
└── DiscountCourse
Benefit: If a new course type is required in the future (e.g., PremiumCourse, BundleCourse, SeasonalDiscountCourse), it can be implemented as a new class without changing the existing Course pricing logic.

🟡 3. LSP — Liskov Substitution Principle
Responsible: Ahmed Khalifa

Definition: Objects of a derived class should be usable wherever objects of the base class are expected without breaking the application.

The project demonstrates this using:

csharp
List<Course> allCourses =
    new List<Course>
    {
        course1,
        course2,
        course3,
        freeCourse,
        certificateCourse,
        discountCourse
    };
All derived classes can be treated as Course.

csharp
foreach (Course course in allCourses)
{
    Console.WriteLine(course.GetFinalPrice());
}
Each derived class provides its own implementation of GetFinalPrice(). Therefore, the base class reference can work with all supported course types.

🟣 4. ISP — Interface Segregation Principle
Definition: A class should not be forced to depend on methods it does not use.

Instead of creating one large interface:

csharp
// ❌ Large interface
public interface IPrinter
{
    void ShowCourse(Course course);
    void ShowStudent(Student student);
    void ShowEnrollment(Enrollment enrollment);
    void ShowPayment(Payment payment);
    void ShowReview(Review review);
}
The project separates responsibilities into smaller interfaces:

csharp
public interface ICourseDisplay
{
    void ShowCourse(Course course);
}
public interface ILessonManagement
{
    void AddLesson(Lesson lesson);
}
public interface IEnrollmentDisplay
{
    void ShowEnrollment(Enrollment enrollment);
}
public interface IPaymentDisplay
{
    void ShowPayment(Payment payment);
}
public interface IReviewDisplay
{
    void ShowReview(Review review);
}
For example:

csharp
public class Course : ILessonManagement
{
    public void AddLesson(Lesson lesson)
    {
        Lessons.Add(lesson);
    }
}
Course implements only the interface it actually needs.

Benefit: Small interfaces make the system easier to understand, maintain, extend, and test.

🔴 5. DIP — Dependency Inversion Principle
Responsible: Youssef Hegazy

Definition: High-level modules should not depend directly on low-level concrete implementations. Both should depend on abstractions.

The project defines:

csharp
public interface IEnrollment
{
    string StudentName { get; }
    string CourseTitle { get; }
}
Enrollment implements this abstraction:

csharp
public class Enrollment : IEnrollment
{
    public string StudentName
    {
        get { return Student.Name; }
    }

    public string CourseTitle
    {
        get { return Course.Title; }
    }
}
The Payment class depends on the abstraction:

csharp
public class Payment
{
    public IEnrollment Enrollment;

    public Payment(
        int paymentID,
        IEnrollment enrollment,
        double amount,
        string paymentMethod,
        DateTime paymentDate,
        string status)
    {
        PaymentID = paymentID;
        Enrollment = enrollment;
        Amount = amount;
        PaymentMethod = paymentMethod;
        PaymentDate = paymentDate;
        Status = status;
    }
}
Instead of public Enrollment Enrollment;, the project uses public IEnrollment Enrollment;.

Important Note: The current project demonstrates Dependency Inversion, but it does not yet implement a full Dependency Injection container. A future ASP.NET Core version can introduce Constructor Injection, .NET DI Container, and Service Registration.

📊 SOLID Summary
Principle	Meaning	Application	Responsible
SRP	Single Responsibility	ConsolePrinter handles presentation	Mohamed Saeed
OCP	Open/Closed	New course types extend Course	Ziad Elfeky
LSP	Liskov Substitution	Derived courses work as Course	Ahmed Khalifa
ISP	Interface Segregation	Small specialized interfaces	Team
DIP	Dependency Inversion	Payment depends on IEnrollment	Youssef Hegazy
🔗 Entity Relationships
text
Instructor (1) ────────► (N) Course

Category   (1) ────────► (N) Course

Course     (1) ────────► (N) Lesson

Student    (1) ────────► (N) Enrollment ◄────── (N) Course

Enrollment (1) ────────► (1) Payment

Student    (1) ────────► (N) Review ◄────────── (N) Course

Student    (N) ◄──────────────────────────────► (N) Course
                     through Enrollment
Relationship Details
Relationship	Type	Description
Instructor → Course	1 : N	One instructor can have multiple courses
Category → Course	1 : N	One category can contain multiple courses
Course → Lesson	1 : N	One course can contain multiple lessons
Student → Enrollment	1 : N	One student can have multiple enrollments
Course → Enrollment	1 : N	One course can have multiple enrollments
Enrollment → Payment	1 : 1*	Business assumption that an enrollment has one payment
Student → Review	1 : N	One student can write multiple reviews
Course → Review	1 : N	One course can have multiple reviews
Note: The Enrollment → Payment 1:1 relationship is a business assumption. The current object model does not enforce the relationship from both sides.

🧩 Main Entities
👨‍🎓 Student
csharp
Student student1 =
    new Student(
        1,
        "Ibrahim Elghazaly",
        "ibrahim@gmail.com"
    );
👨‍🏫 Instructor
csharp
Instructor instructor1 =
    new Instructor(
        1,
        "Ahmed Mohamed",
        "ahmed@gmail.com",
        "C# and .NET",
        "C# and .NET Instructor"
    );
🗂️ Category
csharp
Category category1 =
    new Category(
        1,
        "Programming"
    );
📚 Course
csharp
Course course1 =
    new Course(
        1,
        "C# Programming",
        "Learn C# Programming",
        150,
        "40 Hours",
        "Beginner",
        "English",
        instructor1,
        category1
    );
🆓 FreeCourse
csharp
FreeCourse freeCourse =
    new FreeCourse(
        4,
        "Intro to Git & GitHub",
        "A free introductory course",
        "5 Hours",
        "Beginner",
        "English",
        instructor1,
        category1
    );
🎓 CertificateCourse
csharp
CertificateCourse certificateCourse =
    new CertificateCourse(
        5,
        "Advanced ASP.NET Core",
        "Deep dive with a certificate",
        300,
        "60 Hours",
        "Advanced",
        "English",
        instructor2,
        category2
    );
🏷️ DiscountCourse
csharp
DiscountCourse discountCourse =
    new DiscountCourse(
        6,
        "ASP.NET Core",
        "Learn ASP.NET Core with discount",
        200,
        20,
        "40 Hours",
        "Intermediate",
        "English",
        instructor1,
        category1
    );
📖 Lesson
csharp
Lesson lesson1 =
    new Lesson(
        1,
        "Introduction to C#",
        "20 Minutes",
        1
    );

course1.AddLesson(lesson1);
The AddLesson() operation is provided through ILessonManagement.

📝 Enrollment
csharp
Enrollment enrollment1 =
    new Enrollment(
        1,
        student1,
        course1,
        DateTime.Now,
        "Active",
        150,
        "Credit Card"
    );
Enrollment implements IEnrollment.

💳 Payment
csharp
Payment payment1 =
    new Payment(
        1,
        enrollment1,
        150,
        "Credit Card",
        DateTime.Now,
        "Completed"
    );
Payment depends on IEnrollment rather than directly depending on the concrete Enrollment type.

⭐ Review
csharp
Review review1 =
    new Review(
        1,
        student1,
        course1,
        5,
        "Very good course",
        DateTime.Now
    );
🖨️ ConsolePrinter
ConsolePrinter is the main presentation component in the Console Application. It implements several small display interfaces:

csharp
public class ConsolePrinter :
    ICourseDisplay,
    IEnrollmentDisplay,
    IPaymentDisplay,
    IReviewDisplay
{
    public void ShowStudent(Student student)
    {
        // Display student information
    }

    public void ShowInstructor(Instructor instructor)
    {
        // Display instructor information
    }

    public void ShowCourse(Course course)
    {
        // Display course information
    }

    public void ShowEnrollment(Enrollment enrollment)
    {
        // Display enrollment information
    }

    public void ShowPayment(Payment payment)
    {
        // Display payment information
    }

    public void ShowReview(Review review)
    {
        // Display review information
    }
}
Design Principles Demonstrated:

SRP: Presentation is separated from model classes.

ISP: Display responsibilities are separated into focused interfaces.

💰 Course Pricing Demonstration
The project contains several pricing behaviors:

Course Type	Base Price	Rule	Final Price
Course	150	No change	150
Course	120	No change	120
Course	180	No change	180
FreeCourse	0	Free	0
CertificateCourse	300	+100 certificate fee	400
DiscountCourse	200	20% discount	160
Calculation
text
150 + 120 + 180 + 0 + 400 + 160 = 1010
Therefore:

text
Total Final Price of Courses: 1010
This value represents the sum of the final prices of the course objects. It should not be interpreted as actual business revenue from enrollments.

▶️ How to Run the Project
1. Clone the Repository
bash
git clone https://github.com/EbrahimElghazaly/E_Learning_Platform.git
2. Open the Project
bash
cd E_Learning_Platform
3. Build the Project
bash
dotnet build
4. Run the Application
bash
dotnet run
📤 Expected Output
text
========== STUDENTS ==========

Student ID: 1
Name: Ibrahim Elghazaly
Email: ibrahim@gmail.com


========== INSTRUCTORS ==========

Instructor ID: 1
Name: Ahmed Mohamed
Email: ahmed@gmail.com
Specialization: C# and .NET
Bio: C# and .NET Instructor


========== COURSES ==========

Course ID: 1
Title: C# Programming
Final Price: 150


========== LSP DEMO ==========

Final Price To Pay: 150
Final Price To Pay: 120
Final Price To Pay: 180
Final Price To Pay: 0
Final Price To Pay: 400
Final Price To Pay: 160

Total Final Price of Courses: 1010


========== ENROLLMENTS ==========

========== PAYMENTS ==========

========== REVIEWS ==========
🔄 Project Versions
Version 1 — Basic Implementation
The first version focuses on:

C# fundamentals

Classes and Objects

Constructors

Collections

Basic relationships

Basic OOP

It intentionally does not focus on SOLID.

Version 2 — Refactoring & SOLID
The second version refactors the project and introduces:

SRP

OCP

LSP

ISP

DIP

Interfaces

Polymorphism

Better separation of responsibilities

More extensible course pricing

This is the current SOLID-focused implementation.

🌱 Future Improvements
🔐 Authentication
Student registration

Instructor registration

Admin authentication

JWT Authentication

Role-based authorization

🔍 Search & Filtering
Search courses

Filter by category

Filter by level

Filter by price

Filter by instructor

📊 Dashboards
Student Dashboard

Instructor Dashboard

Admin Dashboard

💳 Payments
A future version can introduce IPaymentMethod with implementations such as:

CreditCardPayment

CashPayment

PayPalPayment

WalletPayment

This would provide another practical example of Abstraction, OCP, DIP, and Polymorphism.

🗄️ Database
SQL Server

Entity Framework Core

Database Migrations

Relationships

CRUD Operations

🌐 Backend
ASP.NET Core Web API

RESTful APIs

JWT Authentication

Dependency Injection

Repository Pattern

Service Layer

🧪 Testing
Unit Testing

xUnit

Mocking

Integration Testing

🏛️ Architecture
Clean Architecture

Separation of Concerns

Service Layer

Repository Layer

🔌 Future API Endpoints
A future ASP.NET Core Web API version could expose:

text
GET     /api/students
POST    /api/students

GET     /api/courses
POST    /api/courses
GET     /api/courses/{id}

POST    /api/enrollments

POST    /api/payments

POST    /api/reviews
GET     /api/courses/{id}/reviews
These endpoints are planned for a future ASP.NET Core Web API version and are not part of the current Console Application.

🎓 Learning Outcomes
After completing this project, the team practiced:

✅ Building a C# application from scratch

✅ Creating classes and objects

✅ Using constructors

✅ Working with collections

✅ Modeling real-world entities

✅ Creating object relationships

✅ Understanding inheritance

✅ Understanding polymorphism

✅ Using abstraction and interfaces

✅ Applying SOLID principles

✅ Refactoring existing code

✅ Separating responsibilities

✅ Designing extensible code

✅ Preparing a project for future API and database integration

🏛️ Architecture Roadmap
text
C# Console Application
        ↓
       OOP
        ↓
   Clean Code
        ↓
      SOLID
        ↓
   SQL Server
        ↓
Entity Framework Core
        ↓
ASP.NET Core Web API
        ↓
Dependency Injection
        ↓
Authentication & Authorization
        ↓
     Frontend
        ↓
Complete E-Learning Platform
📌 Important Design Notes
SOLID
The project demonstrates the five official SOLID principles:

S → Single Responsibility Principle

O → Open/Closed Principle

L → Liskov Substitution Principle

I → Interface Segregation Principle

D → Dependency Inversion Principle

Inheritance
Inheritance is not a sixth SOLID principle. It is an Object-Oriented Programming concept used in this project to support code reuse, polymorphism, and specialized course types.

Dependency Inversion vs Dependency Injection
The current project demonstrates Dependency Inversion by making Payment depend on IEnrollment instead of Enrollment.

A future version can implement full Dependency Injection using:

Constructor Injection

.NET DI Container

Service Registration

👨‍💻 Team
Name	Contribution
Ibrahim Mohamed Elghazaly	Project idea, base implementation, integration
Mohamed Saeed	SRP
Ziad Elfeky	OCP
Ahmed Khalifa	LSP
Ghofran Mohamed	OOP / Inheritance
Youssef Hegazy	DIP
Team	ISP and final integration
⭐ Project Vision
The goal is to transform the current educational Console Application into a complete and scalable E-Learning Platform.

text
Console App
     ↓
OOP
     ↓
SOLID
     ↓
Clean Code
     ↓
Database
     ↓
ASP.NET Core API
     ↓
Authentication
     ↓
Frontend
     ↓
Complete E-Learning Platform
❤️ Final Message
This project represents a practical learning journey from basic C# programming and OOP to SOLID principles, refactoring, abstraction, polymorphism, and clean code.

It provides a foundation that can later evolve into a complete ASP.NET Core + SQL Server E-Learning Platform.

<div align="center">
Made with ❤️ by Ibrahim Mohamed Elghazaly & Team

⭐ Don't forget to star the repository if you found it useful! ⭐

</div> ```
