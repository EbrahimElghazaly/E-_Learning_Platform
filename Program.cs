using System;
using System.Collections.Generic;

namespace ELearningPlatform
{
    // I - INTERFACE SEGREGATION PRINCIPLE

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


    // D - DEPENDENCY INVERSION PRINCIPLE

    public interface IEnrollment
    {
        string StudentName { get; }
        string CourseTitle { get; }
    }


    // Instructor
    public class Instructor
    {
        public int InstructorID;
        public string Name;
        public string Email;
        public string Specialization;
        public string Bio;

        public Instructor(
            int instructorID,
            string name,
            string email,
            string specialization,
            string bio)
        {
            InstructorID = instructorID;
            Name = name;
            Email = email;
            Specialization = specialization;
            Bio = bio;
        }
    }


    // Student

    public class Student
    {
        public int StudentID;
        public string Name;
        public string Email;

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


    // Category

    public class Category
    {
        public int CategoryID;
        public string Name;

        public Category(
            int categoryID,
            string name)
        {
            CategoryID = categoryID;
            Name = name;
        }
    }


    // Lesson

    public class Lesson
    {
        public int LessonID;
        public string Title;
        public string Duration;
        public int OrderNumber;

        public Lesson(
            int lessonID,
            string title,
            string duration,
            int orderNumber)
        {
            LessonID = lessonID;
            Title = title;
            Duration = duration;
            OrderNumber = orderNumber;
        }
    }


    // Course

    public class Course : ILessonManagement
    {
        public int CourseID;
        public string Title;
        public string Description;
        public double Price;
        public string Duration;
        public string Level;
        public string Language;
        public Instructor Instructor;
        public Category Category;
        public List<Lesson> Lessons;

        public Course(
            int courseID,
            string title,
            string description,
            double price,
            string duration,
            string level,
            string language,
            Instructor instructor,
            Category category)
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

        // I - ILessonManagement
        public void AddLesson(Lesson lesson)
        {
            Lessons.Add(lesson);
        }

        // L - Liskov Substitution
        public virtual double GetFinalPrice()
        {
            return Price;
        }
    }


    // LSP

    public class FreeCourse : Course
    {
        public FreeCourse(
            int courseID,
            string title,
            string description,
            string duration,
            string level,
            string language,
            Instructor instructor,
            Category category)
            : base(
                courseID,
                title,
                description,
                0,
                duration,
                level,
                language,
                instructor,
                category)
        {
        }

        public override double GetFinalPrice()
        {
            return 0;
        }
    }


    // LSP

    public class CertificateCourse : Course
    {
        public const double CertificateFee = 100;

        public CertificateCourse(
            int courseID,
            string title,
            string description,
            double price,
            string duration,
            string level,
            string language,
            Instructor instructor,
            Category category)
            : base(
                courseID,
                title,
                description,
                price,
                duration,
                level,
                language,
                instructor,
                category)
        {
        }

        public override double GetFinalPrice()
        {
            return Price + CertificateFee;
        }
    }

    // O - OPEN / CLOSED PRINCIPLE

    public class DiscountCourse : Course
    {
        public double DiscountPercentage;

        public DiscountCourse(
            int courseID,
            string title,
            string description,
            double price,
            double discountPercentage,
            string duration,
            string level,
            string language,
            Instructor instructor,
            Category category)
            : base(
                courseID,
                title,
                description,
                price,
                duration,
                level,
                language,
                instructor,
                category)
        {
            DiscountPercentage = discountPercentage;
        }

        public override double GetFinalPrice()
        {
            return Price - (Price * DiscountPercentage / 100);
        }
    }

    // Enrollment

    public class Enrollment : IEnrollment
    {
        public int EnrollmentID;
        public Student Student;
        public Course Course;
        public DateTime EnrollDate;
        public string Status;
        public double Amount;
        public string PaymentMethod;

        public Enrollment(
            int enrollmentID,
            Student student,
            Course course,
            DateTime enrollDate,
            string status,
            double amount,
            string paymentMethod)
        {
            EnrollmentID = enrollmentID;
            Student = student;
            Course = course;
            EnrollDate = enrollDate;
            Status = status;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }

        // D - Implementation of abstraction
        public string StudentName
        {
            get { return Student.Name; }
        }

        public string CourseTitle
        {
            get { return Course.Title; }
        }
    }


    // Payment
    // D - DEPENDENCY INVERSION

    public class Payment
    {
        public int PaymentID;

        public IEnrollment Enrollment;

        public double Amount;
        public string PaymentMethod;
        public DateTime PaymentDate;
        public string Status;

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


    // Review

    public class Review
    {
        public int ReviewID;
        public Student Student;
        public Course Course;
        public int Rating;
        public string Comment;
        public DateTime ReviewDate;

