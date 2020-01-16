using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Tell me side length of the triangle");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tell me side length of the triangle");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tell me side length of the triangle");
            c = Convert.ToDouble(Console.ReadLine());

            if ((a + b > c) && (a+c>b) && (b+c>a)) Console.WriteLine("You can build triangle from these sides.");
            
            else Console.WriteLine("You can't build triangle from these");
            Console.ReadKey();
        }
    }
}
