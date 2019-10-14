using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        //static void SwapNum(int num)
        //{
        //    string str;
        //    str = num.ToString();
        //    for (int j = str.Length - 1; j >= 0; j--)
        //    {
        //        Console.Write(str[j]);
        //    }
        //    Console.WriteLine("\n");
        //}

        static void SwapNum(int num, int counter)
        {
            string str;
            str = num.ToString();
            int j = str.Length - 1;
            if ((j + counter) <= (str.Length - 1) * 2)
            {
                Console.Write(str[j - counter]);
                counter++;
                SwapNum(num, counter);
            }
        }


        //static void SwapStr(string str)
        //{
        //    for (int j = str.Length - 1; j >= 0; j--)
        //    {
        //        Console.Write(str[j]);
        //    }
        //    Console.WriteLine("\n");
        //}

        static void SwapStr(string str, int counter)
        {

            int j = str.Length - 1;
            if ((j + counter) <= (str.Length - 1) * 2)
            {
                Console.Write(str[j - counter]);
                counter++;
                SwapStr(str, counter);
            }
        }

        //static void SwapNum(float num2)
        //{

        //    string[] str = num2.ToString().Split(',','.');
        //    int j = str.Length;

        //    for (j = str[0].Length - 1; j >= 0; j--)
        //    {
        //        Console.Write(str[0][j]);
        //    }
        //    Console.Write(",");
        //    for (j = str[1].Length - 1; j >= 0; j--)
        //    {
        //        Console.Write(str[1][j]);
        //    }

        //    Console.WriteLine("\n");
        //}

        static void SwapNum(float num2, int counter, int counter2)
        {

            string[] str = num2.ToString().Split(',', '.');
            int i = str[0].Length - 1;
            int j = str[1].Length - 1;

            if ((i + counter) <= (str[0].Length - 1) * 2)
            {
                Console.Write(str[0][i - counter]);
                if ((i + counter) == (str[0].Length - 1) * 2)
                {
                    Console.Write(",");
                }
                counter++;
                SwapNum(num2, counter, counter2);

            }
            else if ((j + counter2) <= (str[1].Length - 1) * 2)
            {
                Console.Write(str[1][j - counter2]);
                counter2++;
                SwapNum(num2, counter, counter2);
            }
        }

        //static void SwapNum(string str)
        //{

        //    string[] str2 = str.Split(',', '.');
        //    int j = str2.Length;

        //    for (j = str2[0].Length - 1; j >= 0; j--)
        //    {
        //        Console.Write(str2[0][j]);
        //    }
        //    Console.Write(",");
        //    for (j = str2[1].Length - 1; j >= 0; j--)
        //    {
        //        Console.Write(str2[1][j]);
        //    }

        //    Console.WriteLine("\n");
        //}

        static void SwapStr(string str2, int counter, int counter2)
        {

            string[] str = str2.Split(',', '.');
            int i = str[0].Length - 1;
            int j = str[1].Length - 1;

            if ((i + counter) <= (str[0].Length - 1) * 2)
            {
                Console.Write(str[0][i - counter]);
                if ((i + counter) == (str[0].Length - 1) * 2)
                {
                    Console.Write(",");
                }
                counter++;
                SwapStr(str2, counter, counter2);

            }
            else if ((j + counter2) <= (str[1].Length - 1) * 2)
            {
                Console.Write(str[1][j - counter2]);
                counter2++;
                SwapStr(str2, counter, counter2);
            }
        }



        static void SwapArray(out int[] arr, ref int n)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input a[{0}]", i+1);
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            for (int j = arr.Length - 1; j >= 0; j--)
            {
                Console.Write("\n {0}",arr[j]);
            }
            Console.WriteLine("\n");
        }


        static void Main(string[] args)
        {
            int a, counter, counter2;
            string str;

            Console.WriteLine("1) 1234->4321 \n2) ABC->CBA \n3) 123.456->321.654 \n4) ABC.DEF->CBA.FED \n5) Swap array \n0) exit");

            do
            {
                Console.WriteLine("Input number of action:");
                int.TryParse(Console.ReadLine(), out a);
                switch (a)
                {
                    case 1:
                        int num;
                        counter = 0;
                        Console.WriteLine("\nInput number:");
                        int.TryParse(Console.ReadLine(), out num);
                        SwapNum(num, counter);
                        Console.WriteLine("\n");

                        break;

                    case 2:
                        counter = 0;
                        Console.WriteLine("\nInput something:");
                        str = Console.ReadLine();
                        SwapStr(str, counter);
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        counter = 0;
                        counter2 = 0;
                        float num2;
                        Console.WriteLine("\nInput number:");
                        float.TryParse(Console.ReadLine(), out num2);
                        SwapNum(num2, counter, counter2);
                        Console.WriteLine("\n");
                        break;

                    case 4:
                        counter = 0;
                        counter2 = 0;
                        Console.WriteLine("\nInput something:");
                        str = Console.ReadLine();
                        SwapStr(str, counter, counter2);
                        Console.WriteLine("\n");
                        break;

                    case 5:
                        int n;
                        Console.WriteLine("\nInput size of array:");
                        int.TryParse(Console.ReadLine(), out n);
                        int[] arr;
                        SwapArray(out arr, ref n);
                        break;
                }
            } while (a != 0);





            Console.ReadKey();
        }
    }
}
