using System;
using static System.Console;

namespace ConsoleApp2
{
    public class YesSales
    {
        public static void Main()
        {
            string[] names = { "D", "E", "F" };
            char[] initials = { 'D', 'E', 'F' };
            int[] sales = new int[3];
            int mostmoney = 0;

            WriteLine("Enter the salesperson initials (D, E, or F)");


            var topearner = '\0';
            while (true)
            {
                Write("salesperson: ");
                char input = char.ToUpper(ReadKey().KeyChar);
                WriteLine();

                if (input == 'Z')
                    break;

                int index = Array.IndexOf(initials, input);
                if (index == -1)
                {
                    WriteLine("Error: Invalid salesperson selected. Please try again.");
                    continue;
                }

                Write("sale: ");
                int sale = int.Parse(ReadLine());

                sales[index] += sale;

                if (sale > mostmoney)
                {
                    mostmoney = sale;
                    topearner = input;
                }
            }


            WriteLine();
            string cash = (sales[0] + sales[1] + sales[2]).ToString("C0");
            WriteLine($"Grand Total: {cash}");
            WriteLine($"Highest Sale: {names[Array.IndexOf(initials, topearner)]}");

            ReadKey();
        }
    }
}