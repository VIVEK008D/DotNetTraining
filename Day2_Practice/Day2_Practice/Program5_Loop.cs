using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program5_Loop
    {
        static void Main(string[] args)
        {
            int n, j, i;
            Console.WriteLine("Enter the val of n =");
            n = Convert.ToInt32(Console.ReadLine());
            
            for(i=1;i<=n;i++)
            {
                for(j=1;j<=n;j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n || i == j || i + j == n + 1)
                        Console.Write("1");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
