namespace TrainTheTrainers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countJudges = int.Parse(Console.ReadLine());
            double totalRate = 0;
            double countI = 0;

            while (true)
            {
                string projectName = Console.ReadLine();
                double rate = 0;

                if (projectName != "Finish")
                {
                    for (int i = 0; i < countJudges; i++)
                    {
                        rate += double.Parse(Console.ReadLine());
                        countI++;
                    }

                    double currentTotalRate = rate / countJudges;
                    totalRate += rate;

                    Console.WriteLine($"{projectName} - {currentTotalRate:F2}.");
                }
                else
                {
                    totalRate /= countI;
                    Console.WriteLine($"Student's final assessment is {totalRate:F2}.");
                    break;
                }
            }
        }
    }
}
