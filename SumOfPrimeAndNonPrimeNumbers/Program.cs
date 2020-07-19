namespace SumOfPrimeAndNonPrimeNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int sumOfPrimeNumbers = 0;
            int sumOfNonPrimeNumbers = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }

                int number = int.Parse(command);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                var maxDivisor = number / 2 + 1;
                sumOfPrimeNumbers += number;
                for (int i = 2; i < maxDivisor; i++)
                {
                    if (number % i == 0)
                    {
                        sumOfPrimeNumbers -= number;
                        sumOfNonPrimeNumbers += number;
                        break;
                    }
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNumbers}");
        }
    }
}