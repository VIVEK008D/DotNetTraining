using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Practice
{
    class FunctionArray
    {
        static void inputarray(int[] a)
        {
            int n = a.Length;
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter the " + i + "the element =");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void display(int[] a)
        {
            int n = a.Length;
            Console.WriteLine("\n\nArray elements = ");
            for(int i=0; i<n;i++)

            {
                Console.WriteLine("a[" + i + "]=" + a[i]);
            }
        }
        static int add(int [] a)
        {
            int sum = 0;
            foreach (int x in a)
                sum += x;
            return sum;
        }
        static void add2Array(int[] a, int[] b, int[] c)
        {
            for(int i =0;i<a.Length;i++)
            {
                c[i] = a[i] + b[i];
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter no of element = ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];

            inputarray(a);
            inputarray(b);
            display(a);
            display(b);
            add2Array(a, b, c);
            display(c);
        }
    }
}
