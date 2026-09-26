using System;
using System.Collections.Generic;

namespace ELearningPlatform
{
    // ==========================================
    // 1. MODELS (بيانات فقط - بدون أي طباعة)
    // ==========================================

    public class Instructor
    {
        public int InstructorID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Specialization { get; set; }
        public string Bio { get; set; }

        public Instructor(int instructorID, string name, string email, string specialization, string bio)
        {
            InstructorID = instructorID;
            Name = name;
            Email = email;
            Specialization = specialization;
            Bio = bio;
        }
    }

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

    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public Category(int categoryID, string name)
        {
            CategoryID = categoryID;
            Name = name;
        }
    }

    public class Lesson
    {
        public int LessonID { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public int OrderNumber { get; set; }

        public Lesson(int lessonID, string title, string duration, int orderNumber)
        {
            LessonID = lessonID;
            Title = title;
            Duration = duration;
            OrderNumber = orderNumber;
        }
    }

    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Duration { get; set; }
        public string Level { get; set; }
        public string Language { get; set; }
        public Instructor Instructor { get; set; }
        public Category Category { get; set; }
        public List<Lesson> Lessons { get; set; }

        public Course(int courseID, string title, string description, double price, string duration, string level, string language, Instructor instructor, Category category)
        {
            CourseID = courseID;
            Title = title;
            Description = description;
            Price = price;
            Duration = duration;
            Level = level;
            Language = language;
            Instructor = instructor;
            Category = category;
            Lessons = new List<Lesson>();
        }

        public void AddLesson(Lesson lesson)
        {
            Lessons.Add(lesson);
        }
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollDate { get; set; }
        public string Status { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }

        public Enrollment(int enrollmentID, Student student, Course course, DateTime enrollDate, string status, double amount, string paymentMethod)
        {
            EnrollmentID = enrollmentID;
            Student = student;
            Course = course;
            EnrollDate = enrollDate;
            Status = status;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }
    }

    public class Payment
    {
        public int PaymentID { get; set; }
        public Enrollment Enrollment { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }

        public Payment(int paymentID, Enrollment enrollment, double amount, string paymentMethod, DateTime paymentDate, string status)
        {
            PaymentID = paymentID;
            Enrollment = enrollment;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
            Status = status;
        }
    }

    public class Review
    {
        public int ReviewID { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public Review(int reviewID, Student student, Course course, int rating, string comment, DateTime reviewDate)
        {
            ReviewID = reviewID;
            Student = student;
            Course = course;
            Rating = rating;
            Comment = comment;
            ReviewDate = reviewDate;
        }
    }

    // ==========================================
    // 2. SERVICES (مسؤولة عن الطباعة والعرض فقط)
    // ==========================================

    public class ConsolePrinter
    {
        public void PrintStudent(Student student)
        {
            Console.WriteLine("Student ID: " + student.StudentID);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Email: " + student.Email);
        }

        public void PrintInstructor(Instructor instructor)
        {
            Console.WriteLine("Instructor ID: " + instructor.InstructorID);
            Console.WriteLine("Name: " + instructor.Name);
            Console.WriteLine("Email: " + instructor.Email);
            Console.WriteLine("Specialization: " + instructor.Specialization);
            Console.WriteLine("Bio: " + instructor.Bio);
        }

        public void PrintCourse(Course course)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Course ID: " + course.CourseID);
            Console.WriteLine("Title: " + course.Title);
            Console.WriteLine("Description: " + course.Description);
            Console.WriteLine("Price: " + course.Price);
            Console.WriteLine("Duration: " + course.Duration);
            Console.WriteLine("Level: " + course.Level);
            Console.WriteLine("Language: " + course.Language);
            Console.WriteLine("Instructor: " + course.Instructor.Name);
            Console.WriteLine("Category: " + course.Category.Name);
            Console.WriteLine("Lessons:");

            foreach (Lesson lesson in course.Lessons)
            {
                Console.WriteLine(lesson.LessonID + " - " + lesson.Title + " - " + lesson.Duration);
            }

            Console.WriteLine("====================================");
        }

        public void PrintEnrollment(Enrollment enrollment)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Enrollment ID: " + enrollment.EnrollmentID);
            Console.WriteLine("Student: " + enrollment.Student.Name);
            Console.WriteLine("Course: " + enrollment.Course.Title);
            Console.WriteLine("Enroll Date: " + enrollment.EnrollDate);
            Console.WriteLine("Status: " + enrollment.Status);
            Console.WriteLine("Amount: " + enrollment.Amount);
            Console.WriteLine("Payment Method: " + enrollment.PaymentMethod);
            Console.WriteLine("====================================");
        }

        public void PrintPayment(Payment payment)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Payment ID: " + payment.PaymentID);
            Console.WriteLine("Student: " + payment.Enrollment.Student.Name);
            Console.WriteLine("Course: " + payment.Enrollment.Course.Title);
            Console.WriteLine("Amount: " + payment.Amount);
            Console.WriteLine("Payment Method: " + payment.PaymentMethod);
            Console.WriteLine("Payment Date: " + payment.PaymentDate);
            Console.WriteLine("Status: " + payment.Status);
            Console.WriteLine("====================================");
        }

        public void PrintReview(Review review)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Review ID: " + review.ReviewID);
            Console.WriteLine("Student: " + review.Student.Name);
            Console.WriteLine("Course: " + review.Course.Title);
            Console.WriteLine("Rating: " + review.Rating);
            Console.WriteLine("Comment: " + review.Comment);
            Console.WriteLine("Review Date: " + review.ReviewDate);
            Console.WriteLine("====================================");
        }
    }

    // ==========================================
    // 3. PROGRAM (لتشغيل التطبيق)
    // ==========================================

    internal class Program
    {
        static void Main(string[] args)
        {
            ConsolePrinter printer = new ConsolePrinter();

            // Categories
            Category category1 = new Category(1, "Programming");
            Category category2 = new Category(2, "Database");
            Category category3 = new Category(3, "Front-End");

            // Instructors
            Instructor instructor1 = new Instructor(1, "Ahmed Mohamed", "ahmed@gmail.com", "C# and .NET", "C# and .NET Instructor");
            Instructor instructor2 = new Instructor(2, "Mohamed Ali", "mohamed@gmail.com", "Database", "SQL Server Instructor");
            Instructor instructor3 = new Instructor(3, "Sara Hassan", "sara@gmail.com", "Front-End", "Front-End Instructor");

            // Students
            Student student1 = new Student(1, "Ibrahim Elghazaly", "ibrahim@gmail.com");
            Student student2 = new Student(2, "Omar Ahmed", "omar@gmail.com");
            Student student3 = new Student(3, "Ali Mohamed", "ali@gmail.com");

            // Courses
            Course course1 = new Course(1, "C# Programming", "Learn C# Programming", 150, "40 Hours", "Beginner", "English", instructor1, category1);
            Course course2 = new Course(2, "SQL Server", "Learn SQL Server and Database", 120, "30 Hours", "Intermediate", "English", instructor2, category2);
            Course course3 = new Course(3, "Front-End Development", "Learn HTML CSS and JavaScript", 180, "50 Hours", "Beginner", "English", instructor3, category3);

            // Lessons
            Lesson lesson1 = new Lesson(1, "Introduction to C#", "20 Minutes", 1);
            Lesson lesson2 = new Lesson(2, "Variables and Data Types", "30 Minutes", 2);
            Lesson lesson3 = new Lesson(3, "Classes and Objects", "40 Minutes", 3);
            Lesson lesson4 = new Lesson(4, "Introduction to SQL", "25 Minutes", 1);
            Lesson lesson5 = new Lesson(5, "SELECT Statement", "30 Minutes", 2);

            course1.AddLesson(lesson1);
            course1.AddLesson(lesson2);
            course1.AddLesson(lesson3);
            course2.AddLesson(lesson4);
            course2.AddLesson(lesson5);

            // Enrollments
            Enrollment enrollment1 = new Enrollment(1, student1, course1, DateTime.Now, "Active", 150, "Credit Card");
            Enrollment enrollment2 = new Enrollment(2, student1, course2, DateTime.Now, "Active", 120, "Cash");
            Enrollment enrollment3 = new Enrollment(3, student2, course1, DateTime.Now, "Active", 150, "Credit Card");
            Enrollment enrollment4 = new Enrollment(4, student3, course3, DateTime.Now, "Active", 180, "PayPal");

            // Payments
            Payment payment1 = new Payment(1, enrollment1, 150, "Credit Card", DateTime.Now, "Completed");
            Payment payment2 = new Payment(2, enrollment2, 120, "Cash", DateTime.Now, "Completed");
            Payment payment3 = new Payment(3, enrollment3, 150, "Credit Card", DateTime.Now, "Completed");
            Payment payment4 = new Payment(4, enrollment4, 180, "PayPal", DateTime.Now, "Completed");

            // Reviews
            Review review1 = new Review(1, student1, course1, 5, "Very good course", DateTime.Now);
            Review review2 = new Review(2, student2, course1, 4, "Good course", DateTime.Now);
            Review review3 = new Review(3, student1, course2, 5, "Very useful SQL course", DateTime.Now);

            // Display
            Console.WriteLine("========== STUDENTS ==========");
            printer.PrintStudent(student1);
            Console.WriteLine();
            printer.PrintStudent(student2);
            Console.WriteLine();
            printer.PrintStudent(student3);
            Console.WriteLine();

            Console.WriteLine("========== INSTRUCTORS ==========");
            printer.PrintInstructor(instructor1);
            Console.WriteLine();
            printer.PrintInstructor(instructor2);
            Console.WriteLine();
            printer.PrintInstructor(instructor3);
            Console.WriteLine();

            Console.WriteLine("========== COURSES ==========");
            printer.PrintCourse(course1);
            Console.WriteLine();
            printer.PrintCourse(course2);
            Console.WriteLine();
            printer.PrintCourse(course3);
            Console.WriteLine();

            Console.WriteLine("========== ENROLLMENTS ==========");
            printer.PrintEnrollment(enrollment1);
            Console.WriteLine();
            printer.PrintEnrollment(enrollment2);
            Console.WriteLine();
            printer.PrintEnrollment(enrollment3);
            Console.WriteLine();
            printer.PrintEnrollment(enrollment4);
            Console.WriteLine();

            Console.WriteLine("========== PAYMENTS ==========");
            printer.PrintPayment(payment1);
            Console.WriteLine();
            printer.PrintPayment(payment2);
            Console.WriteLine();
            printer.PrintPayment(payment3);
            Console.WriteLine();
            printer.PrintPayment(payment4);
            Console.WriteLine();

            Console.WriteLine("========== REVIEWS ==========");
            printer.PrintReview(review1);
            Console.WriteLine();
            printer.PrintReview(review2);
            Console.WriteLine();
            printer.PrintReview(review3);

            Console.ReadKey();
        }
    }
}
