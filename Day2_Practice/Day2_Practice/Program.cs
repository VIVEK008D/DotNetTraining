using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1, j = 1; i <= n; i++, j += 3)
                Console.WriteLine(j);
        }
    }
}
