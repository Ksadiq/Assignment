using System;
using System.IO;
namespace readwriteapp
{
    class file
    {
        [STAThread]
        static void Main(string[] args)
        {
            String line;
            try
            {

                StreamReader Rk = new StreamReader("Sadiqtext.txt");

                line = Rk.ReadLine();

                while (line != null)
                {

                    Console.WriteLine(line);

                    line = Rk.ReadLine();
                }

                Rk.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}