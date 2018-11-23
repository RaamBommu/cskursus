using System;

namespace datotid
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1;

            d1 = DateTime.Now;

            Console.WriteLine(d1.AddDays(10));

            Console.WriteLine(d1.AddMinutes(20));

            Console.WriteLine(d1.AddMonths(-1));

            DateTime d2, d3;

            d2 = new DateTime(2018, 12, 16);
            d3 = new DateTime(2018, 12, 21);

            //Console.WriteLine($"Date d2 {d2}, Date d3 {d3}");

            TimeSpan dayDifference = d3.Subtract(d2);

            Console.WriteLine($"Days difference is {dayDifference.Days} ");

            TimeSpan t2 = new TimeSpan(16,0,0);

            Console.WriteLine($"Time t2 {t2}");

            TimeSpan t3 = new TimeSpan(0, 30, 0);

            Console.WriteLine($"Time t3 {t3}");

            TimeSpan t4 = t2.Subtract(t3);

            Console.WriteLine($"Time difference is {t4} ");

            TimeSpan t5 = t2.Add(t3);

            Console.WriteLine($"Total time {t5}");

            String str = Convert.ToString(d2.Month);

            Console.WriteLine($"Converted string {str}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
