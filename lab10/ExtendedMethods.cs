using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    static class ExtendedMethods
    {
        static void SwapNum(this int num)
        {
            string str;
            str = num.ToString();
            for (int j = str.Length - 1; j >= 0; j--)
            {
                Console.Write(str[j]);
            }
            Console.WriteLine("\n");
        }

        static void SwapStr(this string str)
        {
            for (int j = str.Length - 1; j >= 0; j--)
            {
                Console.Write(str[j]);
            }
            Console.WriteLine("\n");
        }

        static void SwapNum(this string str)
        {

            string[] str2 = str.Split(',', '.');
            int j = str2.Length;

            for (j = str2[0].Length - 1; j >= 0; j--)
            {
                Console.Write(str2[0][j]);
            }
            Console.Write(",");
            for (j = str2[1].Length - 1; j >= 0; j--)
            {
                Console.Write(str2[1][j]);
            }

            Console.WriteLine("\n");
        }


        static void SwapNum(this double num2)
        {

            string[] str = num2.ToString().Split(',', '.');
            int j = str.Length;

            for (j = str[0].Length - 1; j >= 0; j--)
            {
                Console.Write(str[0][j]);
            }
            Console.Write(",");
            for (j = str[1].Length - 1; j >= 0; j--)
            {
                Console.Write(str[1][j]);
            }

            Console.WriteLine("\n");
        }

        static void SwapArray(this int[] arr, int n)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input a[{0}]", i + 1);
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            for (int j = arr.Length - 1; j >= 0; j--)
            {
                Console.Write("\n {0}", arr[j]);
            }
            Console.WriteLine("\n");
        }

        static void Print(this int[] arr)
        {
            for(int i = 0; i < arr.Length; i -= -1)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("a[{0}]={1}",i,arr[i]);
                }
            }
            for (int i = 0; i < arr.Length; i -= -1)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine("a[{0}]={1}", i, arr[i]);
                }
            }
        }
    }
}
