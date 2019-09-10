using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
     
            double r;
            Console.WriteLine("Input r1:");
            double.TryParse(Console.ReadLine(), out double r1);
            Console.WriteLine("Input r2:");
            double.TryParse(Console.ReadLine(), out double r2);
            r = (r1*r2)/(r1+r2);
            Console.WriteLine( "R={0}", r);
            Console.ReadKey();
        }
    }
}
