using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program10_switchCase
    {
        static void Main(string [] args)
        {
            int ch, qty = 0, price = 0;
            do
            {
                Console.WriteLine("1 IDLI (40)");
                Console.WriteLine("2 DOSA (50)");
                Console.WriteLine("3 POORI (45)");
                Console.WriteLine("4 TEA (10)");
                Console.WriteLine("5 EXIT");
                ch = Convert.ToInt32(Console.ReadLine());
                if (ch >= 1 && ch <= 4)
                {
                    Console.WriteLine("Enter qty = ");
                    qty = Convert.ToInt32(Console.ReadLine());
                }
                switch (ch)
                {
                    case 1: price += qty * 40; break;
                    case 2: price += qty * 50; break;
                    case 3: price += qty * 45; break;
                    case 4: price += qty * 10; break;
                    case 5: break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (ch != 5);
            Console.WriteLine("BILL =" + price);
        }
    }
}
