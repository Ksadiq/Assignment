using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class SumOfevenOdd
    {
        static void Main()
        {
            sumofevenandodds();
        }
        static void sumofevenandodds()
        {
            int evenresult = 0;
            int oddresult = 0;
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the number{i + 1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int j in arr)
            {
                if (j % 2 == 0)
                {
                    evenresult = j + evenresult;
                }
                else
                {
                    oddresult = j + oddresult;
                }
            }
            Console.WriteLine($"Even result is {evenresult} and {oddresult}");
        }
    }
