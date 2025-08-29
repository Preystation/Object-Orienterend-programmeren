using System.Diagnostics;

namespace SchoolAdmin
{
    internal class Program
    {

        public static void DemoCourses()
        {

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
        }
        public static void DemoStudents()
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.Name = "Said Aziz";
            s1.StudentNumber++;
            s2.Name = "Mieke Vermeulen";
            s2.StudentNumber++;
            s1.BirthDay = new DateTime(2000, 07, 01);
            s2.BirthDay = new DateTime(1998, 01, 01);
            s1.RegisterCourseResult("Communicatie", 12);
            s1.RegisterCourseResult("Programmeren",15);
            s1.RegisterCourseResult("Webtechnologie", 13);
            s2.RegisterCourseResult("Databanken",14);
            s2.RegisterCourseResult("Programmeren", 12);
            s2.RegisterCourseResult("Communicatie", 13);


            s1.ShowOverview();
            s2.ShowOverview();
                /*;
            Console.WriteLine(s1.DetermineWorkload());
            Console.WriteLine(s2.GenerateNameGard());
            Console.WriteLine(s2.DetermineWorkload());*/
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Wat wil je doen?" +
                "\nDemoStudents" +
                "\nDemoCourses");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    DemoStudents();
                    break;
                case 2:
                    DemoCourses();
                    break;
                default:
                    Console.WriteLine("Onbekende keuze");
                    break;
            }
}
    }
}
