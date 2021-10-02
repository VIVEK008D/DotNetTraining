using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Practice
{
    class Program12
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter element = ");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ARRAY ELEMENTS ARE = ");
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
