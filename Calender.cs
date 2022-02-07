using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Assignments
{
    class calender
    {
        static int Year = new int();
        static int Month = new int();
        static int[,] calendar = new int[6, 7];


        static void CalenderHeader()
        {
            Console.Write("\n\n");
            Console.WriteLine("Mo Tu We Th Fr Sa Su ");
        }

        static void FillCalendar()
        {
            int days = DateTime.DaysInMonth(Year, Month);
            int currentDay = 1;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay <= days; j++)
                {
                    if (i == 0 && Month > j)
                    {
                        calendar[i, j] = 0;
                    }
                    else
                    {
                        calendar[i, j] = currentDay;
                        currentDay++;
                    }
                }
            }
        }

        static void CalendarDraw()
        {
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {
                        if (calendar[i, j] < 10)
                        {
                            Console.Write(" " + calendar[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(calendar[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the month : (january = 1) ");
            Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the year:  ");
            Year = Convert.ToInt32(Console.ReadLine());

            CalenderHeader();
            FillCalendar();
            CalendarDraw();
            Console.ReadLine();
        }

    }
}