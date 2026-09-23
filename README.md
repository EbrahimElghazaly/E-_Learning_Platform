# 🎓 E-Learning Platform - C#

A simple Console-Based E-Learning Platform developed using **C#** and **Object-Oriented Programming (OOP)** concepts.

This project represents the first version of an educational platform where students can enroll in courses, instructors can create courses, courses contain lessons, students can make payments, and students can add reviews.

> 🚀 This version is intentionally implemented **without SOLID principles**.
> 
> The main purpose is to first build the project using a simple and direct approach, then refactor the same project later by applying the **5 SOLID principles**.

---

## 📌 Project Overview

The **E-Learning Platform** is a C# Console Application designed to simulate the basic operations of an online learning system.

The system contains several main entities:

- 👨‍🎓 Student
- 👨‍🏫 Instructor
- 📚 Course
- 🗂️ Category
- 📖 Lesson
- 📝 Enrollment
- 💳 Payment
- ⭐ Review

The project focuses on understanding:

- Classes and Objects
- Constructors
- Properties
- Encapsulation
- Object Relationships
- Collections
- Basic OOP
- Entity Relationships
- C# Programming Fundamentals

---

# 🎯 Project Goals

The main goals of this project are:

1. Practice C# programming.
2. Understand Object-Oriented Programming.
3. Create classes that represent real-world entities.
4. Understand relationships between objects.
5. Build a simple E-Learning system.
6. Practice creating and using objects.
7. Understand the problems that can appear in a project without SOLID.
8. Prepare the project for a future SOLID refactoring.

---

# 🏗️ Project Structure

The project contains the following main classes:

👨‍🎓 Student

The Student class represents a student registered on the platform.

Main Properties
StudentID
Name
Email
Example
Student student1 = new Student(1, "Ahmed Mohamed", "ahmed@gmail.com");

Student student2 = new Student(2, "Mohamed Ali", "mohamed@gmail.com");

Student student3 = new Student(3, "Ali Mohamed", "ali@gmail.com");

The student can enroll in courses and write reviews for courses.

👨‍🏫 Instructor

The Instructor class represents the person who creates and manages courses.

Main Properties
InstructorID
Name
Email
Example
Instructor instructor1 =
    new Instructor(1, "Ahmed Hassan", "ahmed@academy.com");

An instructor can create multiple courses.

Relationship
Instructor 1 ---- N Course

This means:

One instructor can create many courses.

🗂️ Category

The Category class represents the category of a course.

Examples:

Programming
Web Development
Database
Software Engineering
Data Science
Main Properties
CategoryID
CategoryName
Example
Category category1 =
    new Category(1, "Programming");

A category can contain many courses.

Relationship
Category 1 ---- N Course
📚 Course

The Course class represents an educational course available on the platform.

Main Properties
CourseID
CourseName
Description
Price
InstructorID
CategoryID
Example
Course course1 =
    new Course(
        1,
        "C# Programming",
        "Learn C# from Beginner to Advanced",
        500,
        1,
        1
    );

A course belongs to one instructor and one category.

A course can also contain multiple lessons.

Relationships
Instructor 1 ---- N Course

Category 1 ---- N Course

Course 1 ---- N Lesson
📖 Lesson

The Lesson class represents a lesson inside a course.

Main Properties
LessonID
LessonTitle
Content
CourseID
Example
Lesson lesson1 =
    new Lesson(
        1,
        "Introduction to C#",
        "C# is a modern programming language...",
        1
    );

A course can contain multiple lessons.

Relationship
Course 1 ---- N Lesson
📝 Enrollment

The Enrollment class represents the registration of a student in a course.

Main Properties
EnrollmentID
StudentID
CourseID
EnrollmentDate
Example
Enrollment enrollment1 =
    new Enrollment(
        1,
        1,
        1,
        DateTime.Now
    );

The Enrollment entity is important because it connects students with courses.

Relationship
Student 1 ---- N Enrollment

Course 1 ---- N Enrollment

Therefore:

Student N ---- N Course

