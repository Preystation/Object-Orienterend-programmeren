using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExcercises
{
   
    internal class ClassesAndObjects
    {
        public static void ShowSubmenu()
        {
            Console.WriteLine("Uit te voeren oefening?" +
               "\n1. H10-Clock");
               

            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    H10_CombinationOf2Numbers();
                    break;
                
                default:
                    Console.WriteLine("Onbekende waarde");
                    break;
            }
        }
        
        /*
         
         Oefening: H10-CombinationOf2Numbers
Leerdoelen
werken met klassen en objecten

instantieattributen

instantiemethoden

Functionele analyse
Dit programma geeft op basis van de input van twee getallen de som van beide getallen, het verschil, het product en de deling. In het laatste geval en indien er een deling door nul zou worden uitgevoerd, wordt er "Fout!" weergegeven.

Technische analyse
Voorzie voor volgende oefening eerst een nieuwe submenuklasse met als naam ClassesAndObjects.

Maak ook een eigen klasse CombinationOf2Numbers in een eigen file, CombinationOf2Numbers.cs. Deze klasse bevat 2 getallen (type int). Er zijn 4 methoden, die allemaal een double teruggeven:

Sum: geeft som van beide getallen weer

Difference: geeft verschil van beide getallen weer

Product: geeft product van beide getallen weer

Quotient: geeft deling van beide getallen weer. Print "Fout" naar de console indien je zou moeten delen door 0 en voer dan de deling uit. Wat er dan gebeurt, is niet belangrijk.

Gebruik public attributen Number1en Number2. Plaats onderstaande code in een publieke statische methode van ClassesAndObjectsmet naam DemoCombinationOf2Numbersmet return type void:
         */

        public static void H10_CombinationOf2Numbers()
        {

        }
    }
}
