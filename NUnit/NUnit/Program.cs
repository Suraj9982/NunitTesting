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
                Console.WriteLine("CHOOSE THE OPTION : \n1.Day of_week\n2.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        DayOfWeek day = new DayOfWeek();
                        day.FindDayOfWeek();
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice should be between 1 to 2");
                        break;
                }

            }
        }
    }
}