is represented through:

Enrollment
💳 Payment

The Payment class represents a payment made for an enrollment.

Main Properties
PaymentID
EnrollmentID
Amount
PaymentDate
PaymentMethod
Example
Payment payment1 =
    new Payment(
        1,
        1,
        500,
        DateTime.Now,
        "Visa"
    );

Each enrollment can have its own payment.

Relationship
Enrollment 1 ---- 1 Payment
⭐ Review

The Review class represents a student's review of a course.

Main Properties
ReviewID
StudentID
CourseID
Rating
Comment
Example
Review review1 =
    new Review(
        1,
        1,
        1,
        5,
        "Very useful course."
    );

A student can write multiple reviews.

A course can also have multiple reviews.

Relationships
Student 1 ---- N Review

Course 1 ---- N Review
🔗 Entity Relationships

The main relationships in the system are:

Instructor
    │
    │ 1
    │
    │ N
    ▼
  Course
    │
    ├───────────────┐
    │               │
    │ N             │ N
    ▼               ▼
 Lesson         Enrollment
                    │
                    │
                    ▼
                 Payment

Category
    │
    │ 1
    │
    │ N
    ▼
  Course

Student
    │
    ├───────────────► Enrollment
    │
    └───────────────► Review

Course
    │
    ├───────────────► Enrollment
    │
    ├───────────────► Lesson
    │
    └───────────────► Review
🧩 Database / ERD Concept

The project can be represented using the following entities:

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
🧠 OOP Concepts Used

This project is built using the main Object-Oriented Programming concepts.

1️⃣ Classes

Each entity is represented as a class.

Example:

public class Student
{
    public int StudentID { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }
}
2️⃣ Objects

Objects are created from classes.

Example:

Student student1 =
    new Student(
        1,
        "Ahmed Mohamed",
        "ahmed@gmail.com"
    );

Another example:

Course course1 =
    new Course(
        1,
        "C# Programming",
        "Learn C#",
        500,
        1,
        1
    );
3️⃣ Constructors

Constructors are used to initialize objects.

Example:

public Student(
    int studentID,
    string name,
    string email)
{
    StudentID = studentID;
    Name = name;
    Email = email;
}
4️⃣ Properties

Properties are used to store object data.

Example:

public int StudentID { get; set; }

public string Name { get; set; }

public string Email { get; set; }
5️⃣ Encapsulation

The classes keep their data and behavior organized inside the same class.

Example:

