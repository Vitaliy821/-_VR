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
            

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i].Length == list[j].Length)
                    {
                        k++;
                        list.RemoveAt(j);
                    }
                }
            }


            Console.WriteLine("Same elements = {0}",k);
            Console.ReadKey();
        }
    }
}
