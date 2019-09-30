using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=0, n, i,j,c;
            do
            {
                Console.WriteLine("Input n:");
                int.TryParse(Console.ReadLine(), out n);
            } while (n < 1);
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Input a[{0}]:",i+1);
                int.TryParse(Console.ReadLine(), out a[i]);
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        c = a[i];
                        a[i] = a[j];
                        a[j] = c;
                    }
                }
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(" {0}", a[i]);
            }

            for (i = 1; i < n; i++)
            {
                    if (a[i] == a[i-1])
                    {
                        k++;
                    }
            }
            if(k>0)
                Console.WriteLine("K={0}",k);
            else
                Console.WriteLine("None");
            Console.ReadKey();
        }
    }
}
