namespace oopExcercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de oefeningen van Objectgeoriënteerd Programmeren!" +
                "Topic van de uit te voeren oefening?" +
                "\n1. DateTime");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                   DateTimeExercises.ShowSubmenu();
                    break;


                default:
                    Console.WriteLine("Onbekende waarde");
                    break;
            }
        }
    }
    }
