using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task1
{
    
    class Program
    {
        static void GetData(out string name, out string color, out int speed, out int year)
        {
            Console.WriteLine("Input name of car:");
            name = Console.ReadLine();
            Console.WriteLine("Input color of car:");
            color = Console.ReadLine();
            do
            {
                Console.WriteLine("Input speed of car:");
                int.TryParse(Console.ReadLine(), out speed);
            } while (speed <= 0);
            do
            {
                Console.WriteLine("Input year of car:");
                int.TryParse(Console.ReadLine(), out year);
            } while (year < 1874 || year > 2019);
        }
        static void Main(string[] args)
        {

            Garage garage = new Garage();
            int a;
            Console.WriteLine("1-show list of cars\n" +
                "2-buy new cac\n" +
                "3-sell car\n" +
                "4-filter name\n" +
                "5-filter color\n" +
                "6-filter speed\n" +
                "7-filter year\n" +
                "0-exit");
            do
            {
                Console.WriteLine("Input number of action:");
                int.TryParse(Console.ReadLine(), out a);
                string name, color;
                int speed, year;
               
                switch (a)
                {
                    case 1:
                        garage.Show();
                    break;
                    case 2:
                        Console.WriteLine("Input data of car:");
                        GetData(out name, out color, out speed, out year);
                        garage.BuyCar(new Car(name, color, speed, year));
                    break;

                    case 3:
                        int i;
                        Console.WriteLine("Input number of car for selling:");
                        int.TryParse(Console.ReadLine(), out i);
                        garage.SellCar(i-1);
                    break;
                    case 4:
                        garage.Filter_Name();
                    break;
                    case 5:
                        garage.Filter_Color();
                    break;
                    case 6:
                        garage.Filter_Speed();
                    break;
                    case 7:
                        garage.Filter_Year();
                    break;

                }

            } while (a != 0);

        }
    }
}
