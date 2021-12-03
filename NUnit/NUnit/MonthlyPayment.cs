using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    class MonthlyPayment
    {
        public void Payment(double P,double Y,double R)
        {
            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = P * r / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Monthly Payment is = {0}",payment);
        }
    }
}
