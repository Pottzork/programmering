using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter
{
    class MoneyConverter
    {
        
        int dollarRate = 11;
        int pundRate = 13;

    public double sekToDollar(int sek)
        {
            return (double)sek / dollarRate;
        }

     public double sekToPund(int sek)
        {
            return (double)sek / pundRate;
        }

    public void Print()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ange antal kronor");
            int sek = (int)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Dollar: {0}", sekToDollar((int)sek));
            Console.WriteLine("Pund: {0}", sekToPund((int)sek));
            Console.ReadKey();
        }
    }
}
