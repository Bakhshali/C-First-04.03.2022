using System;

namespace forTASK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eded1= Convert.ToInt32(Console.ReadLine());
            int eded2= Convert.ToInt32(Console.ReadLine());
            if (eded1 > eded2)
            {
                Console.WriteLine("eded1 boyukdur");

            }
            else if (eded1 < eded2)
                Console.WriteLine("eded2 boyukdur");
            else
                Console.WriteLine("ededler bir birbine beraberdiz");

        }
    }
}
