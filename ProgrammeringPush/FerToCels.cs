using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter
{
    class FerToCelcs
    {
        double celciusRate = 32;

        //funktion som konverterar celcius till ferenheit
        public double convertToCelcius(double ferInsert, double celciusRate)
        {
            return (double)(ferInsert - celciusRate) / 1.8;
        }

        //printmethod
        public void Print()
        {
            Console.WriteLine("Skriv in antal ferenheit");
            double ferInsert = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Det motsvarar {0} celcius", convertToCelcius((double)ferInsert, celciusRate));
            Console.ReadKey();

        }

    }
}
