using System;
using static System.Console;

class Perfect
{
    static void Main()
    {
       Write("");
        int number = int.Parse(ReadLine());

        if (Perfection(number))
        {
            Write("Perfect Number");
        }
        else
        {
            Write("Not A Perfect Number");
        }
    }

    static bool Perfection(int number)
    {
        int sum = 0;
        for (int a = 1; a < number; a++)
        {
            if (number % a == 0)
            {
                sum += a;
            }
        }
        return sum == number;
    }
}