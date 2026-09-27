<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>🎓 E-Learning Platform - C# / .NET</title>
<style>
  :root{
    --bg:#0d1117;
    --bg-2:#161b22;
    --bg-3:#1c2128;
    --border:#30363d;
    --text:#e6edf3;
    --text-dim:#8b949e;
    --accent:#58a6ff;
    --accent-2:#79c0ff;
    --green:#3fb950;
    --yellow:#d29922;
    --red:#f85149;
    --purple:#bc8cff;
    --orange:#ffa657;
  }
  *{box-sizing:border-box;margin:0;padding:0;}
  html{scroll-behavior:smooth;}
  body{
    font-family:-apple-system,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif;
    background:var(--bg);
    color:var(--text);
    line-height:1.7;
    font-size:16px;
  }
  .container{max-width:980px;margin:0 auto;padding:40px 24px 80px;}

  /* Hero */
  .hero{
    text-align:center;
    padding:48px 24px;
    background:linear-gradient(135deg,#1f6feb22,#bc8cff22);
    border:1px solid var(--border);
    border-radius:16px;
    margin-bottom:40px;
  }
  .hero h1{
    font-size:2.4rem;
    background:linear-gradient(135deg,#58a6ff,#bc8cff,#3fb950);
    -webkit-background-clip:text;
    -webkit-text-fill-color:transparent;
    background-clip:text;
    margin-bottom:12px;
  }
  .hero p{color:var(--text-dim);font-size:1.05rem;max-width:700px;margin:0 auto;}
  .badges{display:flex;flex-wrap:wrap;gap:8px;justify-content:center;margin-top:20px;}
  .badge{
    background:var(--bg-3);
    border:1px solid var(--border);
    padding:4px 12px;
    border-radius:20px;
    font-size:.82rem;
    color:var(--accent-2);
    font-weight:500;
  }

  /* Headings */
  h2{
    font-size:1.6rem;
    margin:48px 0 20px;
    padding-bottom:10px;
    border-bottom:1px solid var(--border);
    color:var(--text);
  }
  h3{
    font-size:1.2rem;
    margin:28px 0 14px;
    color:var(--accent-2);
  }
  h4{
    font-size:1rem;
    margin:20px 0 10px;
    color:var(--text);
  }
  p{margin-bottom:14px;color:var(--text);}
  a{color:var(--accent);text-decoration:none;}
  a:hover{text-decoration:underline;}

  /* Lists */
  ul,ol{margin:12px 0 18px 24px;}
  li{margin-bottom:8px;}

  /* Code */
  code{
    background:var(--bg-3);
    padding:2px 7px;
    border-radius:6px;
    font-family:"SF Mono",Consolas,"Liberation Mono",Menlo,monospace;
    font-size:.88em;
    color:var(--accent-2);
    border:1px solid var(--border);
  }
  pre{
    background:var(--bg-2);
    border:1px solid var(--border);
    border-radius:10px;
    padding:18px;
    overflow-x:auto;
    margin:14px 0 20px;
    position:relative;
  }
  pre code{
    background:none;
    border:none;
    padding:0;
    color:var(--text);
    font-size:.86rem;
    line-height:1.6;
  }
  /* simple syntax colors */
  .kw{color:#ff7b72;}
  .ty{color:#ffa657;}
  .st{color:#a5d6ff;}
  .cm{color:#8b949e;font-style:italic;}
  .fn{color:#d2a8ff;}
  .nm{color:#79c0ff;}

  /* Tables */
  table{
    width:100%;
    border-collapse:collapse;
    margin:18px 0;
    background:var(--bg-2);
    border-radius:10px;
    overflow:hidden;
    border:1px solid var(--border);
    font-size:.92rem;
  }
  th{
    background:var(--bg-3);
    padding:12px 14px;
    text-align:left;
    font-weight:600;
    color:var(--accent-2);
    border-bottom:1px solid var(--border);
    font-size:.88rem;
    text-transform:uppercase;
    letter-spacing:.4px;
  }
  td{
    padding:11px 14px;
    border-bottom:1px solid var(--border);
    vertical-align:top;
  }
  tr:last-child td{border-bottom:none;}
  tr:hover td{background:#1c212877;}

  /* Callouts */
  .note{
    background:#1f6feb1a;
    border-left:4px solid var(--accent);
    padding:14px 18px;
    border-radius:0 8px 8px 0;
    margin:18px 0;
  }
  .warn{
    background:#d299221a;
    border-left:4px solid var(--yellow);
    padding:14px 18px;
    border-radius:0 8px 8px 0;
    margin:18px 0;
  }
  .success{
    background:#3fb9501a;
    border-left:4px solid var(--green);
    padding:14px 18px;
    border-radius:0 8px 8px 0;
    margin:18px 0;
  }
  .note strong,.warn strong,.success strong{color:var(--text);}

  /* SOLID cards */
  .solid-grid{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(260px,1fr));
    gap:16px;
    margin:20px 0;
  }
  .solid-card{
    background:var(--bg-2);
    border:1px solid var(--border);
    border-radius:12px;
    padding:20px;
    position:relative;
    overflow:hidden;
  }
  .solid-card::before{
    content:"";
    position:absolute;
    top:0;left:0;right:0;height:4px;
  }
  .solid-card.srp::before{background:#58a6ff;}
  .solid-card.ocp::before{background:#3fb950;}
  .solid-card.lsp::before{background:#d29922;}
  .solid-card.isp::before{background:#bc8cff;}
  .solid-card.dip::before{background:#f85149;}
  .solid-card h4{margin-top:0;font-size:1.05rem;}
  .solid-card .letter{font-size:1.8rem;font-weight:800;opacity:.25;position:absolute;top:12px;right:16px;}
  .solid-card .owner{font-size:.82rem;color:var(--text-dim);margin-top:8px;}

  /* Diagram */
  .diagram{
    background:var(--bg-2);
    border:1px solid var(--border);
    border-radius:10px;
    padding:24px;
    font-family:"SF Mono",Consolas,monospace;
    font-size:.88rem;
    line-height:1.9;
    color:var(--accent-2);
    overflow-x:auto;
    white-space:pre;
  }

  /* Team grid */
  .team-grid{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(220px,1fr));
    gap:14px;
    margin:20px 0;
  }
  .team-card{
    background:var(--bg-2);
    border:1px solid var(--border);
    border-radius:10px;
    padding:16px;
    text-align:center;
  }
  .team-card .role{font-size:.8rem;color:var(--text-dim);text-transform:uppercase;letter-spacing:.5px;}
  .team-card .name{font-weight:600;color:var(--text);margin-top:6px;}

  /* Footer */
  footer{
    margin-top:60px;
    padding-top:30px;
    border-top:1px solid var(--border);
    text-align:center;
    color:var(--text-dim);
    font-size:.9rem;
  }
  footer .heart{color:var(--red);}

  /* TOC */
  .toc{
    background:var(--bg-2);
    border:1px solid var(--border);
    border-radius:12px;
    padding:20px 24px;
    margin-bottom:30px;
  }
  .toc h3{margin-top:0;color:var(--text);font-size:1.05rem;}
  .toc ol{margin:0 0 0 20px;columns:2;column-gap:30px;}
  .toc li{margin-bottom:6px;font-size:.92rem;}
  @media(max-width:640px){
    .toc ol{columns:1;}
    .hero h1{font-size:1.7rem;}
    .container{padding:24px 16px 60px;}
  }

  /* Back to top */
  .top{
    position:fixed;
    bottom:24px;right:24px;
    background:var(--accent);
    color:#fff;
    width:44px;height:44px;
    border-radius:50%;
    display:flex;align-items:center;justify-content:center;
    text-decoration:none;
    font-size:1.2rem;
    box-shadow:0 4px 14px #58a6ff55;
    opacity:.85;
    transition:.2s;
  }
  .top:hover{opacity:1;transform:translateY(-3px);text-decoration:none;}
</style>
</head>
<body>
<div class="container">

  <!-- HERO -->
  <div class="hero">
    <h1>🎓 E-Learning Platform</h1>
    <p>A C# / .NET Console-based E-Learning Platform designed to demonstrate Object-Oriented Programming (OOP) concepts and the practical application of the five SOLID principles through clean code and refactoring.</p>
    <div class="badges">
      <span class="badge">C#</span>
      <span class="badge">.NET</span>
      <span class="badge">OOP</span>
      <span class="badge">SOLID</span>
      <span class="badge">Console App</span>
      <span class="badge">Git</span>
      <span class="badge">GitHub</span>
    </div>
  </div>

  <!-- TOC -->
  <nav class="toc">
    <h3>📑 Table of Contents</h3>
    <ol>
      <li><a href="#overview">Project Overview</a></li>
      <li><a href="#team">Team Members</a></li>
      <li><a href="#goals">Project Goals</a></li>
      <li><a href="#tech">Technologies Used</a></li>
      <li><a href="#structure">Project Structure</a></li>
      <li><a href="#oop">OOP Concepts</a></li>
      <li><a href="#solid">SOLID Principles</a></li>
      <li><a href="#summary">SOLID Summary</a></li>
      <li><a href="#relationships">Entity Relationships</a></li>
      <li><a href="#entities">Main Entities</a></li>
      <li><a href="#printer">ConsolePrinter</a></li>
      <li><a href="#pricing">Course Pricing</a></li>
      <li><a href="#run">How to Run</a></li>
      <li><a href="#output">Expected Output</a></li>
      <li><a href="#versions">Project Versions</a></li>
      <li><a href="#future">Future Improvements</a></li>
      <li><a href="#api">Future API Endpoints</a></li>
      <li><a href="#outcomes">Learning Outcomes</a></li>
      <li><a href="#roadmap">Architecture Roadmap</a></li>
      <li><a href="#notes">Important Design Notes</a></li>
    </ol>
  </nav>

  <!-- OVERVIEW -->
  <section id="overview">
    <h2>📌 Project Overview</h2>
    <p>This project is an educational E-Learning Platform built using <strong>C#</strong> and <strong>.NET</strong> as a <strong>Console Application</strong>.</p>
    <p>The project demonstrates:</p>
    <ul>
      <li>Object-Oriented Programming (OOP)</li>
      <li>Encapsulation</li>
      <li>Inheritance</li>
      <li>Polymorphism</li>
      <li>Abstraction</li>
      <li>SOLID Principles</li>
      <li>Refactoring</li>
      <li>Clean Code Concepts</li>
      <li>Relationships between real-world entities</li>
    </ul>
    <p>The project was developed in two main stages:</p>
    <ul>
      <li><strong>Version 1:</strong> Basic C# and OOP implementation without SOLID</li>
      <li><strong>Version 2:</strong> Refactored version with practical application of the five SOLID principles</li>
    </ul>
    <p>The second version focuses on improving maintainability, extensibility, and separation of responsibilities.</p>
  </section>

  <!-- TEAM -->
  <section id="team">
    <h2>👨‍💻 Team Members</h2>
    <table>
      <thead>
        <tr><th>Role</th><th>Name</th><th>Responsibility</th></tr>
      </thead>
      <tbody>
        <tr><td>🏗️ Project Owner &amp; Base Code</td><td>Ibrahim Mohamed Elghazaly</td><td>Project idea and initial implementation</td></tr>
        <tr><td>🔵 SRP</td><td>Mohamed Saeed</td><td>Single Responsibility Principle</td></tr>
        <tr><td>🟢 OCP</td><td>Ziad Elfeky</td><td>Open/Closed Principle</td></tr>
        <tr><td>🟡 LSP</td><td>Ahmed Khalifa</td><td>Liskov Substitution Principle</td></tr>
        <tr><td>🟠 OOP / Inheritance</td><td>Ghofran Mohamed</td><td>Inheritance and OOP concepts</td></tr>
        <tr><td>🔴 DIP</td><td>Youssef Hegazy</td><td>Dependency Inversion Principle</td></tr>
        <tr><td>🟣 ISP</td><td>Team</td><td>Interface Segregation Principle</td></tr>
      </tbody>
    </table>
  </section>

  <!-- GOALS -->
  <section id="goals">
    <h2>🎯 Project Goals</h2>
    <ul>
      <li>✅ Practice C# and .NET</li>
      <li>✅ Understand OOP concepts</li>
      <li>✅ Model real-world entities</li>
      <li>✅ Understand relationships between objects</li>
      <li>✅ Apply the five SOLID principles</li>
      <li>✅ Refactor an existing codebase</li>
      <li>✅ Improve code maintainability</li>
      <li>✅ Prepare the project for future API and database integration</li>
    </ul>
  </section>

  <!-- TECH -->
  <section id="tech">
    <h2>🛠️ Technologies Used</h2>
    <div class="badges" style="justify-content:flex-start;">
      <span class="badge">C#</span>
      <span class="badge">.NET</span>
      <span class="badge">OOP</span>
      <span class="badge">SOLID Principles</span>
      <span class="badge">Console Application</span>
      <span class="badge">Git</span>
      <span class="badge">GitHub</span>
    </div>
  </section>

  <!-- STRUCTURE -->
  <section id="structure">
    <h2>🧱 Project Structure</h2>
    <div class="diagram">E-Learning-Platform
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
└── README.md</div>
  </section>

  <!-- OOP -->
  <section id="oop">
    <h2>🧠 OOP Concepts</h2>
    <p>The project uses the main Object-Oriented Programming concepts.</p>

    <h3>1. Encapsulation</h3>
    <p>Each entity stores its related data and behavior inside a class.</p>
    <p><strong>Examples:</strong> <code>Student</code>, <code>Instructor</code>, <code>Course</code>, <code>Lesson</code>, <code>Enrollment</code>, <code>Payment</code>, <code>Review</code>.</p>

    <h3>2. Inheritance</h3>
    <div class="warn">
      <strong>Note:</strong> Inheritance is an OOP concept, <strong>not one of the five SOLID principles</strong>.
    </div>
    <p>The project uses inheritance to create specialized course types from the base <code>Course</code> class.</p>
<pre><code><span class="kw">public class</span> <span class="ty">Course</span>
{
    <span class="kw">public virtual double</span> <span class="fn">GetFinalPrice</span>()
    {
        <span class="kw">return</span> Price;
    }
}

<span class="kw">public class</span> <span class="ty">FreeCourse</span> : <span class="ty">Course</span>
{
    <span class="kw">public override double</span> <span class="fn">GetFinalPrice</span>()
    {
        <span class="kw">return</span> <span class="nm">0</span>;
    }
}

<span class="kw">public class</span> <span class="ty">CertificateCourse</span> : <span class="ty">Course</span>
{
    <span class="kw">public override double</span> <span class="fn">GetFinalPrice</span>()
    {
        <span class="kw">return</span> Price + CertificateFee;
    }
}

<span class="kw">public class</span> <span class="ty">DiscountCourse</span> : <span class="ty">Course</span>
{
    <span class="kw">public override double</span> <span class="fn">GetFinalPrice</span>()
    {
        <span class="kw">return</span> Price - (Price * DiscountPercentage / <span class="nm">100</span>);
    }
}</code></pre>
    <p>This allows specialized classes to reuse common properties and behavior from <code>Course</code>.</p>

    <h3>3. Polymorphism</h3>
    <p>Polymorphism is demonstrated by storing different course types in a collection of the base type:</p>
<pre><code><span class="ty">List</span>&lt;<span class="ty">Course</span>&gt; allCourses =
    <span class="kw">new</span> <span class="ty">List</span>&lt;<span class="ty">Course</span>&gt;
    {
        course1,
        course2,
        course3,
        freeCourse,
        certificateCourse,
        discountCourse
    };</code></pre>
    <p>Then:</p>
<pre><code><span class="kw">foreach</span> (<span class="ty">Course</span> course <span class="kw">in</span> allCourses)
{
    Console.<span class="fn">WriteLine</span>(course.<span class="fn">GetFinalPrice</span>());
}</code></pre>
    <p>The same method <code>GetFinalPrice()</code> can produce different results depending on the actual object type.</p>

    <h3>4. Abstraction</h3>
    <p>The project uses interfaces to define contracts without exposing implementation details.</p>
<pre><code><span class="kw">public interface</span> <span class="ty">IEnrollment</span>
{
    <span class="kw">string</span> StudentName { <span class="kw">get</span>; }
    <span class="kw">string</span> CourseTitle { <span class="kw">get</span>; }
}</code></pre>
    <p>The <code>Payment</code> class can work with the abstraction instead of directly depending on the concrete <code>Enrollment</code> class.</p>
  </section>

  <!-- SOLID -->
  <section id="solid">
    <h2>🧩 SOLID Principles</h2>
    <p>The project demonstrates all five SOLID principles:</p>
    <div class="solid-grid">
      <div class="solid-card srp"><span class="letter">S</span><h4>Single Responsibility</h4><p>One reason to change.</p></div>
      <div class="solid-card ocp"><span class="letter">O</span><h4>Open / Closed</h4><p>Open for extension, closed for modification.</p></div>
      <div class="solid-card lsp"><span class="letter">L</span><h4>Liskov Substitution</h4><p>Derived types must be substitutable.</p></div>
      <div class="solid-card isp"><span class="letter">I</span><h4>Interface Segregation</h4><p>No forced dependencies on unused methods.</p></div>
      <div class="solid-card dip"><span class="letter">D</span><h4>Dependency Inversion</h4><p>Depend on abstractions, not concretions.</p></div>
    </div>

    <!-- SRP -->
    <h3>🔵 1. SRP — Single Responsibility Principle</h3>
    <p><strong>Responsible:</strong> Mohamed Saeed</p>
    <p><strong>Definition:</strong> A class should have one reason to change.</p>
    <p>The project separates the responsibility of displaying information from the entity classes.</p>
<pre><code><span class="kw">public class</span> <span class="ty">ConsolePrinter</span>
{
    <span class="kw">public void</span> <span class="fn">ShowStudent</span>(<span class="ty">Student</span> student)
    {
        Console.<span class="fn">WriteLine</span>(<span class="st">"Student ID: "</span> + student.StudentID);
        Console.<span class="fn">WriteLine</span>(<span class="st">"Name: "</span> + student.Name);
        Console.<span class="fn">WriteLine</span>(<span class="st">"Email: "</span> + student.Email);
    }

    <span class="kw">public void</span> <span class="fn">ShowCourse</span>(<span class="ty">Course</span> course)
    {
        <span class="cm">// Display course information</span>
    }
}</code></pre>
    <p><code>ConsolePrinter</code> has one main responsibility: <strong>Displaying system data in the Console.</strong></p>
    <p>The models represent the application's data, while <code>ConsolePrinter</code> handles presentation.</p>
    <div class="success">
      <strong>Benefits:</strong> Easier maintenance, easier modification, better separation of responsibilities, easier future testing.
    </div>

    <!-- OCP -->
    <h3>🟢 2. OCP — Open/Closed Principle</h3>
    <p><strong>Responsible:</strong> Ziad Elfeky</p>
    <p><strong>Definition:</strong> Software entities should be open for extension but closed for modification.</p>
    <p>The base <code>Course</code> class defines common pricing behavior:</p>
<pre><code><span class="kw">public virtual double</span> <span class="fn">GetFinalPrice</span>()
{
    <span class="kw">return</span> Price;
}</code></pre>
    <p>New course types can extend this behavior without modifying the original <code>Course</code> implementation.</p>
<pre><code><span class="kw">public class</span> <span class="ty">DiscountCourse</span> : <span class="ty">Course</span>
{
    <span class="kw">public double</span> DiscountPercentage;

    <span class="kw">public override double</span> <span class="fn">GetFinalPrice</span>()
    {
        <span class="kw">return</span> Price - (Price * DiscountPercentage / <span class="nm">100</span>);
    }
}</code></pre>
    <p>Other course types include:</p>
    <div class="diagram">Course
├── FreeCourse
├── CertificateCourse
└── DiscountCourse</div>
    <div class="success">
      <strong>Benefit:</strong> If a new course type is required in the future (e.g., <code>PremiumCourse</code>, <code>BundleCourse</code>, <code>SeasonalDiscountCourse</code>), it can be implemented as a new class without changing the existing <code>Course</code> pricing logic.
    </div>

    <!-- LSP -->
    <h3>🟡 3. LSP — Liskov Substitution Principle</h3>
    <p><strong>Responsible:</strong> Ahmed Khalifa</p>
    <p><strong>Definition:</strong> Objects of a derived class should be usable wherever objects of the base class are expected without breaking the application.</p>
    <p>The project demonstrates this using:</p>
<pre><code><span class="ty">List</span>&lt;<span class="ty">Course</span>&gt; allCourses =
    <span class="kw">new</span> <span class="ty">List</span>&lt;<span class="ty">Course</span>&gt;
    {
        course1,
        course2,
        course3,
        freeCourse,
        certificateCourse,
        discountCourse
    };</code></pre>
    <p>All derived classes can be treated as <code>Course</code>.</p>
<pre><code><span class="kw">foreach</span> (<span class="ty">Course</span> course <span class="kw">in</span> allCourses)
{
    Console.<span class="fn">WriteLine</span>(course.<span class="fn">GetFinalPrice</span>());
}</code></pre>
    <p>Each derived class provides its own implementation of <code>GetFinalPrice()</code>. Therefore, the base class reference can work with all supported course types.</p>

    <!-- ISP -->
    <h3>🟣 4. ISP — Interface Segregation Principle</h3>
    <p><strong>Definition:</strong> A class should not be forced to depend on methods it does not use.</p>
    <p>Instead of creating one large interface:</p>
<pre><code><span class="cm">// ❌ Large interface</span>
<span class="kw">public interface</span> <span class="ty">IPrinter</span>
{
    <span class="kw">void</span> <span class="fn">ShowCourse</span>(<span class="ty">Course</span> course);
    <span class="kw">void</span> <span class="fn">ShowStudent</span>(<span class="ty">Student</span> student);
    <span class="kw">void</span> <span class="fn">ShowEnrollment</span>(<span class="ty">Enrollment</span> enrollment);
    <span class="kw">void</span> <span class="fn">ShowPayment</span>(<span class="ty">Payment</span> payment);
    <span class="kw">void</span> <span class="fn">ShowReview</span>(<span class="ty">Review</span> review);
}</code></pre>
    <p>The project separates responsibilities into smaller interfaces:</p>
<pre><code><span class="kw">public interface</span> <span class="ty">ICourseDisplay</span>
{
    <span class="kw">void</span> <span class="fn">ShowCourse</span>(<span class="ty">Course</span> course);
}
<span class="kw">public interface</span> <span class="ty">ILessonManagement</span>
{
    <span class="kw">void</span> <span class="fn">AddLesson</span>(<span class="ty">Lesson</span> lesson);
}
<span class="kw">public interface</span> <span class="ty">IEnrollmentDisplay</span>
{
    <span class="kw">void</span> <span class="fn">ShowEnrollment</span>(<span class="ty">Enrollment</span> enrollment);
}
<span class="kw">public interface</span> <span class="ty">IPaymentDisplay</span>
{
    <span class="kw">void</span> <span class="fn">ShowPayment</span>(<span class="ty">Payment</span> payment);
}
<span class="kw">public interface</span> <span class="ty">IReviewDisplay</span>
{
    <span class="kw">void</span> <span class="fn">ShowReview</span>(<span class="ty">Review</span> review);
}</code></pre>
    <p>For example:</p>
<pre><code><span class="kw">public class</span> <span class="ty">Course</span> : <span class="ty">ILessonManagement</span>
{
    <span class="kw">public void</span> <span class="fn">AddLesson</span>(<span class="ty">Lesson</span> lesson)
    {
        Lessons.<span class="fn">Add</span>(lesson);
    }
}</code></pre>
    <p><code>Course</code> implements only the interface it actually needs.</p>
    <div class="success">
      <strong>Benefit:</strong> Small interfaces make the system easier to understand, maintain, extend, and test.
    </div>

    <!-- DIP -->
    <h3>🔴 5. DIP — Dependency Inversion Principle</h3>
    <p><strong>Responsible:</strong> Youssef Hegazy</p>
    <p><strong>Definition:</strong> High-level modules should not depend directly on low-level concrete implementations. Both should depend on abstractions.</p>
    <p>The project defines:</p>
<pre><code><span class="kw">public interface</span> <span class="ty">IEnrollment</span>
{
    <span class="kw">string</span> StudentName { <span class="kw">get</span>; }
    <span class="kw">string</span> CourseTitle { <span class="kw">get</span>; }
}</code></pre>
    <p><code>Enrollment</code> implements this abstraction:</p>
<pre><code><span class="kw">public class</span> <span class="ty">Enrollment</span> : <span class="ty">IEnrollment</span>
{
    <span class="kw">public string</span> StudentName
    {
        <span class="kw">get</span> { <span class="kw">return</span> Student.Name; }
    }

    <span class="kw">public string</span> CourseTitle
    {
        <span class="kw">get</span> { <span class="kw">return</span> Course.Title; }
    }
}</code></pre>
    <p>The <code>Payment</code> class depends on the abstraction:</p>
<pre><code><span class="kw">public class</span> <span class="ty">Payment</span>
{
    <span class="kw">public</span> <span class="ty">IEnrollment</span> Enrollment;

    <span class="kw">public</span> <span class="fn">Payment</span>(
        <span class="kw">int</span> paymentID,
        <span class="ty">IEnrollment</span> enrollment,
        <span class="kw">double</span> amount,
        <span class="kw">string</span> paymentMethod,
        <span class="ty">DateTime</span> paymentDate,
        <span class="kw">string</span> status)
    {
        PaymentID = paymentID;
        Enrollment = enrollment;
        Amount = amount;
        PaymentMethod = paymentMethod;
        PaymentDate = paymentDate;
        Status = status;
    }
}</code></pre>
    <p>Instead of <code>public Enrollment Enrollment;</code>, the project uses <code>public IEnrollment Enrollment;</code>.</p>
    <div class="note">
      <strong>Important Note:</strong> The current project demonstrates Dependency Inversion, but it does not yet implement a full Dependency Injection container. A future ASP.NET Core version can introduce Constructor Injection, .NET DI Container, and Service Registration.
    </div>
  </section>

  <!-- SUMMARY -->
  <section id="summary">
    <h2>📊 SOLID Summary</h2>
    <table>
      <thead>
        <tr><th>Principle</th><th>Meaning</th><th>Application</th><th>Responsible</th></tr>
      </thead>
      <tbody>
        <tr><td>SRP</td><td>Single Responsibility</td><td>ConsolePrinter handles presentation</td><td>Mohamed Saeed</td></tr>
        <tr><td>OCP</td><td>Open/Closed</td><td>New course types extend Course</td><td>Ziad Elfeky</td></tr>
        <tr><td>LSP</td><td>Liskov Substitution</td><td>Derived courses work as Course</td><td>Ahmed Khalifa</td></tr>
        <tr><td>ISP</td><td>Interface Segregation</td><td>Small specialized interfaces</td><td>Team</td></tr>
        <tr><td>DIP</td><td>Dependency Inversion</td><td>Payment depends on IEnrollment</td><td>Youssef Hegazy</td></tr>
      </tbody>
    </table>
  </section>

  <!-- RELATIONSHIPS -->
  <section id="relationships">
    <h2>🔗 Entity Relationships</h2>
    <div class="diagram">Instructor (1) ────────► (N) Course

Category   (1) ────────► (N) Course

Course     (1) ────────► (N) Lesson

Student    (1) ────────► (N) Enrollment ◄────── (N) Course

Enrollment (1) ────────► (1) Payment

Student    (1) ────────► (N) Review ◄────────── (N) Course

Student    (N) ◄──────────────────────────────► (N) Course
                     through Enrollment</div>

    <h3>Relationship Details</h3>
    <table>
      <thead>
        <tr><th>Relationship</th><th>Type</th><th>Description</th></tr>
      </thead>
      <tbody>
        <tr><td>Instructor → Course</td><td>1 : N</td><td>One instructor can have multiple courses</td></tr>
        <tr><td>Category → Course</td><td>1 : N</td><td>One category can contain multiple courses</td></tr>
        <tr><td>Course → Lesson</td><td>1 : N</td><td>One course can contain multiple lessons</td></tr>
        <tr><td>Student → Enrollment</td><td>1 : N</td><td>One student can have multiple enrollments</td></tr>
        <tr><td>Course → Enrollment</td><td>1 : N</td><td>One course can have multiple enrollments</td></tr>
        <tr><td>Enrollment → Payment</td><td>1 : 1*</td><td>Business assumption that an enrollment has one payment</td></tr>
        <tr><td>Student → Review</td><td>1 : N</td><td>One student can write multiple reviews</td></tr>
        <tr><td>Course → Review</td><td>1 : N</td><td>One course can have multiple reviews</td></tr>
      </tbody>
    </table>
    <div class="note">
      <strong>Note:</strong> The <code>Enrollment → Payment 1:1</code> relationship is a business assumption. The current object model does not enforce the relationship from both sides.
    </div>
  </section>

  <!-- ENTITIES -->
  <section id="entities">
    <h2>🧩 Main Entities</h2>

    <h3>👨‍🎓 Student</h3>
<pre><code><span class="ty">Student</span> student1 =
    <span class="kw">new</span> <span class="ty">Student</span>(
        <span class="nm">1</span>,
        <span class="st">"Ibrahim Elghazaly"</span>,
        <span class="st">"ibrahim@gmail.com"</span>
    );</code></pre>

    <h3>👨‍🏫 Instructor</h3>
<pre><code><span class="ty">Instructor</span> instructor1 =
    <span class="kw">new</span> <span class="ty">Instructor</span>(
        <span class="nm">1</span>,
        <span class="st">"Ahmed Mohamed"</span>,
        <span class="st">"ahmed@gmail.com"</span>,
        <span class="st">"C# and .NET"</span>,
        <span class="st">"C# and .NET Instructor"</span>
    );</code></pre>

    <h3>🗂️ Category</h3>
<pre><code><span class="ty">Category</span> category1 =
    <span class="kw">new</span> <span class="ty">Category</span>(
        <span class="nm">1</span>,
        <span class="st">"Programming"</span>
    );</code></pre>

    <h3>📚 Course</h3>
<pre><code><span class="ty">Course</span> course1 =
    <span class="kw">new</span> <span class="ty">Course</span>(
        <span class="nm">1</span>,
        <span class="st">"C# Programming"</span>,
        <span class="st">"Learn C# Programming"</span>,
        <span class="nm">150</span>,
        <span class="st">"40 Hours"</span>,
        <span class="st">"Beginner"</span>,
        <span class="st">"English"</span>,
        instructor1,
        category1
    );</code></pre>

    <h3>🆓 FreeCourse</h3>
<pre><code><span class="ty">FreeCourse</span> freeCourse =
    <span class="kw">new</span> <span class="ty">FreeCourse</span>(
        <span class="nm">4</span>,
        <span class="st">"Intro to Git &amp; GitHub"</span>,
        <span class="st">"A free introductory course"</span>,
        <span class="st">"5 Hours"</span>,
        <span class="st">"Beginner"</span>,
        <span class="st">"English"</span>,
        instructor1,
        category1
    );</code></pre>

    <h3>🎓 CertificateCourse</h3>
<pre><code><span class="ty">CertificateCourse</span> certificateCourse =
    <span class="kw">new</span> <span class="ty">CertificateCourse</span>(
        <span class="nm">5</span>,
        <span class="st">"Advanced ASP.NET Core"</span>,
        <span class="st">"Deep dive with a certificate"</span>,
        <span class="nm">300</span>,
        <span class="st">"60 Hours"</span>,
        <span class="st">"Advanced"</span>,
        <span class="st">"English"</span>,
        instructor2,
        category2
    );</code></pre>

    <h3>🏷️ DiscountCourse</h3>
<pre><code><span class="ty">DiscountCourse</span> discountCourse =
    <span class="kw">new</span> <span class="ty">DiscountCourse</span>(
        <span class="nm">6</span>,
        <span class="st">"ASP.NET Core"</span>,
        <span class="st">"Learn ASP.NET Core with discount"</span>,
        <span class="nm">200</span>,
        <span class="nm">20</span>,
        <span class="st">"40 Hours"</span>,
        <span class="st">"Intermediate"</span>,
        <span class="st">"English"</span>,
        instructor1,
        category1
    );</code></pre>

    <h3>📖 Lesson</h3>
<pre><code><span class="ty">Lesson</span> lesson1 =
    <span class="kw">new</span> <span class="ty">Lesson</span>(
        <span class="nm">1</span>,
        <span class="st">"Introduction to C#"</span>,
        <span class="st">"20 Minutes"</span>,
        <span class="nm">1</span>
    );

course1.<span class="fn">AddLesson</span>(lesson1);</code></pre>
    <p>The <code>AddLesson()</code> operation is provided through <code>ILessonManagement</code>.</p>

    <h3>📝 Enrollment</h3>
<pre><code><span class="ty">Enrollment</span> enrollment1 =
    <span class="kw">new</span> <span class="ty">Enrollment</span>(
        <span class="nm">1</span>,
        student1,
        course1,
        <span class="ty">DateTime</span>.Now,
        <span class="st">"Active"</span>,
        <span class="nm">150</span>,
        <span class="st">"Credit Card"</span>
    );</code></pre>
    <p><code>Enrollment</code> implements <code>IEnrollment</code>.</p>

    <h3>💳 Payment</h3>
<pre><code><span class="ty">Payment</span> payment1 =
    <span class="kw">new</span> <span class="ty">Payment</span>(
        <span class="nm">1</span>,
        enrollment1,
        <span class="nm">150</span>,
        <span class="st">"Credit Card"</span>,
        <span class="ty">DateTime</span>.Now,
        <span class="st">"Completed"</span>
    );</code></pre>
    <p><code>Payment</code> depends on <code>IEnrollment</code> rather than directly depending on the concrete <code>Enrollment</code> type.</p>

    <h3>⭐ Review</h3>
<pre><code><span class="ty">Review</span> review1 =
    <span class="kw">new</span> <span class="ty">Review</span>(
        <span class="nm">1</span>,
        student1,
        course1,
        <span class="nm">5</span>,
        <span class="st">"Very good course"</span>,
        <span class="ty">DateTime</span>.Now
    );</code></pre>
  </section>

  <!-- PRINTER -->
  <section id="printer">
    <h2>🖨️ ConsolePrinter</h2>
    <p><code>ConsolePrinter</code> is the main presentation component in the Console Application. It implements several small display interfaces:</p>
<pre><code><span class="kw">public class</span> <span class="ty">ConsolePrinter</span> :
    <span class="ty">ICourseDisplay</span>,
    <span class="ty">IEnrollmentDisplay</span>,
    <span class="ty">IPaymentDisplay</span>,
    <span class="ty">IReviewDisplay</span>
{
    <span class="kw">public void</span> <span class="fn">ShowStudent</span>(<span class="ty">Student</span> student)
    {
        <span class="cm">// Display student information</span>
    }

    <span class="kw">public void</span> <span class="fn">ShowInstructor</span>(<span class="ty">Instructor</span> instructor)
    {
        <span class="cm">// Display instructor information</span>
    }

    <span class="kw">public void</span> <span class="fn">ShowCourse</span>(<span class="ty">Course</span> course)
    {
        <span class="cm">// Display course information</span>
    }

    <span class="kw">public void</span> <span class="fn">ShowEnrollment</span>(<span class="ty">Enrollment</span> enrollment)
    {
        <span class="cm">// Display enrollment information</span>
    }

    <span class="kw">public void</span> <span class="fn">ShowPayment</span>(<span class="ty">Payment</span> payment)
    {
        <span class="cm">// Display payment information</span>
    }

    <span class="kw">public void</span> <span class="fn">ShowReview</span>(<span class="ty">Review</span> review)
    {
        <span class="cm">// Display review information</span>
    }
}</code></pre>
    <h4>Design Principles Demonstrated</h4>
    <ul>
      <li><strong>SRP:</strong> Presentation is separated from model classes.</li>
      <li><strong>ISP:</strong> Display responsibilities are separated into focused interfaces.</li>
    </ul>
  </section>

  <!-- PRICING -->
  <section id="pricing">
    <h2>💰 Course Pricing Demonstration</h2>
    <p>The project contains several pricing behaviors:</p>
    <table>
      <thead>
        <tr><th>Course Type</th><th>Base Price</th><th>Rule</th><th>Final Price</th></tr>
      </thead>
      <tbody>
        <tr><td>Course</td><td>150</td><td>No change</td><td>150</td></tr>
        <tr><td>Course</td><td>120</td><td>No change</td><td>120</td></tr>
        <tr><td>Course</td><td>180</td><td>No change</td><td>180</td></tr>
        <tr><td>FreeCourse</td><td>0</td><td>Free</td><td>0</td></tr>
        <tr><td>CertificateCourse</td><td>300</td><td>+100 certificate fee</td><td>400</td></tr>
        <tr><td>DiscountCourse</td><td>200</td><td>20% discount</td><td>160</td></tr>
      </tbody>
    </table>
    <h4>Calculation</h4>
<pre><code><span class="nm">150</span> + <span class="nm">120</span> + <span class="nm">180</span> + <span class="nm">0</span> + <span class="nm">400</span> + <span class="nm">160</span> = <span class="nm">1010</span></code></pre>
    <p>Therefore:</p>
<pre><code>Total Final Price of Courses: <span class="nm">1010</span></code></pre>
    <div class="note">
      This value represents the sum of the final prices of the course objects. It should not be interpreted as actual business revenue from enrollments.
    </div>
  </section>

  <!-- RUN -->
  <section id="run">
    <h2>▶️ How to Run the Project</h2>

    <h4>1. Clone the Repository</h4>
<pre><code>git clone https://github.com/EbrahimElghazaly/E_Learning_Platform.git</code></pre>

    <h4>2. Open the Project</h4>
<pre><code>cd E_Learning_Platform</code></pre>

    <h4>3. Build the Project</h4>
<pre><code>dotnet build</code></pre>

    <h4>4. Run the Application</h4>
<pre><code>dotnet run</code></pre>
  </section>

  <!-- OUTPUT -->
  <section id="output">
    <h2>📤 Expected Output</h2>
<pre><code>========== STUDENTS ==========

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

========== REVIEWS ==========</code></pre>
  </section>

  <!-- VERSIONS -->
  <section id="versions">
    <h2>🔄 Project Versions</h2>

    <h3>Version 1 — Basic Implementation</h3>
    <p>The first version focuses on:</p>
    <ul>
      <li>C# fundamentals</li>
      <li>Classes and Objects</li>
      <li>Constructors</li>
      <li>Collections</li>
      <li>Basic relationships</li>
      <li>Basic OOP</li>
    </ul>
    <p>It intentionally does not focus on SOLID.</p>

    <h3>Version 2 — Refactoring &amp; SOLID</h3>
    <p>The second version refactors the project and introduces:</p>
    <ul>
      <li>SRP</li>
      <li>OCP</li>
      <li>LSP</li>
      <li>ISP</li>
      <li>DIP</li>
      <li>Interfaces</li>
      <li>Polymorphism</li>
      <li>Better separation of responsibilities</li>
      <li>More extensible course pricing</li>
    </ul>
    <p>This is the current SOLID-focused implementation.</p>
  </section>

  <!-- FUTURE -->
  <section id="future">
    <h2>🌱 Future Improvements</h2>

    <h3>🔐 Authentication</h3>
    <ul>
      <li>Student registration</li>
      <li>Instructor registration</li>
      <li>Admin authentication</li>
      <li>JWT Authentication</li>
      <li>Role-based authorization</li>
    </ul>

    <h3>🔍 Search &amp; Filtering</h3>
    <ul>
      <li>Search courses</li>
      <li>Filter by category</li>
      <li>Filter by level</li>
      <li>Filter by price</li>
      <li>Filter by instructor</li>
    </ul>

    <h3>📊 Dashboards</h3>
    <ul>
      <li>Student Dashboard</li>
      <li>Instructor Dashboard</li>
      <li>Admin Dashboard</li>
    </ul>

    <h3>💳 Payments</h3>
    <p>A future version can introduce <code>IPaymentMethod</code> with implementations such as:</p>
    <ul>
      <li><code>CreditCardPayment</code></li>
      <li><code>CashPayment</code></li>
      <li><code>PayPalPayment</code></li>
      <li><code>WalletPayment</code></li>
    </ul>
    <p>This would provide another practical example of Abstraction, OCP, DIP, and Polymorphism.</p>

    <h3>🗄️ Database</h3>
    <ul>
      <li>SQL Server</li>
      <li>Entity Framework Core</li>
      <li>Database Migrations</li>
      <li>Relationships</li>
      <li>CRUD Operations</li>
    </ul>

    <h3>🌐 Backend</h3>
    <ul>
      <li>ASP.NET Core Web API</li>
      <li>RESTful APIs</li>
      <li>JWT Authentication</li>
      <li>Dependency Injection</li>
      <li>Repository Pattern</li>
      <li>Service Layer</li>
    </ul>

    <h3>🧪 Testing</h3>
    <ul>
      <li>Unit Testing</li>
      <li>xUnit</li>
      <li>Mocking</li>
      <li>Integration Testing</li>
    </ul>

    <h3>🏛️ Architecture</h3>
    <ul>
      <li>Clean Architecture</li>
      <li>Separation of Concerns</li>
      <li>Service Layer</li>
      <li>Repository Layer</li>
    </ul>
  </section>

  <!-- API -->
  <section id="api">
    <h2>🔌 Future API Endpoints</h2>
    <p>A future ASP.NET Core Web API version could expose:</p>
<pre><code>GET     /api/students
POST    /api/students

GET     /api/courses
POST    /api/courses
GET     /api/courses/{id}

POST    /api/enrollments

POST    /api/payments

POST    /api/reviews
GET     /api/courses/{id}/reviews</code></pre>
    <div class="note">
      These endpoints are planned for a future ASP.NET Core Web API version and are not part of the current Console Application.
    </div>
  </section>

  <!-- OUTCOMES -->
  <section id="outcomes">
    <h2>🎓 Learning Outcomes</h2>
    <p>After completing this project, the team practiced:</p>
    <ul>
      <li>✅ Building a C# application from scratch</li>
      <li>✅ Creating classes and objects</li>
      <li>✅ Using constructors</li>
      <li>✅ Working with collections</li>
      <li>✅ Modeling real-world entities</li>
      <li>✅ Creating object relationships</li>
      <li>✅ Understanding inheritance</li>
      <li>✅ Understanding polymorphism</li>
      <li>✅ Using abstraction and interfaces</li>
      <li>✅ Applying SOLID principles</li>
      <li>✅ Refactoring existing code</li>
      <li>✅ Separating responsibilities</li>
      <li>✅ Designing extensible code</li>
      <li>✅ Preparing a project for future API and database integration</li>
    </ul>
  </section>

  <!-- ROADMAP -->
  <section id="roadmap">
    <h2>🏛️ Architecture Roadmap</h2>
    <div class="diagram">C# Console Application
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
Authentication &amp; Authorization
        ↓
     Frontend
        ↓
Complete E-Learning Platform</div>
  </section>

  <!-- NOTES -->
  <section id="notes">
    <h2>📌 Important Design Notes</h2>

    <h3>SOLID</h3>
    <p>The project demonstrates the five official SOLID principles:</p>
    <ul>
      <li><strong>S</strong> → Single Responsibility Principle</li>
      <li><strong>O</strong> → Open/Closed Principle</li>
      <li><strong>L</strong> → Liskov Substitution Principle</li>
      <li><strong>I</strong> → Interface Segregation Principle</li>
      <li><strong>D</strong> → Dependency Inversion Principle</li>
    </ul>

    <h3>Inheritance</h3>
    <div class="warn">
      Inheritance is <strong>not a sixth SOLID principle</strong>. It is an Object-Oriented Programming concept used in this project to support code reuse, polymorphism, and specialized course types.
    </div>

    <h3>Dependency Inversion vs Dependency Injection</h3>
    <p>The current project demonstrates <strong>Dependency Inversion</strong> by making <code>Payment</code> depend on <code>IEnrollment</code> instead of <code>Enrollment</code>.</p>
    <p>A future version can implement full <strong>Dependency Injection</strong> using:</p>
    <ul>
      <li>Constructor Injection</li>
      <li>.NET DI Container</li>
      <li>Service Registration</li>
    </ul>
  </section>

  <!-- TEAM CARDS -->
  <section>
    <h2>👨‍💻 Team</h2>
    <div class="team-grid">
      <div class="team-card"><div class="role">🏗️ Project Owner</div><div class="name">Ibrahim Mohamed Elghazaly</div></div>
      <div class="team-card"><div class="role">🔵 SRP</div><div class="name">Mohamed Saeed</div></div>
      <div class="team-card"><div class="role">🟢 OCP</div><div class="name">Ziad Elfeky</div></div>
      <div class="team-card"><div class="role">🟡 LSP</div><div class="name">Ahmed Khalifa</div></div>
      <div class="team-card"><div class="role">🟠 OOP / Inheritance</div><div class="name">Ghofran Mohamed</div></div>
      <div class="team-card"><div class="role">🔴 DIP</div><div class="name">Youssef Hegazy</div></div>
      <div class="team-card"><div class="role">🟣 ISP</div><div class="name">Team</div></div>
    </div>
  </section>

  <!-- VISION -->
  <section>
    <h2>⭐ Project Vision</h2>
    <p>The goal is to transform the current educational Console Application into a complete and scalable E-Learning Platform.</p>
    <div class="diagram">Console App
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
Complete E-Learning Platform</div>
  </section>

  <!-- FINAL -->
  <section>
    <h2>❤️ Final Message</h2>
    <p>This project represents a practical learning journey from basic C# programming and OOP to SOLID principles, refactoring, abstraction, polymorphism, and clean code.</p>
    <p>It provides a foundation that can later evolve into a complete ASP.NET Core + SQL Server E-Learning Platform.</p>
    <div class="success" style="text-align:center;">
      <strong>Made with ❤️ by Ibrahim Mohamed Elghazaly &amp; Team</strong>
    </div>
  </section>

  <footer>
    <p>🎓 E-Learning Platform — C# / .NET Console Application</p>
    <p style="margin-top:6px;">Made with <span class="heart">❤️</span> by Ibrahim Mohamed Elghazaly &amp; Team</p>
  </footer>

</div>

<a href="#" class="top" title="Back to top">↑</a>
</body>
</html>
