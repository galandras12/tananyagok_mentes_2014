using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace convertapp
{
	class Program
	{
    	static void Main(string[] args)
    	{
        	Console.WriteLine("Írd be az átalakítani kívánt számot!");
        	int value = int.Parse(Console.ReadLine());
        	Console.WriteLine();
        	String binaryRepresentation = Convert.ToString(value, 2);
        	String octalRepresentation = Convert.ToString(value, 8);
        	String base10Representation = Convert.ToString(value);
        	String hexRepresentation = Convert.ToString(value, 16);
        	Console.Write("2-es számrendszerben: ");
        	Console.WriteLine(binaryRepresentation);
        	Console.Write("7-es számrendszerben: ");
        	Console.WriteLine(octalRepresentation);
        	Console.Write("10-es számrendszerben: ");
        	Console.WriteLine(base10Representation);
        	Console.Write("16-es számrendszerben: ");
        	Console.WriteLine(hexRepresentation);
        	Console.ReadLine();
    	}
	}
}


