using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHeltSimple
{
    class Program
    {

        //public delegate void MinDelegate1(string t);

        static void Main(string[] args)
        {

            Action<string> f1 = MinSkrivTilConsole;

            f1.Invoke("Test");

            Action<string> f2 = MinSkrivTilConsole;

            f2("test2");

            Action<string> f3 = MinSkrivTilConsole;

            f3("test3");

            f3 += Console.WriteLine;

            f3("test3");


            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;

           

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
            
        }
    }
}
