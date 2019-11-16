using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_task1._1
{
    class Circle : Shape
    {
        public  int Radius { get; set; }
        public override string ObjectName { get; }
        public override int Vertex { get; }
        public override ConsoleColor Color { get; set; }
        public Circle(string objectName)
        {
            Radius = new Random().Next(1, 13);
            Color = (ConsoleColor)(new Random().Next(0, 15));

        }
        public Circle(string name, int radius)
        {
            Color = (ConsoleColor)(new Random().Next(0, 15));
            ObjectName = name;
            Radius = radius;

        }

        public Circle(string name, int radius, ConsoleColor color)
        {
            Color = color;
            ObjectName = name;
            Radius = radius;
        }

        public override double Area()
        {
           
           return 2 * Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimetry()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(ObjectName, Radius);
        }
    }
}
