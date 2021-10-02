using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program3_loop
    {
        static void Main(string[] args)
        {
            int n, j = 1, i;
            Console.Write("Enter the val of = ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<n;i++)
            {
                j = j * i;
                Console.WriteLine(j);
            }
        }


    }
}
