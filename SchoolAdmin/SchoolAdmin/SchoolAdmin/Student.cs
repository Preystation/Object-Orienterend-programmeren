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
         */
    }
}
