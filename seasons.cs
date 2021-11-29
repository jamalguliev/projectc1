using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ay = 3;
            if (ay < 1 || ay > 12)
            {
                Console.WriteLine("Error");
            }
            else if (ay <= 2 || ay == 12)
            {
                Console.WriteLine("Winter");
            }
            else if (ay < 6)
            {
                Console.WriteLine("Spring");
            }
            else if (ay < 9)
            {
                Console.WriteLine("Summer");
            }
            else
            {
                Console.WriteLine("Autumn ");
            }
        }
    }
}
