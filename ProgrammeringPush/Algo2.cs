using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter
{

    //lol
    class Algo2
    {
        double PI = Math.PI;
        // Diameter = raduis * 2
        //omkrets = diameter * PI
        // Area = pi * (Radius * Radius)
        public double DiameterCalc(double insert, double PI)
        {
            return (double)insert * 2;
        }

        public double AreaCalc(double insert, double PI)
        {
            return (double)PI * (insert * insert);
        }

        public double OmkretsCalc(double insert, double Pi)
        {
            return (double)(insert * 2) * PI;
        }

        public void Print()
        {
            Console.WriteLine("Vi ska beräkna en cirkels omkrets, area och diameter");
            Console.WriteLine("Skriv in cirkelns radie");
            double insert = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cirkelns Diameter: {0}", DiameterCalc((double)insert, (double) PI));
            Console.WriteLine("Cirkelns Omkrets: {0}", OmkretsCalc((double)insert, (double)PI));
            Console.WriteLine("Cirkelns Area: {0}", AreaCalc((double)insert, (double)PI));

            Console.ReadKey();

        }
    }

    
}
