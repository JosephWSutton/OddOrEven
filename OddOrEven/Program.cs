using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            IsOdd(3); 
        }

        public static bool IsOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
                return false;
            }
            else
            {
                Console.WriteLine("The number is odd");
                return true;
            }
        }

    }
}
