using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program4SwitchCase
    {
        static void Main(string[] args)
        {
            int per;
            Console.Write("Enter percent = ");
            per = Convert.ToInt32(Console.ReadLine());
            switch(per)
            {
                case int n when (n >= 80 && n <= 100):
                    Console.WriteLine("Distinction");
                    break;

                case int n when (n >= 60 && n <= 79):
                    Console.WriteLine("First class");
                    break;

                case int n when (n >= 35 && n <= 59):
                    Console.WriteLine("Second Class");
                    break;

                case int n when (n >= 0 && n <= 34):
                    Console.WriteLine("Fail");
                    break;
                default: Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