        public Review(
            int reviewID,
            Student student,
            Course course,
            int rating,
            string comment,
            DateTime reviewDate)
        {
            ReviewID = reviewID;
            Student = student;
            Course = course;
            Rating = rating;
            Comment = comment;
            ReviewDate = reviewDate;
        }
    }

    // S - SINGLE RESPONSIBILITY PRINCIPLE

    public class ConsolePrinter :
        ICourseDisplay,
        IEnrollmentDisplay,
        IPaymentDisplay,
        IReviewDisplay
    {

        // Student

        public void ShowStudent(Student student)
        {
            Console.WriteLine("Student ID: " + student.StudentID);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Email: " + student.Email);
        }


        // Instructor

        public void ShowInstructor(Instructor instructor)
        {
            Console.WriteLine("Instructor ID: " + instructor.InstructorID);
            Console.WriteLine("Name: " + instructor.Name);
            Console.WriteLine("Email: " + instructor.Email);
            Console.WriteLine("Specialization: " + instructor.Specialization);
            Console.WriteLine("Bio: " + instructor.Bio);
        }


        // I - ICourseDisplay

        public void ShowCourse(Course course)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Course ID: " + course.CourseID);
            Console.WriteLine("Title: " + course.Title);
            Console.WriteLine("Description: " + course.Description);
            Console.WriteLine("Price: " + course.Price);
            Console.WriteLine("Final Price: " + course.GetFinalPrice());
            Console.WriteLine("Duration: " + course.Duration);
            Console.WriteLine("Level: " + course.Level);
            Console.WriteLine("Language: " + course.Language);
            Console.WriteLine("Instructor: " + course.Instructor.Name);
            Console.WriteLine("Category: " + course.Category.Name);

            Console.WriteLine("Lessons:");

            foreach (Lesson lesson in course.Lessons)
            {
                Console.WriteLine(
                    lesson.LessonID + " - " +
                    lesson.Title + " - " +
                    lesson.Duration
                );
            }

            Console.WriteLine("====================================");
        }


        // I - IEnrollmentDisplay

        public void ShowEnrollment(Enrollment enrollment)
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


        // I - IPaymentDisplay

        public void ShowPayment(Payment payment)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Payment ID: " + payment.PaymentID);
            Console.WriteLine("Student: " + payment.Enrollment.StudentName);
            Console.WriteLine("Course: " + payment.Enrollment.CourseTitle);
            Console.WriteLine("Amount: " + payment.Amount);
            Console.WriteLine("Payment Method: " + payment.PaymentMethod);
            Console.WriteLine("Payment Date: " + payment.PaymentDate);
            Console.WriteLine("Status: " + payment.Status);
            Console.WriteLine("====================================");
        }


        // I - IReviewDisplay

        public void ShowReview(Review review)
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


