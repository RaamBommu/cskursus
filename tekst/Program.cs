using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekst
{
    class Program
    {
        static void Main(string[] args)
        {

            String forNavn = "Raam xx";

            String efterNavn = "Bommu";

            String navn = forNavn + " " + efterNavn;

            String splitNavn;

            int spacePosition;

            Console.WriteLine("Navn:" + navn);

            Console.WriteLine("Upper case name:" + navn.ToUpper());

            Console.WriteLine("Lower case name:" + navn.ToLower());

            Console.WriteLine(forNavn + "\r\n\t " + efterNavn); 

            Console.WriteLine(navn.Contains(" "));

            Console.WriteLine(navn.IndexOf(" "));

            Console.WriteLine(navn.Length);

            spacePosition = navn.Length - (navn.IndexOf(" ") + 1);

            Console.WriteLine("Space position:" + spacePosition);

            Console.WriteLine(navn.Substring(navn.IndexOf(" ") + 1, (navn.Length - (navn.IndexOf(" ") + 1))));

            var tt = navn.Split(' '); // this can be used to place the words in a sentance into an array. now tt is an array which contains first and last name in two instincts

            Console.WriteLine(tt[tt.Length-1]);
            //splitNavn = navn.Substring(navn.Contains.(" "),); 

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
