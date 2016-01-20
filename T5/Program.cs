using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna sekunnit: ");
            string sek = Console.ReadLine();
            int sec = int.Parse(sek);

            int hour = sec / 3600;
            int min = (sec % 3600) / 60;
            int sec2 = (sec % 3600) % 60;

            Console.Write("Antamasi sekunnit voidaan ilmaista muodossa: ");
            Console.Write(hour);
            Console.Write("h ");
            Console.Write(min);
            Console.Write("min ");
            Console.Write(sec2);
            Console.Write("sek ");

            Console.ReadLine();


        }
    }
}
