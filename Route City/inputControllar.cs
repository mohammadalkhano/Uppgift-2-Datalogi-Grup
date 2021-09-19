using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_City
    {
    class inputControllar
        {
        private static void bussLogo()              //Logo till programet 
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
        
        public static void chooseStations()     // meny för att välja hållplatser
            {
            bussLogo();
            Console.WriteLine("Mata in ett nummer mellan [0]-[9] som motsvarar hållplatsen du vill åka till:" +
                "\n\n[0] A\t [1] B\t [2] C\t [3] D\t [4] E\t [5] F\t [6] G\t [7] H\t [8] I\t [9] J\n");

            Console.Write("Från hållplats : ");
            int start = intControllar(9,0);
            Console.Write("Till hållplats : ");
            int end = intControllar(9,0);

            Route_City.RuteCity.Dijkstra(Program.graph(),start,end);        //Räknar ut vägen från start till end.
            Console.WriteLine();
            omStar();
            }
        private static void omStar()                    // meny för att kuna välja att stänga eller starta om programmet
            {                                           //och en rekrusiva metod som anropar sig själv.
            Console.WriteLine("[O]För starta om \n[S]För stänga ner");
            var userInput = Console.ReadLine().ToLower();
           
            if (userInput != "o" && userInput != "s")               // Kollar om input är inte (s) och (o) 
                {
                Console.Clear();
                bussLogo();
                Console.WriteLine("Fel input försök igen");   
                omStar();
                }
            else if (userInput == "o")
                {
                Console.Clear();
                inputControllar.chooseStations();
                }
            else if (userInput == "s")
                {
                Console.WriteLine("Välkommen Åter");
                System.Environment.Exit(0);
                }
            }
        public static int intControllar(int maxValue, int minValue)         // metoden contrullerar inputen 
            {
            int check;                                                      //Kolla om input och input har maxValue och minValue.
            while (!Int32.TryParse(Console.ReadLine(),out check)|| check > maxValue || check < minValue) 
                {                                                           
                Console.WriteLine("Du har skrivt ett fel input försök igen.");  //skickar in ett medalande.
                }
            return check;
            }
        }
    }

