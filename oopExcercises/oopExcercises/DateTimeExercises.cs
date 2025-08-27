using System;
using System.Collections.Generic;
using System.Globalization;
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
                "\n2. H10-Birthday" +
                "\n3. H10-DayOfTheWeek" +
                "\n4. H10_TicksSince2000" +
                "\n5. H10_LeapYearCount" +
                "\n6. H10_CodeTiming"
                );

            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    H10_Clock();
                    break;

                case 2:
                    H10_Birthday();
                    break;
                case 3:
                    H10_DayOfTheWeek();
                    break;
                case 4:
                    H10_TicksSince2000();
                    break;
                case 5:
                    H10_LeapYearCount();
                    break;
                case 6:
                    H10_CodeTiming();
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
                    
                        nextBirthday = nextBirthday.AddYears(1);//Wordt 2026/08/10
                    

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
                   
                        nextBirthDay = nextBirthDay.AddYears(1);//Wordt 2026/08/10
                    

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
        public static void H10_DayOfTheWeek()
        {
            Console.WriteLine("Welke dag?");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welke maand?");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welke jaar?");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime date = new DateTime(year, month, day);
            CultureInfo dutch = new CultureInfo("nl-be");
            Console.WriteLine($"{date.ToString("d")} is een {date.ToString("dddd",dutch)}");
        }
        public static void H10_TicksSince2000()
        {
            DateTime year2000 = new DateTime(2000, 01, 01);
            DateTime now = DateTime.Now;

            TimeSpan diff = now - year2000;
            Console.WriteLine($"Sinds {year2000.ToString("d")} zijn er {diff.Ticks} ticks voorbijgegaan.");
        }
        public static void H10_LeapYearCount()
        {
            int startyear = 1799;
            int endYear = 2021;
            int yearCounter = 0;

            for (int year = startyear;year<endYear;year++)
            {
                if (DateTime.IsLeapYear(year)) {
                    yearCounter = yearCounter + 1;

                        }

            }
            Console.WriteLine($"Er zijn {yearCounter} schrikkeljaren tussen {startyear} en {endYear}.");
        }
        public static void H10_CodeTiming()
        {
            DateTime start = DateTime.Now;
            int[] numbers = new int[1000000];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            DateTime end = DateTime.Now;
            TimeSpan duration = end - start;
            Console.WriteLine($"Het maken en vullen van de array duurde {duration.Milliseconds} milliseconden");
        }

    }
}