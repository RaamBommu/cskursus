using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPolyDyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund { Navn = "Tommy" };
            Kat k = new Kat { Navn = "Kitty" };

            h.SigNoget();
            k.SigNoget();

            

            List<Dyr> dyrs = new List<Dyr>();
            dyrs.Add(new Hund() { Navn = "h1"});
            dyrs.Add(new Kat() { Navn = "k1" });
            dyrs.Add(new Kat() { Navn = "k2" });
            dyrs.Add(new Hund() { Navn = "h2" });

            foreach (var item in dyrs)
            {
                item.SigNoget();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        class Dyr
        {

            public string Navn { get; set; }

            public virtual void SigNoget()
            {
                Console.WriteLine("Jeg er et dyr og heder " + Navn);
            }

        }

        class Hund : Dyr
        {

            public override void SigNoget()
            {
                Console.WriteLine("Jeg er en hund og hedder " + Navn);
            }


        }

        class Kat : Dyr

        {
            public override void SigNoget()
            {
                Console.WriteLine("Jeg er en kat og hedder " + Navn);

            }

        }

    }
}
