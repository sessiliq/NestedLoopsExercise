namespace EqualSumEvenOddPosition
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string number1AsString = Console.ReadLine();
            string number2AsString = Console.ReadLine();

            int number1 = int.Parse(number1AsString);
            int number2 = int.Parse(number2AsString);


            for (int i = number1; i < number2 + 1; i++)
            {
                string iAsString = i.ToString();
                int sumEvenPosition = 0;
                int sumOddPosition = 0;

                for (int j = 0; j < iAsString.Length; j++)
                {
                    char numberAsChar = iAsString[j];

                    int number = int.Parse(numberAsChar.ToString());

                    if (j % 2 == 0)
                    {
                        sumEvenPosition += number;
                    }
                    else
                    {
                        sumOddPosition += number;
                    }
                }

                if (sumOddPosition == sumEvenPosition)
                {
                    Console.Write(iAsString + " ");
                }
            }
        }
    }
}
