using System;

namespace OddOrEven
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 0;

            //To Read enter number
            x = int.Parse(Console.ReadLine());

            //To Check number is even or odd
            if (x % 2 == 0)
                Console.WriteLine(x + " is an even number");
            else
                Console.WriteLine(x + " is an odd number");
        }
    }
}
