using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Practice
{
    class InsertionSort
    {
        static void inputArray(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the " + i + " th element=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void displayArray(int[] a)
        {
            int n = a.Length;
            Console.WriteLine("\n\nArray elements = \n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }
        static void insertionSort(int[] a)
        {
            int i, j, key;
            for(i=1;i<a.Length;i++)
            {
                key = a[i];
                j = i - 1;
                while(j>=0 && a[j]>key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter no of elements =");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            inputArray(a);
            displayArray(a);
            insertionSort(a);
            displayArray(a);
        }
    }
}
