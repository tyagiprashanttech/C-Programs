using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ifelse
    {
        static void Main()
        {
            int sprice, cprice, p;
            Console.WriteLine("Calculate Profit and Loss");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Input Cost Price");
            cprice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Sell Price");
            sprice = Convert.ToInt32(Console.ReadLine());

            if (sprice > cprice)
            {
                p = sprice - cprice;
                Console.WriteLine("Your Profit is " + p);
            }
            else if (cprice > sprice)
            {
                p = cprice - sprice;
                Console.WriteLine("Your Loss is " + p);
            }
            else
            {
                Console.WriteLine("NO Profit NO Loss");
            }
            Console.ReadLine();

        }
    }
}

