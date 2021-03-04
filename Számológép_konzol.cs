using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be az első számot");
            Console.WriteLine("          ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("          ");
            Console.WriteLine("Írd be a második számot");
            Console.WriteLine("          ");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("          ");
            Console.WriteLine("Most válassz műveletet:");
            Console.WriteLine("1 - Összeadás");
            Console.WriteLine("2 - Kivonás ");
            Console.WriteLine("3 - Szorzás");
            Console.WriteLine("4 - Osztás");
            Console.WriteLine("          ");
            int z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine("          ");
                    Console.WriteLine("          ");
                    Console.WriteLine("Az összeadás eredménye:");
                    Console.WriteLine(x + y);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("          ");
                    Console.WriteLine("          ");
                    Console.WriteLine("A kivonás eredménye:");
                    Console.WriteLine(x - y);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("          ");
                    Console.WriteLine("          ");
                    Console.WriteLine("A szorzás eredménye:");
                    Console.WriteLine(x * y);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("          ");
                    Console.WriteLine("          ");
                    Console.WriteLine("Az osztás eredménye:");
                    Console.WriteLine(x / y);
                    Console.ReadKey();
                    break;
            }
        }
    }
}


