using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program9
    {
        static void Main(string[] args)
        {
            int n, cnt = 0, num;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());

            num = n;

            for (cnt = 0; n != 0; n /= 10, cnt++) ;

            Console.WriteLine("count = " + cnt);

            int right = num % 10;
            int left = num / 10;

            int newnum = right * Convert.ToInt32(Math.Pow(10, cnt - 1)) + left;

            Console.WriteLine("Right shifted num = " + newnum);

        }
    }
}