public class Student
{
    public int StudentID { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public Student(
        int studentID,
        string name,
        string email)
    {
        StudentID = studentID;
        Name = name;
        Email = email;
    }
}
💻 Example of Creating Objects

The project uses a simple and beginner-friendly approach.

Student student1 =
    new Student(
        1,
        "Ahmed Mohamed",
        "ahmed@gmail.com"
    );

Student student2 =
    new Student(
        2,
        "Mohamed Ali",
        "mohamed@gmail.com"
    );

Student student3 =
    new Student(
        3,
        "Ali Mohamed",
        "ali@gmail.com"
    );

Instructor:

Instructor instructor1 =
    new Instructor(
        1,
        "Ahmed Hassan",
        "ahmed@academy.com"
    );

Category:

Category category1 =
    new Category(
        1,
        "Programming"
    );

Course:

Course course1 =
    new Course(
        1,
        "C# Programming",
        "Learn C# from Beginner to Advanced",
        500,
        1,
        1
    );
🚫 Version 1 - Without SOLID

The first version of this project is intentionally written without applying SOLID principles.

The goal is to create a simple implementation first and understand how the application works.

For example, classes and services may directly depend on each other:

Course
   ↓
Payment
   ↓
Student
   ↓
Enrollment

This makes the code easier to understand at the beginning, but as the project becomes larger, several problems can appear.

⚠️ Problems Without SOLID
1. Too Many Responsibilities

A single class may start handling multiple responsibilities.

For example:

Student
    ↓
Student Data
    ↓
Registration
    ↓
Validation
    ↓
Payment

This can make the class difficult to maintain.

2. Difficult to Add New Features

Suppose the system currently supports:

Visa

Later we want to add:

MasterCard
PayPal
Cash
Bank Transfer

If the payment logic is written directly inside another class, we may need to modify existing code every time.

This makes the system harder to extend.

3. Tight Coupling

A class may directly create and depend on another class.

Example:

PaymentService paymentService =
    new PaymentService();

This creates a strong dependency between the classes.

4. Difficult Testing

When classes are strongly connected, testing one class independently becomes harder.

5. Large Interfaces

If the project later uses interfaces, putting many unrelated methods inside one interface can force classes to implement methods they don't actually need.

🧱 SOLID Version - Future Refactoring

After completing the first version, the same project can be refactored using the five SOLID principles.

The goal is not to change what the application does.

The goal is to improve the internal structure of the code.

🔵 1. SRP - Single Responsibility Principle
Single Responsibility Principle

A class should have one main responsibility.

Problem

A class should not be responsible for:

Student Data
+
Validation
+
Payment
+
Email
+
Registration

all at the same time.

Better Structure

Separate responsibilities:

Student
StudentValidator
PaymentService
EnrollmentService
EmailService

Each class handles a specific responsibility.

🟢 2. OCP - Open/Closed Principle
Open/Closed Principle

Software should be open for extension but closed for modification.

For example, instead of changing the main payment logic every time we add a payment method:

Payment
├── Visa
├── MasterCard
├── PayPal
└── Cash

We can create an abstraction:

public interface IPaymentMethod
{
    void Pay(decimal amount);
}

Then implement different payment methods.

public class VisaPayment : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Payment using Visa");
    }
}

And:

public class PayPalPayment : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Payment using PayPal");
    }
}

Now new payment methods can be added without changing the existing payment service.

🟡 3. LSP - Liskov Substitution Principle
Liskov Substitution Principle

Objects of a child class should be usable wherever the parent class is expected without breaking the application.

For example, if we create a base class:

public class Payment
{
    public virtual void Pay()
    {
    }
}

Then derived classes should correctly follow the expected behavior.

Bad inheritance design can create unexpected behavior.

The future SOLID version should use inheritance only when the relationship makes sense.

🟠 4. ISP - Interface Segregation Principle
Interface Segregation Principle

A class should not be forced to implement methods that it does not need.

Instead of creating one huge interface:

public interface IUser
{
    void Login();
    void Register();
    void CreateCourse();
    void CreateLesson();
    void MakePayment();
    void WriteReview();
}

we can split it into smaller interfaces:

public interface ILogin
{
    void Login();
}
public interface ICourseCreator
{
    void CreateCourse();
}
public interface IPayment
{
    void Pay();
}

This makes the design more flexible.

🔴 5. DIP - Dependency Inversion Principle
Dependency Inversion Principle

High-level classes should depend on abstractions rather than concrete implementations.

Instead of:

PaymentService service =
    new PaymentService();

we can use:

IPaymentMethod paymentMethod;

Then the actual implementation can be provided from outside.

Example:

public class PaymentService
{
    private IPaymentMethod paymentMethod;

    public PaymentService(
        IPaymentMethod paymentMethod)
    {
        this.paymentMethod = paymentMethod;
    }

    public void MakePayment(decimal amount)
    {
        paymentMethod.Pay(amount);
    }
}

This reduces coupling between classes.

📊 SOLID Summary
Principle	Meaning	Main Problem Solved
SRP	Single Responsibility	Too many responsibilities
OCP	Open/Closed	Difficult feature extension
LSP	Liskov Substitution	Incorrect inheritance behavior
ISP	Interface Segregation	Large interfaces
DIP	Dependency Inversion	Tight coupling
🔄 Development Plan

The project is developed in two main stages.

Stage 1 - Basic Version
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

This version focuses on understanding the project itself.

Stage 2 - SOLID Version

After completing the basic version:

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

The functionality remains the same, but the internal code structure becomes more organized.

📁 Suggested Project Structure

