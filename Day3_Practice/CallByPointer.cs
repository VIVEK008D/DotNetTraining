using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Practice
{
    class CallByPointer
    {
        static unsafe void swap(int* a, int* b)
        {
            int temp;
            temp = *a;
            *a = *b;
            *b = temp;
            Console.WriteLine("SWAP FUN A = " + *a + " B = " + *b);
        }
        static unsafe void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("BEFORE SWAP FUN A = " + a + " B = " + b);
            swap(&a, &b);
            Console.WriteLine("AFTER SWAP FUN A = " + a + " B = " + b);
        }
    }
}
