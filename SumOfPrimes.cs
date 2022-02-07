using System;

namespace Assignment
{
    class SumOfPrimes
    {
        static bool isPrimeNumber(int k)
        {
            if (k == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= k; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int SumOfPrimes()
        {
            Console.WriteLine("Enter the from number: ");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the to number: ");
            int to = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = from; i <= to; i++)
            {
                bool isPrime = isPrimeNumber(i);
                if (isPrime)
                {
                    a = a + i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of Prime Numbers: " + SumOfPrimes());
        }
    }
}