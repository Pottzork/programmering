using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter
{
    class Algo1
    {
        int b;
        int h;

        public double calcOmkrets(int b, int h)
        {
            return (double)(b + b) + (h + h);
        }

        public double calcArea(int b, int h)
        {
            return (double)b * h;
        }

        public void Print()
        {
            Console.WriteLine("Beräkna omkrets och area av en rektangel");
            Console.WriteLine("Ange längd Bas");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ange längd för Höjd");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Omkrets: {0}", calcOmkrets((int)b, (int)h));
            Console.WriteLine("Area: {0}", calcArea((int)b, (int)h));
            Console.ReadKey();
        }
    }
}
