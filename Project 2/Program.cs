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
            do {
                Console.WriteLine("Input first num:");
                int.TryParse(Console.ReadLine(), out a1);
                Console.WriteLine("Input second num:");
                int.TryParse(Console.ReadLine(), out a2);
                if (a2 > a1)
                {
                    for (i = a1; i < a2; i++)
                    {
                        s += (Math.Pow(i, 2) - 1) / ((Math.Pow(-1, i + 1) * Math.Pow(i, 2) + 7));
                    }
                    Console.WriteLine("S={0}", s);
                }
                else
                    Console.WriteLine("Error!");
            } while (a2 < a1);
                    
            Console.ReadKey();
        }
    }
}
