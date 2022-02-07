using System;
namespace Assignment
{
    class Celsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the amount of Celsius:");
            int celisius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kelvin = {0}", celisius + 273);
            Console.WriteLine("Fahrenheit={0}", celisius * 18 / 10 + 32);
        }
    }
}