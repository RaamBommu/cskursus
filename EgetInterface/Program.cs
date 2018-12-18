using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgetInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            IDbFunktioner h1 = new Hund() { Navn = "Tommy" };

            IDbFunktioner u1 = new Ubåd() { Nummer = 1, Tubine = 23232 };
            h1.Gem();
            u1.Gem();


            List<IDbFunktioner> IDBList = new List<IDbFunktioner>();

            IDBList.Add(new Hund() { Navn = "Jimmy" });
            IDBList.Add(new Ubåd() { Nummer = 3, Tubine = 3223245 });

            foreach (var item in IDBList)
            {
                item.Gem();
            }

            Console.WriteLine("*** List of items present ***" + IDBList.Count);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        interface IDbFunktioner
        {
            void Gem();
        }
        class Hund:IDbFunktioner
        {
            public string Navn { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer hund " + Navn);
            }
        }

        class Ubåd:IDbFunktioner
        {

            public int Nummer { get; set; }
            public double Tubine { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer ubåd nummber" + Nummer );
                Console.WriteLine("Gemmer ubåd tubine" + Tubine);
            }
        }
    }
}
