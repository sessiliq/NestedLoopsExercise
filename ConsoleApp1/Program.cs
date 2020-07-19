using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); // 2
            int b = int.Parse(Console.ReadLine()); // 3

            a += b; // 5
            b = a - b; // 3
            a = a - b;  // 2

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
