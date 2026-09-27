📌 نظرة عامة على المشروع
منصة تعليمية إلكترونية مبنية بلغة C# و .NET باستخدام Console Application، مع تطبيق مفاهيم Object-Oriented Programming (OOP) و مبادئ SOLID الخمسة بشكل عملي.

هذا المشروع يوضح رحلة تطوير كاملة:

النسخة الأولى: كود أساسي بدون SOLID (لإظهار المشاكل)

النسخة النهائية: إعادة هيكلة كاملة بتطبيق SOLID

👨‍💻 فريق العمل
الدور	الاسم	المسؤولية
🏗️ صاحب الفكرة والكود الأساسي	Ibrahim Mohamed Elghazaly	بناء الكود الأساسي بدون SOLID
🔵 SRP	Mohamed Saeed	مبدأ المسؤولية الواحدة
🟢 OCP	Ziad Elfeky	مبدأ الفتح/الإغلاق
🟡 LSP	Ahmed Khalifa	مبدأ استبدال ليزكوف
🟠 Inheritance	Ghofran Mohamed	مبدأ الوراثة
🔴 DIP	Youssef Hegazy	مبدأ انعكاس الاعتماد
🟣 ISP	(مُطبَّق في الكود)	مبدأ فصل الواجهات
🎯 أهداف المشروع
✅ التدرب على C# و .NET

✅ فهم OOP بعمق

✅ نمذجة كيانات واقعية

✅ فهم العلاقات بين الكائنات

✅ تطبيق مبادئ SOLID الخمسة

✅ إعادة هيكلة كود موجود (Refactoring)

✅ تجهيز المشروع لـ API وقاعدة بيانات مستقبلاً

🏗️ هيكل المشروع
text
E-Learning-Platform
│
├── E-Learning-Platform.sln
│
├── Models
│   ├── Instructor.cs
│   ├── Student.cs
│   ├── Category.cs
│   ├── Course.cs
│   ├── FreeCourse.cs
│   ├── CertificateCourse.cs
│   ├── DiscountCourse.cs
│   ├── Lesson.cs
│   ├── Enrollment.cs
│   ├── Payment.cs
│   └── Review.cs
│
├── Interfaces
│   ├── ICourseDisplay.cs
│   ├── ILessonManagement.cs
│   ├── IEnrollmentDisplay.cs
│   ├── IPaymentDisplay.cs
│   ├── IReviewDisplay.cs
│   └── IEnrollment.cs
│
├── Services
│   └── ConsolePrinter.cs
│
├── Program.cs
│
└── README.md
🧱 تطبيق مبادئ SOLID خطوة بخطوة
🔵 1. SRP — Single Responsibility Principle
المسؤول: Mohamed Saeed

كلاس واحد = مسؤولية واحدة

التطبيق في الكود:

ConsolePrinter مسؤول فقط عن الطباعة (فصل العرض عن البيانات)

كل Model مسؤول عن بياناته فقط

لا يوجد كلاس يقوم بأكثر من مسؤولية

csharp
public class ConsolePrinter : ICourseDisplay, IEnrollmentDisplay,
                              IPaymentDisplay, IReviewDisplay
{
    public void ShowStudent(Student student) { ... }
    public void ShowCourse(Course course) { ... }
    // مسؤولية واحدة: الطباعة
}
🟢 2. OCP — Open/Closed Principle
المسؤول: Ziad Elfeky

مفتوح للتوسع، مغلق للتعديل

التطبيق في الكود:

إضافة نوع دورة جديد لا يتطلب تعديل Course الأصلي

كل نوع جديد يرث من Course ويعيد تعريف GetFinalPrice()

csharp
public class DiscountCourse : Course
{
    public double DiscountPercentage;

    public override double GetFinalPrice()
    {
        return Price - (Price * DiscountPercentage / 100);
    }
}
✅ إضافة FreeCourse أو CertificateCourse لم تعدل Course الأصلي.

🟡 3. LSP — Liskov Substitution Principle
المسؤول: Ahmed Khalifa

الفئة الابنة تُستخدم مكان الفئة الأم دون مشاكل

التطبيق في الكود:

csharp
List<Course> allCourses = new List<Course>
{
    course1,
    course2,
    course3,
    freeCourse,          // FreeCourse مكان Course ✅
    certificateCourse,   // CertificateCourse مكان Course ✅
    discountCourse       // DiscountCourse مكان Course ✅
};

foreach (Course course in allCourses)
{
    course.GetFinalPrice();  // يعمل مع كل الأنواع ✅
}
✅ جميع الأنواع الفرعية تعمل بنفس الطريقة عند استدعاء GetFinalPrice().

🟠 4. Inheritance Principle — مبدأ الوراثة
المسؤول: Ghofran Mohamed

إعادة استخدام الكود عبر الوراثة الصحيحة

