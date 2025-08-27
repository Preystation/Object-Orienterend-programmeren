using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExcercises
{
    internal class Course
    {
        public static void ShowSubmenu()
        {
            Console.WriteLine("Uit te voeren oefening?" +
               "\n1. H10-Clock");


            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                   
                    break;

                default:
                    Console.WriteLine("Onbekende waarde");
                    break;
            }
        }
    }
}
