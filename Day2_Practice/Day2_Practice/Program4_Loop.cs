using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program4_Loop
    {
        static void Main(string[] args)
        {
            int n, j, i;
            Console.WriteLine("Enter the val of n =");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                Console.WriteLine(i *(n-i+1));
        }
    }
}
