using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lottoszam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a számot");
            int megad = int.Parse(Console.ReadLine();

            Random szam = new Random();
            for (int j = 0; j < 52; j++)
            {
                Console.WriteLine("A(z) {0}.hét nyerőszámai: ", j+1);
                for (int i = 0; i < 5; i++)
                {
                    if (i != 4)
                        Console.Write(szam.Next(90) + ", ");
                    else
                        Console.Write(szam.Next(90));
                }
                Console.Write(System.Environment.NewLine);
            }
            Console.ReadKey();
        }
    }
}


