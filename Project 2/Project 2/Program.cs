using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            double s = 0;
            int a1;
            int a2;
            int n = 0;
            bool c;
            bool b;
            do {
                Console.WriteLine("Input first num:");
              b=int.TryParse(Console.ReadLine(), out a1);
                Console.WriteLine("Input second num:");
              c=int.TryParse(Console.ReadLine(), out a2);
            } while ((a1 < 0|| a2<a1)||!(c & b));

                    for (i = a1; i < a2; i++)
                    {
                        s += (Math.Pow(i, 2) - 1) / ((Math.Pow(-1, i + 1) * Math.Pow(i, 2) + 7));
                    }
                    Console.WriteLine("S={0}", s);
            
            Console.ReadKey();
        }
    }
}