التطبيق في الكود:

csharp
// الفئة الأم
public class Course
{
    public virtual double GetFinalPrice() => Price;
}

// الفئات الابنة
public class FreeCourse : Course          { ... }
public class CertificateCourse : Course   { ... }
public class DiscountCourse : Course      { ... }
✅ كل نوع دورة يرث الخصائص المشتركة ويعيد تعريف ما يحتاجه فقط.

🟣 5. ISP — Interface Segregation Principle
المسؤول: (مُطبَّق في الكود)

لا تُجبر كلاس على تنفيذ واجهات لا يحتاجها

التطبيق في الكود:

بدلاً من واجهة واحدة ضخمة:

csharp
// ❌ واجهة ضخمة
public interface IPrinter
{
    void ShowCourse(...);
    void ShowStudent(...);
    void ShowEnrollment(...);
    void ShowPayment(...);
    void ShowReview(...);
}
تم فصلها إلى واجهات صغيرة:

csharp
public interface ICourseDisplay      { void ShowCourse(Course course); }
public interface ILessonManagement   { void AddLesson(Lesson lesson); }
public interface IEnrollmentDisplay  { void ShowEnrollment(Enrollment e); }
public interface IPaymentDisplay     { void ShowPayment(Payment p); }
public interface IReviewDisplay      { void ShowReview(Review r); }
✅ Course ينفذ ILessonManagement فقط لأنه لا يحتاج باقي الواجهات.

🔴 6. DIP — Dependency Inversion Principle
المسؤول: Youssef Hegazy

الاعتماد على التجريدات وليس على التطبيقات الملموسة

التطبيق في الكود:

csharp
// التجريد
public interface IEnrollment
{
    string StudentName { get; }
    string CourseTitle { get; }
}

// Payment يعتمد على IEnrollment وليس Enrollment
public class Payment
{
    public IEnrollment Enrollment;  // ✅ تجريد وليس كلاس ملموس

    public Payment(int id, IEnrollment enrollment, ...)
    {
        Enrollment = enrollment;
    }
}

// Enrollment ينفذ التجريد
public class Enrollment : IEnrollment
{
    public string StudentName => Student.Name;
    public string CourseTitle => Course.Title;
}
✅ Payment لا يعرف شيئاً عن Enrollment الداخلي، فقط يعرف IEnrollment.

📊 ملخص SOLID مع المسؤولين
المبدأ	المعنى	التطبيق	المسؤول
SRP	مسؤولية واحدة	ConsolePrinter للطباعة فقط	Mohamed Saeed
OCP	فتح/إغلاق	DiscountCourse دون تعديل Course	Ziad Elfeky
LSP	استبدال ليزكوف	List<Course> يستقبل كل الأنواع	Ahmed Khalifa
Inheritance	الوراثة	Course → FreeCourse/Certificate/Discount	Ghofran Mohamed
ISP	فصل الواجهات	ICourseDisplay, IPaymentDisplay, ...	Team
DIP	انعكاس الاعتماد	Payment يعتمد على IEnrollment	Youssef Hegazy
🔗 العلاقات بين الكيانات
text
Instructor (1) ────► (N) Course
Category   (1) ────► (N) Course
Course     (1) ────► (N) Lesson
Student    (1) ────► (N) Enrollment ◄──── (N) Course
Enrollment (1) ────► (1) Payment  (عبر IEnrollment)
Student    (1) ────► (N) Review     ◄──── (N) Course
Student   (N) ◄────► (N) Course  (عبر Enrollment)
العلاقة	النوع	الوصف
Instructor → Course	1 : N	مدرب واحد ينشئ عدة دورات
Category → Course	1 : N	تصنيف واحد يحتوي عدة دورات
Course → Lesson	1 : N	دورة واحدة تحتوي عدة دروس
Student → Enrollment	1 : N	طالب واحد يسجل في عدة دورات
Course → Enrollment	1 : N	دورة واحدة بها عدة تسجيلات
Enrollment → Payment	1 : 1	كل تسجيل له دفعة خاصة
Student → Review	1 : N	طالب واحد يكتب عدة تقييمات
Course → Review	1 : N	دورة واحدة لها عدة تقييمات
🧩 الكيانات الرئيسية
👨‍🎓 Student
csharp
Student student1 = new Student(1, "Ibrahim Elghazaly", "ibrahim@gmail.com");
👨‍🏫 Instructor
csharp
Instructor instructor1 = new Instructor(
    1, "Ahmed Mohamed", "ahmed@gmail.com",
    "C# and .NET", "C# and .NET Instructor");
🗂️ Category
csharp
Category category1 = new Category(1, "Programming");
📚 Course (مع أنواعه الثلاثة)
csharp
Course course1 = new Course(1, "C# Programming", "...", 150, "40 Hours",
                            "Beginner", "English", instructor1, category1);

