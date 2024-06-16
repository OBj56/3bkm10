using System;
using static System.Console;

namespace ConsoleApp1
{
    public class HomeSales
    {
        public static void Main()
        {

            int daniel = 0;
            int edward = 0;
            int francis = 0;


            char topearner = '\0';


            int mostmoney = 0;
            WriteLine("Enter the salesperson initials (D, E, or F) or Z to quit:");


            while (true)
            {
                Write("salesperson: ");
                char names = char.ToUpper(ReadKey().KeyChar);
                WriteLine();

                if (names == 'Z')
                    break;

                if (names != 'D' && names != 'E' && names != 'F')
                {
                    WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
                    continue;
                }

                Write("sale: ");
                int sale = int.Parse(ReadLine());


                if (names == 'D')
                    daniel += sale;
                else if (names == 'E')
                    edward += sale;
                else if (names == 'F')
                    francis += sale;

                if (sale > mostmoney)
                {
                    mostmoney = sale;
                    topearner = names;
                }
            }


            int grandTotal = daniel + edward + francis;

            WriteLine();
            WriteLine($"Grand Total: {grandTotal}");
            WriteLine($"Highest Sale: {topearner}");

            ReadKey();
        }
    }
}