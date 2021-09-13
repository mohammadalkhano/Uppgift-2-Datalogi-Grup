using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_City
    {
    class inputControllar
        {
        private static void bussLogo()
            {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t  ____________________________________________________________ ");
            Console.WriteLine("\t\t |     |      |     |     |     |     |     |     |     |     |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t |  () |      |  () |  () |     |  () |  () |     |  () |  () |");
            Console.WriteLine("\t\t |_<  >|______|__||_|__||_|_____|__||_|__||_|_____|__||_|__||_|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t |____________________________________________________________|");

            Console.WriteLine("\t\t |       . ' .              Buss            . ' .             |");
            Console.WriteLine("\t\t (______'  o  '____________________________'  o  '____________)");
            Console.WriteLine("\t\t         ' . '                              ' . '              ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("<<<=============================================================================================<<<");
            }
        public static void buss()
            {
            bussLogo();
            var loop = true;
            while (loop)
                {
                Console.WriteLine("För att stänga ner programmet [S]");
                Console.WriteLine("För att går vidare [V]");

                var userInput = Console.ReadLine().ToLower();
                if (userInput == "s")
                    {
                    loop = false;
                    }
                else if (userInput == "v")
                    {
                    chooseStations();
                    }
                else
                    {
                    Console.WriteLine("fel input försök igen");
                    }
                }
            }
        private static void chooseStations()
            {
            Console.WriteLine("Hållplatser som bussen kör till\n A\t B\t C\t D\t E\t F\t G\t H\t I\t J\n ");
            Console.Write("Från hållplats : ");
            var start = Console.ReadLine().ToLower();
            Console.Write("Till hållplats : ");
            var end = Console.ReadLine().ToLower();
            }
        }
    }


/*

public static char inputControllar()
    {
    char check;
    while (!char[](Console.ReadLine(),out check))             //Kolla om input är inte int så-
        {                                                           //skicka ett medalande att talet är inte int.
        Console.Clear();
        Console.WriteLine("Du har skrivt ett fel input försök igen.");
        }
    return check;
    }
}
*/