FreeCourse freeCourse = new FreeCourse(4, "Intro to Git", "...", ...);
CertificateCourse certCourse = new CertificateCourse(5, "ASP.NET", "...", 300, ...);
DiscountCourse discCourse = new DiscountCourse(6, "ASP.NET", "...", 200, 20, ...);
📖 Lesson
csharp
Lesson lesson1 = new Lesson(1, "Introduction to C#", "20 Minutes", 1);
course1.AddLesson(lesson1);  // ISP: ILessonManagement
📝 Enrollment (ينفذ IEnrollment — DIP)
csharp
Enrollment enrollment1 = new Enrollment(
    1, student1, course1, DateTime.Now, "Active", 150, "Credit Card");
💳 Payment (يعتمد على IEnrollment — DIP)
csharp
Payment payment1 = new Payment(
    1, enrollment1, 150, "Credit Card", DateTime.Now, "Completed");
⭐ Review
csharp
Review review1 = new Review(
    1, student1, course1, 5, "Very good course", DateTime.Now);
🖨️ ConsolePrinter — قلب تطبيق SRP
csharp
public class ConsolePrinter :
    ICourseDisplay,
    IEnrollmentDisplay,
    IPaymentDisplay,
    IReviewDisplay
{
    public void ShowStudent(Student student) { ... }
    public void ShowInstructor(Instructor instructor) { ... }
    public void ShowCourse(Course course) { ... }
    public void ShowEnrollment(Enrollment enrollment) { ... }
    public void ShowPayment(Payment payment) { ... }
    public void ShowReview(Review review) { ... }
}
✅ كل عمليات الطباعة في مكان واحد — SRP
✅ ينفذ واجهات صغيرة متعددة — ISP

▶️ كيفية تشغيل المشروع
bash
# 1. Clone
git clone https://github.com/EbrahimElghazaly/E-_Learning_Platform.git

# 2. Build
dotnet build

# 3. Run
dotnet run
📤 المخرجات المتوقعة
text
========== STUDENTS ==========
Student ID: 1
Name: Ibrahim Elghazaly
Email: ibrahim@gmail.com

========== INSTRUCTORS ==========
...

========== COURSES ==========
Course ID: 1
Title: C# Programming
Final Price: 150
...

========== LSP DEMO ==========
Final Price To Pay: 150    (Course)
Final Price To Pay: 0      (FreeCourse)
Final Price To Pay: 400    (CertificateCourse)
Final Price To Pay: 160    (DiscountCourse)
Total Revenue From Courses: 1010

========== ENROLLMENTS ==========
========== PAYMENTS ==========
========== REVIEWS ==========
🛠️ التقنيات المستخدمة
C# • .NET • OOP • SOLID • Console Application • Git • GitHub

🌱 التحسينات المستقبلية
🔐 تسجيل الدخول والمصادقة

🔍 البحث والفلترة

📊 لوحات تحكم للطالب والمدرب والأدمن

💳 طرق دفع متعددة (IPaymentMethod)

🗄️ SQL Server + Entity Framework Core

🌐 ASP.NET Core Web API

🔑 JWT Authentication

🏛️ Repository Pattern + DI Container

🧪 اختبارات الوحدة (xUnit)

🧼 Clean Architecture

🔌 نقاط API المستقبلية
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
📌 ملاحظة مهمة
المشروع مقسّم إلى مرحلتين:

Version 1 = C# أساسي + OOP + بدون SOLID (لإظهار المشاكل)
Version 2 = نفس المشروع + Refactoring + تطبيق SOLID الكامل ✅ (هذه النسخة)

🎓 مخرجات التعلم
✅ بناء تطبيق C# من الصفر

✅ نمذجة كيانات واقعية

✅ فهم OOP بعمق

✅ تحديد مشاكل الكود المترابط

✅ إعادة هيكلة مشروع قائم

✅ تطبيق SOLID الخمسة بشكل عملي

✅ استخدام الوراثة وتعدد الأشكال

✅ تصميم واجهات نظيفة

⭐ الرؤية المستقبلية
text
Console App → Clean Code → SOLID → SQL Server → EF Core
     → ASP.NET Core API → Auth → Frontend → Complete Platform
👨‍💻 الفريق
<div align="center">
🏗️ Ibrahim Mohamed Elghazaly	صاحب الفكرة والكود الأساسي
🔵 Mohamed Saeed	SRP
🟢 Ziad Elfeky	OCP
🟡 Ahmed Khalifa	LSP
🟠 Ghofran Mohamed	Inheritance
🔴 Youssef Hegazy	DIP
</div>
<div align="center">
🌟 لا تنسَ عمل Star للمستودع إذا أعجبك المشروع! 🌟
Made with ❤️ by Ibrahim Mohamed Elghazaly & Team

</div>
