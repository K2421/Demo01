using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{

    // Program.Main();

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku: ");
            string rivi = Console.ReadLine(); // "3"
            //int luku = int.Parse(rivi); // "3" -> 3
            int luku;
            bool onnistuiko = int.TryParse(rivi, out luku);
            if(onnistuiko == true)
            {
                switch (luku)
                {
                    case 1: Console.WriteLine("Yksi"); break;
                    case 2: Console.WriteLine("Kaksi"); break;
                    case 3: Console.WriteLine("Kolme"); break;
                    default: Console.WriteLine("Joku muu luku"); break;
                }
             }
        else
            {
                Console.WriteLine("Et antanut lukua");
            }

            Console.ReadLine(); // odottaa kunnes enteriä on painettu


        }
    }
}
