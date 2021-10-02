using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program2_Loop
    {
        static void Main(string[] args)
        {
            int n, j = 1;
            Console.WriteLine("Enter theval of n = ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                Console.WriteLine(j);
                j = j * 2;
            }
        }
    }
}
