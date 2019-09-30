using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, j, min, max,bi=0,bj=0;

            Console.WriteLine("Input n:");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Input m:");
            int.TryParse(Console.ReadLine(), out m);
            int[,] a = new int[n, m];
            // var rand = new Random();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    // a[i, j] = rand.Next(-100, 100);
                    //Console.Write("{0}\t", a[i, j]);
                    Console.WriteLine("Input num:");
                    int.TryParse(Console.ReadLine(), out a[i, j]);
                }
                Console.Write("\n");
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine();
            }

            for (i = 0; i < n; i++)
            {
                min = a[i, 0];
                max = a[i, 0];
                j = 0;
                bi = i;
                while ((j < m - 1) && (a[i, j] < a[i, j + 1]))
                {
                    j++;
                }
                if (j == m - 1)
                {
                    Console.WriteLine("Row {0}:", bi + 1);
                    Console.WriteLine("\tMax = {0}", a[i, j]);
                    Console.WriteLine("\tMin = {0} \n", a[i, 0]);
                }
                else
                {
                    Console.WriteLine("Row {0}: 0", bi + 1);
                }

                j = 0;

                while ((j < m - 1) && (a[i, j] > a[i, j + 1]))
                {
                    j++;
                }
                if (j == m - 1)
                {
                    Console.WriteLine("Row {0}:", bi + 1);
                    Console.WriteLine("\tMax = {0}", a[i, 0]);
                    Console.WriteLine("\tMin = {0} \n", a[i, j]);
                }
                else
                {
                    Console.WriteLine("Row {0}: 0", bi + 1);
                }

            }


            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine();
            }

            for (j = 0; j < m; j++)
            {
                min = a[0, j];
                max = a[0, j];
                i = 0;
                bj = j;

                while ((i< n - 1) && (a[i, j] < a[i+1, j]))
                {
                    i++;
                }
                if (i == n - 1)
                {
                    Console.WriteLine("Column {0}:", bj + 1);
                    Console.WriteLine("\tMax = {0}", a[i, j]);
                    Console.WriteLine("\tMin= {0}", a[0, j]);
                }
                else
                {
                    Console.WriteLine("Column {0}: 0", bi + 1);
                }

                i = 0;

                while ((i < n - 1) && (a[i, j] > a[i+1, j]))
                {
                    i++;
                }
                if (i == n - 1)
                {
                    Console.WriteLine("Column {0}:", bj + 1);
                    Console.WriteLine("\tMax = {0}", a[0, j]);
                    Console.WriteLine("\tMin = {0}", a[i, j]);
                }
                else
                {
                    Console.WriteLine("Column {0}: 0", bi + 1);
                }

            }



            Console.ReadKey();
        }
    }
}