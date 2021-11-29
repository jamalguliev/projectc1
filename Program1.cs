using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 58364; int sum = 0;
            for (int i = n; i > 0; i = i / 10)
            {
                sum = sum + i % 10;
            }
            Console.WriteLine(sum);
            
        }
    }
}
