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
        public int Age
        {
            get
            {
                int year = DateTime.Now.Year - BirthDay.Year;

            
                if (DateTime.Now.Month < BirthDay.Month ||
                    (DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day < BirthDay.Day))
                {
                    year--;
                }

                return year;
            }
        }

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
            Console.WriteLine($"{GenerateNameGard()} ({Age})");
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
        public int Id;
        private static int MaxId = 1;
        public static List<Course> AllCourses = new List<Course>();
        public int id { get; }
        public int CreditPoints { get; private set; }
        
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
            public string Name { get; set; }
            public double Result
        {
            get { ;return Result; }
            set
            {
                if (value <= 20)
                {
                    Result= value;
                }
                else
                {
                    Console.WriteLine("Ongeldige waarde.");
                }
            }
        }

        }
       
}
