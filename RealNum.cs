using System;
namespace Assignment
{
    class RealNum
    {
        static void Main()
        {
            int i, n = 10, sum = 0;
            int avg;

            Console.WriteLine("Read 10 real numbers and find the avg of the sum");
            {
                for (i = 0; i <= n; i++)
                {
                    Console.Write("Number ", i);
                    n = Convert.ToInt32(Console.ReadLine());
                    sum += n;

                }
                avg = sum / 10;
                Console.Write("The sum of 10 num", +sum);
                Console.Write("\n");
                Console.Write("The avg of 10 num", +avg);
            }
        }
    }
}