    internal class Program
    {
        static void Main(string[] args)
        {
            // Categories

            Category category1 =
                new Category(1, "Programming");

            Category category2 =
                new Category(2, "Database");

            Category category3 =
                new Category(3, "Front-End");


            // Instructors

            Instructor instructor1 =
                new Instructor(
                    1,
                    "Ahmed Mohamed",
                    "ahmed@gmail.com",
                    "C# and .NET",
                    "C# and .NET Instructor"
                );

            Instructor instructor2 =
                new Instructor(
                    2,
                    "Mohamed Ali",
                    "mohamed@gmail.com",
                    "Database",
                    "SQL Server Instructor"
                );

            Instructor instructor3 =
                new Instructor(
                    3,
                    "Sara Hassan",
                    "sara@gmail.com",
                    "Front-End",
                    "Front-End Instructor"
                );

            // Students

            Student student1 =
                new Student(
                    1,
                    "Ibrahim Elghazaly",
                    "ibrahim@gmail.com"
                );

            Student student2 =
                new Student(
                    2,
                    "Omar Ahmed",
                    "omar@gmail.com"
                );

            Student student3 =
                new Student(
                    3,
                    "Ali Mohamed",
                    "ali@gmail.com"
                );


            // Courses

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

            Course course2 =
                new Course(
                    2,
                    "SQL Server",
                    "Learn SQL Server and Database",
                    120,
                    "30 Hours",
                    "Intermediate",
                    "English",
                    instructor2,
                    category2
                );

            Course course3 =
                new Course(
                    3,
                    "Front-End Development",
                    "Learn HTML CSS and JavaScript",
                    180,
                    "50 Hours",
                    "Beginner",
                    "English",
                    instructor3,
                    category3
                );


            // Lessons

            Lesson lesson1 =
                new Lesson(
                    1,
                    "Introduction to C#",
                    "20 Minutes",
                    1
                );

            Lesson lesson2 =
                new Lesson(
                    2,
                    "Variables and Data Types",
                    "30 Minutes",
                    2
                );

            Lesson lesson3 =
                new Lesson(
                    3,
                    "Classes and Objects",
                    "40 Minutes",
                    3
                );

            Lesson lesson4 =
                new Lesson(
                    4,
                    "Introduction to SQL",
                    "25 Minutes",
                    1
                );

            Lesson lesson5 =
                new Lesson(
                    5,
                    "SELECT Statement",
                    "30 Minutes",
                    2
                );

            // I - ILessonManagement

            course1.AddLesson(lesson1);
            course1.AddLesson(lesson2);
            course1.AddLesson(lesson3);

            course2.AddLesson(lesson4);
            course2.AddLesson(lesson5);


            // L - Create different types of Courses

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

            // LSP DEMONSTRATION

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


            // Enrollments

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

            Enrollment enrollment2 =
                new Enrollment(
                    2,
                    student1,
                    course2,
                    DateTime.Now,
                    "Active",
                    120,
                    "Cash"
                );

            Enrollment enrollment3 =
                new Enrollment(
                    3,
                    student2,
                    course1,
                    DateTime.Now,
                    "Active",
                    150,
                    "Credit Card"
                );

            Enrollment enrollment4 =
                new Enrollment(
                    4,
                    student3,
                    course3,
                    DateTime.Now,
                    "Active",
                    180,
                    "PayPal"
                );


            // D - Payment depends on IEnrollment

            Payment payment1 =
                new Payment(
                    1,
                    enrollment1,
                    150,
                    "Credit Card",
                    DateTime.Now,
                    "Completed"
                );

            Payment payment2 =
                new Payment(
                    2,
                    enrollment2,
                    120,
                    "Cash",
                    DateTime.Now,
                    "Completed"
                );

            Payment payment3 =
                new Payment(
                    3,
                    enrollment3,
                    150,
                    "Credit Card",
                    DateTime.Now,
                    "Completed"
                );

            Payment payment4 =
                new Payment(
                    4,
                    enrollment4,
                    180,
                    "PayPal",
                    DateTime.Now,
                    "Completed"
                );

            // Reviews

            Review review1 =
                new Review(
                    1,
                    student1,
                    course1,
                    5,
                    "Very good course",
                    DateTime.Now
                );

            Review review2 =
                new Review(
                    2,
                    student2,
                    course1,
                    4,
                    "Good course",
                    DateTime.Now
                );

            Review review3 =
                new Review(
                    3,
                    student1,
                    course2,
                    5,
                    "Very useful SQL course",
                    DateTime.Now
                );


            // Console Printer
            // S - Single Responsibility

            ConsolePrinter printer =
                new ConsolePrinter();


            // Display Students

            Console.WriteLine("========== STUDENTS ==========");

            printer.ShowStudent(student1);
            Console.WriteLine();

            printer.ShowStudent(student2);
            Console.WriteLine();

            printer.ShowStudent(student3);
            Console.WriteLine();


            // Display Instructors

            Console.WriteLine("========== INSTRUCTORS ==========");

            printer.ShowInstructor(instructor1);
            Console.WriteLine();

            printer.ShowInstructor(instructor2);
            Console.WriteLine();

            printer.ShowInstructor(instructor3);
            Console.WriteLine();


            // Display Courses

            Console.WriteLine("========== COURSES ==========");

            printer.ShowCourse(course1);
            Console.WriteLine();

            printer.ShowCourse(course2);
            Console.WriteLine();

            printer.ShowCourse(course3);
            Console.WriteLine();


            // LSP DEMO

            Console.WriteLine("========== LSP DEMO ==========");

            double totalRevenue = 0;

            foreach (Course course in allCourses)
            {
                printer.ShowCourse(course);

                Console.WriteLine(
                    "Final Price To Pay: " +
                    course.GetFinalPrice()
                );

                Console.WriteLine();

                totalRevenue += course.GetFinalPrice();
            }

            Console.WriteLine(
                "Total Revenue From Courses: " +
                totalRevenue
            );


            Console.WriteLine();


            // Display Enrollments

            Console.WriteLine("========== ENROLLMENTS ==========");

            printer.ShowEnrollment(enrollment1);
            Console.WriteLine();

            printer.ShowEnrollment(enrollment2);
            Console.WriteLine();

            printer.ShowEnrollment(enrollment3);
            Console.WriteLine();

            printer.ShowEnrollment(enrollment4);
            Console.WriteLine();


            // Display Payments

            Console.WriteLine("========== PAYMENTS ==========");

            printer.ShowPayment(payment1);
            Console.WriteLine();

            printer.ShowPayment(payment2);
            Console.WriteLine();

            printer.ShowPayment(payment3);
            Console.WriteLine();

            printer.ShowPayment(payment4);
            Console.WriteLine();


            // Display Reviews

            Console.WriteLine("========== REVIEWS ==========");

            printer.ShowReview(review1);
            Console.WriteLine();

            printer.ShowReview(review2);
            Console.WriteLine();

            printer.ShowReview(review3);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
