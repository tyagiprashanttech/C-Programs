using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SimpleCalculator
    {
        static void Main()
        {
            float a, b;
            Console.WriteLine("Enter two no's =");
            a=Convert.ToSingle(Console.ReadLine());
            b=Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Addition is = " + (a + b));
            Console.WriteLine("Subraction is = " + (a - b));
            Console.WriteLine("Multiplication is = " + (a * b));
            Console.WriteLine("Division is = " + (a / b));


            Console.ReadLine();



        }
    }
}
