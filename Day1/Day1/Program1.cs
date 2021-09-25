using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0;
            Console.Write("Please enter the value of a = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the value of b = ");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;

            Console.WriteLine("The sum of " + a + " and " + b + " = " + sum);
        }
    }
}
