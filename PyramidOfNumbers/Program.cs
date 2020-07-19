namespace PyramidOfNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = 0;

            for (int rows = 1; rows <= number; rows++)
            {
                for (int cols = 0; cols < rows; cols++)
                {
                    n++;

                    Console.Write(n + " ");

                    if (n == number)
                    {
                        break;
                    }
                }

                Console.WriteLine();
                if (n == number)
                {
                    break;
                }
            }
        }
    }
}
