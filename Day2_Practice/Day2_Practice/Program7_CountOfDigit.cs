using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program7_CountOfDigit
    {
        static void Main(string[] args)
        {
            int n, cnt = 0;
            int rem = 0, sum = 0;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                cnt++;
                rem = n % 10;
                sum += rem;
                n /= 10;
            }
            Console.WriteLine("Count of digit = " + cnt);
            Console.WriteLine("Sum of digit =" + sum);
        }
     }
}
