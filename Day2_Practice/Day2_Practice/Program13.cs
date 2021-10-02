using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program13
    {
        static void add()
        {
            int a, b;
            Console.WriteLine("Enter the val of a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the val of b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = " + (a + b));
        }
        static void sub(int a, int b)
        {
            Console.WriteLine("Diffrence = " + (a - b));
        }
        static int mul(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            add();
            int a, b;
            Console.WriteLine("Enter the val of a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the val of b = ");
            b = Convert.ToInt32(Console.ReadLine());
            sub(a, b);
            int res = mul(a, b);
            Console.WriteLine("The product = "+res);
            Console.WriteLine("The product = "+mul(7,8));
        }
    }
}
