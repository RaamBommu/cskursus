using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structenum
{
    class Program
    {
        static void Main(string[] args)
        {

            FilTyper ft = FilTyper.csv;

            Person p = new Person();

            p.Id = 1;
            p.Navn = "Mikkel";
            p.Køn = Køn.Mand;

     

            Console.WriteLine((int)ft);

            Console.WriteLine($"Person's name is :{p.Navn}");

            Console.WriteLine($"Køn{p.Køn}");x

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
        
        enum FilTyper
        {
            csv,
            pdf,
            txt 
        }


        struct Person
        {
            public int Id;
            public string Navn;
            public Køn Køn;
        }

        enum Køn
        {
            Mand,
            Kvinde

        }
        
    }
}
