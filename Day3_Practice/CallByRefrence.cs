﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Practice
{
    class CallByRefrence
    {
        static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;//temp=10
            a = b;  //a=20
            b = temp;//b=10
            Console.WriteLine("\nInside SWAP function with value a=" + a + "  b=" + b);
        }
        static void Main(string[] args)
        {
            int m = 10, n = 20;
            Console.WriteLine("Inside MAIN function before SWAP a=" + m + "  b=" + n);
            swap(ref m, ref n);//swap(ref 10,ref 20)
            Console.WriteLine("\nInside MAIN function after SWAP a=" + m + "  b=" + n);
        }
    }
}
