using static System.Console;


namespace project292
{

    class TemperaturesComparison
    {
        public static void Main()
        {
            const int MinTemperature = -30;
            const int MaxTemperature = 130;
            const int NumberOfTemperatures = 5;

            int[] temperatures = new int[NumberOfTemperatures];
            bool isAscending = true;
            bool isDescending = true;
            int sum = 0;

            for (int i = 0; i < NumberOfTemperatures; i++)
            {
                Write("Temperature ");
                int temperature;
                bool isValidTemperature = int.TryParse(ReadLine(), out temperature);

                if (!isValidTemperature || temperature < MinTemperature || temperature > MaxTemperature)
                {
                    WriteLine($"Temperature {temperature} is invalid, Please enter a valid temperature between -30 and 130");
                    i--;
                    continue;
                }

                temperatures[i] = temperature;
                sum += temperature;

                if (i > 0)
                {
                    if (temperature < temperatures[i - 1])
                    {
                        isAscending = false;
                    }
                    else if (temperature > temperatures[i - 1])
                    {
                        isDescending = false;
                    }
                }
            }

            WriteLine();

            if (isAscending && !isDescending)
            {
                WriteLine("Getting warmer");
            }
            else if (!isAscending && isDescending)
            {
                WriteLine("Getting cooler");
            }
            else
            {
                WriteLine("It's a mixed bag");
            }

            WriteLine("5-day Temperature: [{0}]", string.Join(", ", temperatures));
            WriteLine("Average Temperature is {0} degrees", (double)sum / NumberOfTemperatures);
        }
    }
}