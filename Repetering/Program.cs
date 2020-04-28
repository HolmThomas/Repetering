using System;

namespace Repetering
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Opgave 1.1
            //Console.Write("Indtast en Fahrenheit temperatur: ");
            //double tempFahrenheit = Convert.ToInt32(Console.ReadLine());
            ////double tempCelsius = ((tempFahrenheit - 32) * 5) / 9;
            ////Convert.ToDecimal(string.Format("{0:0.00}", ((tempFahrenheit - 32) * 5) / 9));
            //Console.Write("Den tilsvarende temperatur i Celsius: " + Convert.ToDecimal(string.Format("{0:0.00}", ((tempFahrenheit - 32) * 5) / 9)));

            //Console.ReadKey();

            //// Opgave 1.2
            //Console.Write("Indtast en Celsius temperatur: ");
            //double tempCelsius2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Den tilsvarende temperatur i Fahrenheit: " + Convert.ToDecimal(string.Format("{0:0.00}", ((tempCelsius2 * 9) / 5) +32)));
            //Console.Write("\nDen tilsvarende temperatur i Kelvin: " + Convert.ToDecimal(string.Format("{0:0.00}", ((tempCelsius2 + 273.15)))));
            //Console.Write("\nDen tilsvarende temperatur i Reaumur: " + Convert.ToDecimal(string.Format("{0:0.00}", ((tempCelsius2 * 0.8)))));

            //Console.ReadKey();

            //// Opgave 1.3
            //Console.Write("Indtast et startbeløb: ");
            //double valutaDK = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Hvilken valuta skal der beregnes til\n1. GBP\n2. EUR\n3. USD)");
            //double choiceValuta = Convert.ToDouble(Console.ReadLine());

            //if (choiceValuta == 1)
            //{
            //    Console.WriteLine("Britiske Pund: " + Convert.ToDecimal(string.Format("{0:0.00}", ((valutaDK * 11.24 / 100)))));
            //}
            //if (choiceValuta == 2)
            //{
            //    Console.WriteLine("Britiske Pund: " + Convert.ToDecimal(string.Format("{0:0.00}", ((valutaDK * 7.56 / 100)))));
            //}
            //if (choiceValuta == 3)
            //{
            //    Console.WriteLine("Britiske Pund: " + Convert.ToDecimal(string.Format("{0:0.00}", ((valutaDK * 5.01 / 100)))));
            //}

            //Console.ReadKey();


            //// Opgave 2.1
            ////string[] alderText2 = new string[4];
            //string[] alderText = new string[] { "Du er lige født", "Du kan begynde i Børnehave", "Du går i skole", "Nu begynder alvoren"};

            //Console.Write("Hvad hedder du? ");
            //string navn = Console.ReadLine();

            //Console.Write("Hvor gammel er du? ");
            //int alder = Convert.ToInt32(Console.ReadLine());

            //string text11 = "Dit navn er " + navn + ", du er " + alder + " år gammel. ";

            //if (alder <= 1)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(text11 + alderText[0]);
            //}
            //if (alder >= 2 && alder <= 5)
            //{   
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine(text11 + alderText[1]);
            //}
            //if (alder >= 6 && alder <= 16)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine(text11 + alderText[2]);
            //}
            //if (alder >= 17)
            //{
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.WriteLine(text11 + alderText[3]);
            //}

            //Console.ReadKey();


            //Opgave 2.2
            Console.Write("Hvilken dag på ugen er det?\n1. Mandag\n2. Tirsdag\n3. Onsdag\n4. Torsdag\n5. Fredag\n6. Lørdag\n7. Søndag\n");
            int ugedag = Convert.ToInt32(Console.ReadLine());

            if (ugedag == 1)
            {
                Console.WriteLine("I dag er det Mandag");
            }
            else if (ugedag == 2) 
            {
                Console.WriteLine("I dag er det Tirsdag");
            }
            else if (ugedag == 3)
            {
                Console.WriteLine("I dag er det Onsdag");
            }
            else if (ugedag == 4)
            {
                Console.WriteLine("I dag er det Torsdag");
            }
            else if (ugedag == 5)
            {
                Console.WriteLine("I dag er det Fredag");
            }
            else if (ugedag == 6)
            {
                Console.WriteLine("I dag er det Lørdag");
            }
            else if (ugedag == 7)
            {
                Console.WriteLine("I dag er det Søndag");
            }



            Console.ReadKey();

        }
    }
}
