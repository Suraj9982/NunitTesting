using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    class DayOfWeek
    {
        public void FindDayOfWeek()
        {
            Console.WriteLine("enter the day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Day is "+ FindDay(day,month,year));
        }
        public static int FindDay(int d,int m,int y)
        {

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;

            return d0;
        }
    }
}
