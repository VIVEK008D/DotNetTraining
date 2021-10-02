using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program8
    {
        static void Main(string[] args)
        {
            int n, cnt = 0, num;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());
            num = n;
            for (cnt = 0; n != 0; n /= 10, cnt++) ;
            Console.WriteLine("Count = " + cnt);

            int leftval = num / Convert.ToInt32(Math.Pow(10, cnt - 1));
            int rightval = num % Convert.ToInt32(Math.Pow(10, cnt - 1));

            int newnum = rightval * 10 + leftval;
            Console.WriteLine("the left shihted num = " + newnum);
        }
    }
}
