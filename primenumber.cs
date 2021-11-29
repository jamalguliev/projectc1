using System;

namespace ConsoleApp6
{
    class Program
    {
        private static int count;

        static void Main(string[] args)
        {
            int num = 5;
            int i = 1; 


            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("This is a Prime Number");
            }
            else
            {
                Console.WriteLine("This is not a Prime Number");
            }


        }
    }
}
