using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program3If_Else
    {
        static void Main(string[] args)
        {
            int per;
            Console.WriteLine("Enter percent = ");
            per = Convert.ToInt32(Console.ReadLine());

            if (per < 0 || per > 100)
                Console.WriteLine("invalid");
            else if (per > 80)
                Console.WriteLine("Distinction");
            else if (per > 60)
                Console.WriteLine("FC");
            else if (per > 45)
                Console.WriteLine("SC");
            else if (per > 35)
                Console.WriteLine("PC");
            else
                Console.WriteLine("FAIL");
            Console.WriteLine("____________________________");
        }
    }
}
