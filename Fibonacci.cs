using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Fibonaccci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            FibonacciSeries a = new FibonacciSeries();
            int num = a.Fibonacci(Number);
            Console.WriteLine("Number at index position " + Number + " is:" + num);
            Console.ReadLine();
        }

    }
    class FibonacciSeries
    {
        public int Fibonacci(int Number)
        {
            int A = 0;
            int B = 1;
            int sum = 0;
            Console.WriteLine(A + " " + " ");
            int[] a = new int[10];
            a[0] = A;
            Console.WriteLine(a[0]);
            a[1] = B;
            for (int i = 2; i <= a.Length - 1; i++)
            {
                sum = A + B;
                Console.WriteLine(sum + " ");
                a[i] = sum;
                A = B;
                B = sum;
            }
            return a[Number];
        }
    }
}