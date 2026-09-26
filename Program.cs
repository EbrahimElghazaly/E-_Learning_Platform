using System;
using System.Collections.Generic;

namespace ELearningPlatform
{


    public class Instructor
    {
        public int InstructorID;
        public string Name;
        public string Email;
        public string Specialization;
        public string Bio;

        public Instructor(int instructorID, string name, string email, string specialization, string bio)
        {
            InstructorID = instructorID;
            Name = name;
            Email = email;
            Specialization = specialization;
            Bio = bio;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Instructor ID: " + InstructorID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Specialization: " + Specialization);
            Console.WriteLine("Bio: " + Bio);
        }
    }


    public class Student
    {
        public int StudentID;
        public string Name;
        public string Email;

        public Student(int studentID, string name, string email)
        {
            StudentID = studentID;
            Name = name;
            Email = email;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
        }
    }


    public class Category
    {
        public int CategoryID;
        public string Name;

        public Category(int categoryID, string name)
        {
            CategoryID = categoryID;
            Name = name;
        }
    }


    public class Course
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


        public virtual double GetFinalPrice()
        {
            return Price;
        }

        public virtual void ShowCourse()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Course ID: " + CourseID);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Duration: " + Duration);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Language: " + Language);
            Console.WriteLine("Instructor: " + Instructor.Name);
            Console.WriteLine("Category: " + Category.Name);
            Console.WriteLine("Lessons:");

            foreach (Lesson lesson in Lessons)
            {
                Console.WriteLine(
                    lesson.LessonID + " - " +
                    lesson.Title + " - " +
                    lesson.Duration
                );
            }

            Console.WriteLine("====================================");
        }
    }


    public class FreeCourse : Course
    {
        public FreeCourse(int courseID, string title, string description, string duration,
                           string level, string language, Instructor instructor, Category category)
            : base(courseID, title, description, 0, duration, level, language, instructor, category)
        {
        }


        public override double GetFinalPrice()
        {
            return 0;
        }

        public override void ShowCourse()
        {
            base.ShowCourse();
            Console.WriteLine("This course is FREE. Final Price: 0");
            Console.WriteLine("====================================");
        }
    }


    public class CertificateCourse : Course
    {
        public const double CertificateFee = 100;

        public CertificateCourse(int courseID, string title, string description, double price,
                                  string duration, string level, string language,
                                  Instructor instructor, Category category)
            : base(courseID, title, description, price, duration, level, language, instructor, category)
        {
        }


        public override double GetFinalPrice()
        {
            return Price + CertificateFee;
        }

        public override void ShowCourse()
        {
            base.ShowCourse();
            Console.WriteLine("Includes Certificate Fee: " + CertificateFee);
            Console.WriteLine("Final Price (Course + Certificate): " + GetFinalPrice());
            Console.WriteLine("====================================");
        }
    }


    public class Lesson
    {
        public int LessonID;
        public string Title;
        public string Duration;
        public int OrderNumber;

        public Lesson(int lessonID, string title, string duration, int orderNumber)
        {
            LessonID = lessonID;
            Title = title;
            Duration = duration;
            OrderNumber = orderNumber;
        }
    }


    public class Enrollment
    {
        public int EnrollmentID;
        public Student Student;
        public Course Course;
        public DateTime EnrollDate;
        public string Status;
        public double Amount;
        public string PaymentMethod;

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

        public void ShowEnrollment()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Enrollment ID: " + EnrollmentID);
            Console.WriteLine("Student: " + Student.Name);
            Console.WriteLine("Course: " + Course.Title);
            Console.WriteLine("Enroll Date: " + EnrollDate);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Amount: " + Amount);
            Console.WriteLine("Payment Method: " + PaymentMethod);
            Console.WriteLine("====================================");
        }
    }


    public class Payment
    {
        public int PaymentID;
        public Enrollment Enrollment;
        public double Amount;
        public string PaymentMethod;
        public DateTime PaymentDate;
        public string Status;
        public Payment(int paymentID, Enrollment enrollment, double amount, string paymentMethod, DateTime paymentDate, string status)
        {
            PaymentID = paymentID;
            Enrollment = enrollment;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
            Status = status;
        }

        public void ShowPayment()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Payment ID: " + PaymentID);
            Console.WriteLine("Student: " + Enrollment.Student.Name);
            Console.WriteLine("Course: " + Enrollment.Course.Title);
            Console.WriteLine("Amount: " + Amount);
            Console.WriteLine("Payment Method: " + PaymentMethod);
            Console.WriteLine("Payment Date: " + PaymentDate);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("====================================");
        }
    }


    public class Review
    {
        public int ReviewID;
        public Student Student;
        public Course Course;
        public int Rating;
        public string Comment;
        public DateTime ReviewDate;

        public Review(int reviewID, Student student, Course course, int rating, string comment, DateTime reviewDate)
        {
            ReviewID = reviewID;
            Student = student;
            Course = course;
            Rating = rating;
            Comment = comment;
            ReviewDate = reviewDate;
        }

        public void ShowReview()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Review ID: " + ReviewID);
            Console.WriteLine("Student: " + Student.Name);
            Console.WriteLine("Course: " + Course.Title);
            Console.WriteLine("Rating: " + Rating);
            Console.WriteLine("Comment: " + Comment);
            Console.WriteLine("Review Date: " + ReviewDate);
            Console.WriteLine("====================================");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {


            Category category1 = new Category(1, "Programming");

            Category category2 = new Category(2, "Database");

            Category category3 = new Category(3, "Front-End");




            Instructor instructor1 = new Instructor(1, "Ahmed Mohamed", "ahmed@gmail.com", "C# and .NET", "C# and .NET Instructor");

            Instructor instructor2 = new Instructor(2, "Mohamed Ali", "mohamed@gmail.com", "Database", "SQL Server Instructor");

            Instructor instructor3 = new Instructor(3, "Sara Hassan", "sara@gmail.com", "Front-End", "Front-End Instructor");



            Student student1 = new Student(1, "Ibrahim Elghazaly", "ibrahim@gmail.com");

            Student student2 = new Student(2, "Omar Ahmed", "omar@gmail.com");

            Student student3 = new Student(3, "Ali Mohamed", "ali@gmail.com");



            Course course1 = new Course(1, "C# Programming", "Learn C# Programming", 150, "40 Hours", "Beginner", "English", instructor1, category1);

            Course course2 = new Course(2, "SQL Server", "Learn SQL Server and Database", 120, "30 Hours", "Intermediate", "English", instructor2, category2);

            Course course3 = new Course(3, "Front-End Development", "Learn HTML CSS and JavaScript", 180, "50 Hours", "Beginner", "English", instructor3, category3);



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



            Enrollment enrollment1 = new Enrollment(1, student1, course1, DateTime.Now, "Active", 150, "Credit Card");

            Enrollment enrollment2 = new Enrollment(2, student1, course2, DateTime.Now, "Active", 120, "Cash");

            Enrollment enrollment3 = new Enrollment(3, student2, course1, DateTime.Now, "Active", 150, "Credit Card");

            Enrollment enrollment4 = new Enrollment(4, student3, course3, DateTime.Now, "Active", 180, "PayPal");



            Payment payment1 = new Payment(1, enrollment1, 150, "Credit Card", DateTime.Now, "Completed");

            Payment payment2 = new Payment(2, enrollment2, 120, "Cash", DateTime.Now, "Completed");

            Payment payment3 = new Payment(3, enrollment3, 150, "Credit Card", DateTime.Now, "Completed");

            Payment payment4 = new Payment(4, enrollment4, 180, "PayPal", DateTime.Now, "Completed");



            Review review1 = new Review(1, student1, course1, 5, "Very good course", DateTime.Now);

            Review review2 = new Review(2, student2, course1, 4, "Good course", DateTime.Now);

            Review review3 = new Review(3, student1, course2, 5, "Very useful SQL course", DateTime.Now);



            Console.WriteLine("========== STUDENTS ==========");

            student1.ShowInfo();
            Console.WriteLine();
            student2.ShowInfo();
            Console.WriteLine();
            student3.ShowInfo();
            Console.WriteLine();

            Console.WriteLine("========== INSTRUCTORS ==========");

            instructor1.ShowInfo();
            Console.WriteLine();
            instructor2.ShowInfo();
            Console.WriteLine();
            instructor3.ShowInfo();
            Console.WriteLine();

            Console.WriteLine("========== COURSES ==========");

            course1.ShowCourse();
            Console.WriteLine();
            course2.ShowCourse();
            Console.WriteLine();
            course3.ShowCourse();
            Console.WriteLine();

            Console.WriteLine("========== LSP DEMO (Ahmed Khalifa) ==========");

            FreeCourse freeCourse = new FreeCourse(
                4, "Intro to Git & GitHub", "A free introductory course",
                "5 Hours", "Beginner", "English", instructor1, category1);

            CertificateCourse certificateCourse = new CertificateCourse(
                5, "Advanced ASP.NET Core", "Deep dive with a certificate", 300,
                "60 Hours", "Advanced", "English", instructor2, category2);

            List<Course> allCourses = new List<Course> { course1, freeCourse, certificateCourse };

            double totalRevenue = 0;

            foreach (Course course in allCourses)
            {
.
                course.ShowCourse();
                Console.WriteLine("Final Price To Pay: " + course.GetFinalPrice());
                Console.WriteLine();
                totalRevenue += course.GetFinalPrice();
            }

            Console.WriteLine("Total Revenue From These 3 Courses: " + totalRevenue);
            Console.WriteLine("===============================================");
            Console.WriteLine();

            Console.WriteLine("========== ENROLLMENTS ==========");

            enrollment1.ShowEnrollment();
            Console.WriteLine();
            enrollment2.ShowEnrollment();
            Console.WriteLine();
            enrollment3.ShowEnrollment();
            Console.WriteLine();
            enrollment4.ShowEnrollment();
            Console.WriteLine();

            Console.WriteLine("========== PAYMENTS ==========");

            payment1.ShowPayment();
            Console.WriteLine();
            payment2.ShowPayment();
            Console.WriteLine();
            payment3.ShowPayment();
            Console.WriteLine();
            payment4.ShowPayment();
            Console.WriteLine();

            Console.WriteLine("========== REVIEWS ==========");

            review1.ShowReview();
            Console.WriteLine();
            review2.ShowReview();
            Console.WriteLine();
            review3.ShowReview();






            Console.ReadKey();
        }
    }
}