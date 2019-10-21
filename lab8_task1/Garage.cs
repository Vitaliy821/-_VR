using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace lab8_task1
{
    class Garage
    {
        private List<Car> Cars { get; set; }
        public Garage()
        {
            Cars = new List<Car>();
        }

        public void BuyCar(Car car)
        {
            Cars.Add(car);

        }

        public void SellCar(int i)
        {
            if (i >= 0 && i < Cars.Count)
                Cars.RemoveAt(i);
        }

        public void Show()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine("{0}){1}\n  {2}\n  {3}\n  {4}", i + 1, Cars[i].Name, Cars[i].Color, Cars[i].Speed, Cars[i].Year);
            }
        }

        public void Filter_Name()
        {
            string name;
            Console.Write("Input name for search:");
            name = Console.ReadLine();
            for (int i = 0; i < Cars.Count; i++)
            {
                if (name == Cars[i].Name)
                {
                    Console.WriteLine("{0}){1}\n  {2}\n  {3}\n  {4}", i + 1, Cars[i].Name, Cars[i].Color, Cars[i].Speed, Cars[i].Year);
                }

            }
        }
        
        public void Filter_Color()
        {
            string color;
            Console.Write("Input color for search:");
            color = Console.ReadLine();
            for (int i = 0; i < Cars.Count; i++)
            {
                if (color == Cars[i].Color)
                {
                    Console.WriteLine("{0}){1}\n  {2}\n  {3}\n  {4}", i + 1, Cars[i].Name, Cars[i].Color, Cars[i].Speed, Cars[i].Year);
                }

            }
        }

        public void Filter_Speed()
        {
            int speed;
            Console.Write("Input speed for search:");
            int.TryParse(Console.ReadLine(),out speed);
            for (int i = 0; i < Cars.Count; i++)
            {
                if (speed == Cars[i].Speed)
                {
                    Console.WriteLine("{0}){1}\n  {2}\n  {3}\n  {4}", i + 1, Cars[i].Name, Cars[i].Color, Cars[i].Speed, Cars[i].Year);
                }

            }
        }

        public void Filter_Year()
        {
            int year;
            Console.Write("Input year for search:");
            int.TryParse(Console.ReadLine(), out year);
            for (int i = 0; i < Cars.Count; i++)
            {
                if (year == Cars[i].Year)
                {
                    Console.WriteLine("{0}){1}\n  {2}\n  {3}\n  {4}", i + 1, Cars[i].Name, Cars[i].Color, Cars[i].Speed, Cars[i].Year);
                }

            }
        }
    }
}
