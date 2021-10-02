using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Practice
{
    class SelectionSort
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
        static void selectionSort(int[] a)
        {
            int i, j, ind, temp;
            int n = a.Length;
            for(i=0;i<n-1;i++)
            {
                ind = i;
                for(j=i+1;j<n;j++)
                {
                    if (a[j] < a[ind])
                        ind = j;
                }
                temp = a[ind];
                a[ind] = a[i];
                a[i] = temp;
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
            selectionSort(a);
            displayArray(a);
        }
    }
}
