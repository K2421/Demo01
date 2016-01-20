using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    //Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
    //Tee ohjelma, joka tulostaa ajetulla matkalla kuluvan bensan määrän sekä bensaan menevän rahan määrän.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna matkan kilometrit: ");
            string eka = Console.ReadLine();
            double km = double.Parse(eka);

            double gas = (7.02 / 100) * km;
            double money = gas * 1.595;

            Console.WriteLine();
            Console.Write("Matkalla kuluu ");
            Console.Write(gas);
            Console.Write(" litraa bensaa, johon menee rahaa ");
            Console.Write(money);
            Console.WriteLine(" euroa.");

            Console.ReadLine();
        }
    }
}
