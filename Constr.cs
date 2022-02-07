using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Assign
{
    class Table
    {
        private int wid = 0;
        private int hgt = 0;

        public Table(int width, int height)
        {
            if (width >= 0) this.wid = width;
            if (height >= 0) this.hgt = height;
        }
        public void Data() => Console.WriteLine("Height - {0} cm, width - {1} cm", hgt, wid);
    }
    class Constructor
    {
        static void Main(string[] args)
        {
            Table[] arr = new Table[10];
            Random value = new Random();
            for (int i = 0; i < 10; i++)
                arr[i] = new Table(value.Next(50, 200), value.Next(50, 200));
            foreach (var i in arr)
                i.Data();
        }
    }
}
