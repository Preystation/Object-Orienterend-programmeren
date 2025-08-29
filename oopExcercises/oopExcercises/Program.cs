namespace oopExcercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de oefeningen van Objectgeoriënteerd Programmeren!" +
                "Topic van de uit te voeren oefening?" +
                "\n1. DateTime" +
                "\n2. Properties en access modifiers" 
               );
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    DateTimeExercises.ShowSubmenu();
                    break;

                case 2:
                    ClassesAndObjects.ShowSubmenu();
                    break;
              
                default:
                    Console.WriteLine("Onbekende waarde");
                    break;
            }
        }
    }
}
