using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgavevariabel
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;
            i++;
            i--;

            i += 20;

            Console.WriteLine(i);
            Console.WriteLine($"Heltal = {i}");

            decimal j;
            j= 12.5M;

            j++;
            j--;
            j *= 2;

            Console.WriteLine($"kommatal = {j}");
            

            double kommatal;
            kommatal = 12.5;

            kommatal ++;
            kommatal --;
            kommatal  *= 2;

            Console.WriteLine($"kommatal = {kommatal}");
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
