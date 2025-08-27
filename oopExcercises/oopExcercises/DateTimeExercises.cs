using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExcercises
{
    internal class DateTimeExercises
    {
        public static void ShowSubmenu()
        {
            Console.WriteLine("Uit te voeren oefening?" +
                "\n1. H10-Clock" +
                "\n2. H10-Birthday");

            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    H10_Clock();
                    break;

                case 2:
                    H10_Birthday();
                    break;
                default:
                    Console.WriteLine("Onbekende waarde");
                    break;
            }
        }
        public static void H10_Clock()
        {
            while (true)
            {
                Console.Clear();
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString("T"));
                System.Threading.Thread.Sleep(1000);
            }

        }
        public static void H10_Birthday()
        {
            Console.WriteLine("Bestaande datum gebruiken of zelf invullen?(1 voor ingevulde waarde 2 voor waarde in te vullen)");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime now = DateTime.Now;
            switch (number)
            {
                case 1:
                    string birthday = "10/08/1992";
                    DateTime birthdayDate = DateTime.Parse(birthday);
                    DateTime nextBirthday = new DateTime(now.Year, birthdayDate.Month, birthdayDate.Day);//Wordt 2025/08/10
                    if (nextBirthday < now)
                    {
                        nextBirthday = nextBirthday.AddYears(1);//Wordt 2026/08/10
                    }

                    TimeSpan diff = nextBirthday - now;
                    if (diff.Days==0)
                    {
                        Console.WriteLine("Proficiat vandaag is het je verjaardag.");
                    }
                    else
                    {
                        Console.WriteLine($"Over {diff.Days} is het u verjaardag.");

                    }
                
                    break;
                case 2:
                    Console.WriteLine("Geef u verjaardag in als 10/08/1992");
                    DateTime birthday2 = Convert.ToDateTime(Console.ReadLine());
                    
                   
                    DateTime nextBirthDay = new DateTime(now.Year, birthday2.Month, birthday2.Day);
                    if (nextBirthDay < now)
                    {
                        nextBirthDay = nextBirthDay.AddYears(1);//Wordt 2026/08/10
                    }

                    TimeSpan diff2 = nextBirthDay - now;
                    if (diff2.Days == 0)
                    {
                        Console.WriteLine("Proficiat vandaag is het je verjaardag.");
                    }
                    else
                    {
                        Console.WriteLine($"Over {diff2.Days} is het u verjaardag.");

                    }
                    break;
                default:

                    Console.WriteLine("Onbekende keuze");
                    break;
            }
        }
    }
}