using System;
namespace Assignment
{
    class LeapYear

    {
        static void Main()
        {
            bool leapOrNot = false;
            Console.WriteLine("Enter A Year");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y % 4 == 0 && y % 100 != 0)
            {
                Console.WriteLine("leap Year");
            }
            else if (y % 100 == 0 && y % 400 == 0)
            {
                Console.WriteLine("leap Year");
            }
            else
            {
                Console.WriteLine("Not A Leap Year");
            }
            Console.ReadLine();
        }
    }
}
