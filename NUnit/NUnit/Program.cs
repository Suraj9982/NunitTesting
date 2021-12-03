using System;

namespace NUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE THE OPTION : \n1.Day of_week\n2.Temprature Conversion\n3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        DayOfWeek day = new DayOfWeek();
                        day.FindDayOfWeek();
                        break;
                    case 2:
                        TempratureConversion temp = new TempratureConversion();
                        temp.Conversion();
                        break;
                    case 3:
                        Console.WriteLine("enter the principal");
                        double princ = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the year");
                        double year = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter the rate");
                        double rate = Convert.ToDouble(Console.ReadLine());
                        MonthlyPayment pay = new MonthlyPayment();
                        pay.Payment(princ, year, rate);
                        break;
                    case 4:
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
