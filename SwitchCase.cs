using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SwitchCase
    {
        static void Main()
        {
            Console.WriteLine("Enter a alphbet: ");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    {
                        Console.WriteLine("Yes, It's a Vowel");
                        break;
                    }
                case 'e':
                    {
                        Console.WriteLine("Yes, It's a Vowel");
                        break;
                    }
                case 'i':
                    {
                        Console.WriteLine("Yes, It's a Vowel");
                        break;
                    }
                case 'o':
                    {
                        Console.WriteLine("Yes, It's a Vowel");
                        break;
                    }
                case 'u':
                    {
                        Console.WriteLine("Yes, It's a Vowel");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No,It's not a Vowel");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
