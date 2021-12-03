using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    class TempratureConversion
    {
        public void Conversion()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION:1.Celsius To Fahrenheit\n2.Fahrenheit to Celcius\n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Celsius");
                        double c = Convert.ToDouble(Console.ReadLine());
                        double f = (c * 9 / 5) + 32;
                        Console.WriteLine("Fahrenheit = {0}",f);
                        break;
                    case 2:
                        Console.WriteLine("Enter the fahrenheit");
                        double fah = Convert.ToDouble(Console.ReadLine());
                        double cel = (fah - 32) * 5 / 9;
                        Console.WriteLine("Celsius = {0}",cel);
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice should be between 1 to 3");
                        break;
                }
            }
        }
    }
}
