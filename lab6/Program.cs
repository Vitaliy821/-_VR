using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i = 0;
            int n = 0;
            int a = 0;
            int k = 0;
            List<string> list = new List<string>();
            Console.WriteLine("1-add element \n0-exit");
            do
            {
                Console.Write("Input number of action:");
                int.TryParse(Console.ReadLine(), out a);
                switch (a)
                {
                    case 1:
                        Console.Write("Input first smth:");
                        list.Add(Console.ReadLine());
                        n++;
                        break;

                }
            } while (a != 0);

            int[] ln = new int[n];

            for (i = 0; i < n; i++)
            {
                ln[i] = (list[i].Length);
                Console.WriteLine(ln[i]);
               
            }

            for (i = 1; i < n; i++)
            {

                if (ln[i] == ln[i - 1])
                {
                    k++;
                }

            }


            Console.WriteLine("Same elements = {0}",k);
            Console.ReadKey();
        }
    }
}
