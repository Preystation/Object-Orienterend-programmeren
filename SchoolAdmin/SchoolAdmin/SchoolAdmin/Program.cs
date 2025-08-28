namespace SchoolAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
