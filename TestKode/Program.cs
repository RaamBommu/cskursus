using System;

namespace TestKode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test");

            String name = " ";

            name = "Raam";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }



        }
    }
}