The project can be organized like this:

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

The exact folder structure may change during the SOLID refactoring stage.

▶️ How to Run the Project
1. Clone the Repository
git clone https://github.com/EbrahimElghazaly/E-_Learning_Platform.git
2. Open the Project

Open the project using:

Visual Studio

or

Visual Studio Code
3. Build the Project

Using the .NET CLI:

dotnet build
4. Run the Project
dotnet run
🛠️ Technologies Used
C#
.NET
Object-Oriented Programming
Console Application
Git
GitHub
📚 Concepts Practiced

During this project, the following concepts are practiced:

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
🌱 Future Improvements

The project can be expanded in the future by adding:

User Authentication
Login / Register
Password Hashing
Course Search
Course Filtering
Student Dashboard
Instructor Dashboard
Admin Dashboard
Course Progress
Certificates
Payment Integration
Multiple Payment Methods
Database Integration
Entity Framework Core
SQL Server
ASP.NET Core Web API
JWT Authentication
Repository Pattern
Dependency Injection
Unit Testing
Clean Architecture
🗄️ Future Database

The project can later be connected to SQL Server.

Possible database tables:

Students
Instructors
Categories
Courses
Lessons
Enrollments
Payments
Reviews

Relationships between these tables will follow the same design used in the C# classes.

🔌 Future ASP.NET Core API

After completing the Console Application, the same business idea can be converted into an ASP.NET Core Web API.

Possible API endpoints:

GET     /api/students
POST    /api/students

GET     /api/courses
POST    /api/courses
GET     /api/courses/{id}

POST    /api/enrollments

POST    /api/payments

POST    /api/reviews
GET     /api/courses/{id}/reviews
🧪 Testing

Testing can be added later using unit testing frameworks such as:

xUnit
NUnit
MSTest

The SOLID version will make testing individual components easier because the classes will have fewer responsibilities and fewer direct dependencies.

🔀 Git Workflow

The project can be managed using Git.

Initialize Repository
git init
Add Files
git add .
Create Commit
git commit -m "Initial commit"
Rename Branch
git branch -M main
Add GitHub Remote
git remote add origin https://github.com/EbrahimElghazaly/E-_Learning_Platform.git
Push Project
git push -u origin main
🚫 .gitignore

Visual Studio generates temporary files that should not be uploaded to GitHub.

A .gitignore file should contain:

.vs/
bin/
obj/
*.user
*.suo
*.userosscache
*.sln.docstates

This prevents unnecessary Visual Studio files from being committed.

📌 Important Note

This project is intentionally divided into two versions.

Version 1
Basic C# Implementation
+
OOP
+
No SOLID

The purpose is to understand how the application works using a simple implementation.

Version 2
Same Project
+
Refactoring
+
SOLID Principles

The second version will demonstrate how the same project can be improved by applying:

S → Single Responsibility Principle
O → Open/Closed Principle
L → Liskov Substitution Principle
I → Interface Segregation Principle
D → Dependency Inversion Principle
🎓 Learning Outcome

By completing this project, the developer will gain practical experience in:

Building a C# application from scratch.
Modeling real-world entities using classes.
Creating relationships between objects.
Understanding Object-Oriented Programming.
Identifying problems in tightly coupled code.
Understanding why software design principles are important.
Refactoring an existing project.
Applying SOLID principles to an existing application.
Preparing a project for future database and API integration.
👨‍💻 Author

Ibrahim Mohamed Elghazaly

Computer Science Student
Full Stack .NET Developer

📫 Project

E-Learning Platform

Built with:

C#
.NET
OOP
Git
GitHub
⭐ Future Vision

The final goal is to evolve this simple Console Application into a complete learning platform:

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
⭐ If You Like This Project

Feel free to explore the source code, learn from it, and improve it.

More features and improvements can be added as the project evolves.
```text
E-Learning Platform
│
├── Student
├── Instructor
├── Category
├── Course
├── Lesson
├── Enrollment
├── Payment
└── Review
---


---ا
ا
