using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program6_PrimeOrNot
    {
        static void Main(string[] args)
        {
            int n, i = 2;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());
            while(i<=n/2)
            {
                if(n%i==0)
                {
                    Console.WriteLine(n + " not a prime num ");
                    break;
                }
                i++;
            }
            if (i > n / 2)
                Console.WriteLine(n + " is a prime number ");
        }
        }
}
