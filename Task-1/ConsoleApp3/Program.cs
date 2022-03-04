using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eded = Convert.ToInt32(Console.ReadLine());
            if (eded % 2 == 0)
            {

                Console.WriteLine("eded cutdur");
            }
            else
            {
                Console.WriteLine("eded tekdir");
            }
        }
    }
}

