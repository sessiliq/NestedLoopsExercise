namespace PaaswordGenerator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int letter = int.Parse(Console.ReadLine());

            string alphabet = "abcdefghiklmnopqrstuvwxyz";
            for (int i = 1; i < number; i++)
            {
                int firstSymbol = i;

                for (int j = 1; j < number; j++)
                {
                    int secondSymbol = j;

                    for (int k = 0; k < letter; k++)
                    {
                        char thirdSymbol = alphabet[k];

                        for (int l = 0; l < letter; l++)
                        {
                            char fourthSymbol = alphabet[l];

                            for (int m = 1; m <= number; m++)
                            {
                                if (m > firstSymbol && m > secondSymbol)
                                {
                                    int fifthSymbol = m;
                                    Console.Write($"{firstSymbol}{secondSymbol}{thirdSymbol}{fourthSymbol}{fifthSymbol} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
