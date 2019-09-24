using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, y1, x2, y2,x,y,a,b;
          
            Console.WriteLine("Input x1:");
            float.TryParse(Console.ReadLine(), out x1);
            Console.WriteLine("Input y1:");
            float.TryParse(Console.ReadLine(), out y1);
            Console.WriteLine("Input x2:");
            float.TryParse(Console.ReadLine(), out x2);
            Console.WriteLine("Input y2:");
            float.TryParse(Console.ReadLine(), out y2);
            Console.WriteLine("Input x:");
            float.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Input y:");
            float.TryParse(Console.ReadLine(), out y);
            a = (x1 + x2) / 2;
            b = (y1 + y2) / 2;

            if (x==a&&y==b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();
        }
    }
}
