using System;

namespace Uppgifter
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1) Moneyconverter");
            Console.WriteLine("2) Beräkna rektangel omkrets och area");
            Console.WriteLine("3) Beräkna cirkel Omkrets,area och diameter");
            Console.WriteLine("4) Beräkna ferenheit till celcius");
            int menyVal = Convert.ToInt32(Console.ReadLine()) ;
            switch(menyVal)
            {
                case 1:
                    MoneyConverter money = new MoneyConverter();
                    money.Print();
                    break;

                case 2:
                    Algo1 A1 = new Algo1();
                    A1.Print();
                    break;

                case 3:
                    Algo2 A2 = new Algo2();
                    A2.Print();
                    break;

                case 4:
                    FerToCelcs FC = new FerToCelcs();
                    FC.Print();
                    break;

            }
        }
    }
}
        

