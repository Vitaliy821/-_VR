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
            int k=0, n, i, j;
            Console.WriteLine("Input n:");
            int.TryParse(Console.ReadLine(), out n);
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Input a:");
                int.TryParse(Console.ReadLine(), out a[i]);
            }
            for (i = 0; i < n; i++)
            {
                for (j = i+1; j < n; j++)
                {
                    if (a[i] == a[j])
                        k++;
                }
                
            }
            if(k>0)
                Console.WriteLine("K={0}",k-1);
            else
                Console.WriteLine("None");
            Console.ReadKey();
        }
    }
}
