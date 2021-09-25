using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program2
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            float per;
            Console.Write("Enter name = ");
            name = Console.ReadLine();
            Console.Write("Enter age = ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter percentage = ");
            per = float.Parse(Console.ReadLine());
            Console.WriteLine("Welcome " + name + " with age = " + age + " & percent " + per);
        }
    }
}
