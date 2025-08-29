using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{

    class Student
    {
        //Data
        public string Name;
        public DateTime BirthDay;
        public uint StudentNumber;
        private List<CourseResult> coursesResults = new List<CourseResult>();
        public static uint StudentCounter;
        //Functionaliteit

        public string GenerateNameGard()
        {
            return $"{Name} (Student)";
        }
        public double DetermineWorkload()
        {
            return coursesResults.Count * 10;
        }

        public void RegisterCourseResult(string course,double result)
        {
            if (result > 20)
            {
                Console.WriteLine("Ongeldige cijfer");
            }
            else
            {
                CourseResult cr = new CourseResult();
                cr.Name = course;
                cr.Result = result;
                coursesResults.Add(cr);
            }

        }
        public double Average()
        {
            double som = 0;
            foreach (CourseResult courseResult in coursesResults)
            {
                som = som+courseResult.Result;
            }
            return som / coursesResults.Count;
        }
        public void ShowOverview()
        {
            Console.WriteLine(GenerateNameGard());
            Console.WriteLine($"Werkbelasting {DetermineWorkload()}");
            Console.WriteLine("Cijferraport");
            Console.WriteLine("************");
            foreach (CourseResult cr in coursesResults)
            {
                Console.WriteLine($"{cr.Name}: {cr.Result}");
            }
            Console.WriteLine($"Gemiddelde:{Average():f02}");
            Console.WriteLine("");
        }
    }

    class Course
    {
        public string Title;
        public List<Student> Students = new List<Student>();

        public void ShowOverview()
        {

            Console.WriteLine($"{Title}");

            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name}");
            }
            Console.WriteLine("");

        }
    }
    class CourseResult
        {
            public string Name;
            public double Result;
        }
        /*
         Oef 01 
            public string Name;
            public DateTime BirthDay;
            public uint StudentNumber;
            public List<string> Courses = new List<string>();
            public static uint StudentCounter;

        Student s1 = new Student();
                Student s2 = new Student();
                s1.Name = "Said Aziz";
                s1.StudentNumber++;
                s2.Name = " Mieke Vermeulen";
                s2.StudentNumber++;
                s1.BirthDay = new DateTime(2000, 07, 01);
                s2.BirthDay = new DateTime(1998, 01, 01);
                s1.Courses.Add("Programmeren");
                s1.Courses.Add("Databanken");
                s2.Courses.Add("Communicatie");


        oef 02
               //Data
            public string Name;
            public DateTime BirthDay;
            public uint StudentNumber;
            public List<string> Courses = new List<string>();
            public static uint StudentCounter;
            //Functionaliteit

            public string GenerateNameGard()
            {
                return $"{Name} (Student)";
            }
            public double DetermineWorkload()
            {
                return Courses.Count * 10;
            }

         Student s1 = new Student();
                Student s2 = new Student();
                s1.Name = "Said Aziz";
                s1.StudentNumber++;
                s2.Name = "Mieke Vermeulen";
                s2.StudentNumber++;
                s1.BirthDay = new DateTime(2000, 07, 01);
                s2.BirthDay = new DateTime(1998, 01, 01);
                s1.Courses.Add("Programmeren");
                s1.Courses.Add("Databanken");
                s2.Courses.Add("Communicatie");


                Console.WriteLine(s1.GenerateNameGard());
                Console.WriteLine(s1.DetermineWorkload());
                Console.WriteLine(s2.GenerateNameGard());
                Console.WriteLine(s2.DetermineWorkload());
        oef 03

        //Data
        public string Name;
        public DateTime BirthDay;
        public uint StudentNumber;
        private List<string> courses = new List<string>();
        public static uint StudentCounter;
        //Functionaliteit

        public string GenerateNameGard()
        {
            return $"{Name} (Student)";
        }
        public double DetermineWorkload()
        {
            return courses.Count * 10;
        }

        public void RegisterForCourse(string course)
        {
            courses.Add(course);
        }
        Student s1 = new Student();
            Student s2 = new Student();
            s1.Name = "Said Aziz";
            s1.StudentNumber++;
            s2.Name = "Mieke Vermeulen";
            s2.StudentNumber++;
            s1.BirthDay = new DateTime(2000, 07, 01);
            s2.BirthDay = new DateTime(1998, 01, 01);
            s1.RegisterForCourse("Programmeren");
            s1.RegisterForCourse("Databanken");
            s2.RegisterForCourse("Communicatie");


            Console.WriteLine(s1.GenerateNameGard());
            Console.WriteLine(s1.DetermineWorkload());
            Console.WriteLine(s2.GenerateNameGard());
            Console.WriteLine(s2.DetermineWorkload());

          oef 04

            Course c1 = new Course();
            Course c2 = new Course();
            Course c3 = new Course();
            Course c4 = new Course();

            c1.Title = "communicatie";
            c2.Title = "programmeren";
            c3.Title = "webtechnologie";
            c4.Title = "databanken ";

            Student s1 = new Student();
            Student s2 = new Student();
            s1.Name = "Said Aziz";
            s1.StudentNumber++;
            s2.Name = "Mieke Vermeulen";
            s2.StudentNumber++;
            c1.Students.Add(s1);
            c2.Students.Add(s1);
            c3.Students.Add(s1);

            c1.Students.Add(s2);
            c2.Students.Add(s2);
            c4.Students.Add(s2);
            c1.ShowOverview();
            c2.ShowOverview();
            c3.ShowOverview();
            c4.ShowOverview();
        
            class Course
    {
        public string Title;
        public List<Student> Students = new List<Student>();

        public void ShowOverview()
        {

            Console.WriteLine($"{Title}");

            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name}");
            }
            Console.WriteLine("");

        }
         */

    
}
