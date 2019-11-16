using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_task1._1
{
    class Triangle : Shape
    {
        public int SideLenght { get; set; }
        public override string ObjectName { get; }
        public override int Vertex { get; }
        public override ConsoleColor Color { get; set; }
        public Triangle(string objectName)
        {
            SideLenght = new Random().Next(1, 13);
            Color = (ConsoleColor)(new Random().Next(0, 15));

        }
        public Triangle(string name, int sideLenght)
        {
            Color = (ConsoleColor)(new Random().Next(0, 15));
            ObjectName = name;
            SideLenght = sideLenght;

        }
        public Triangle(string name, int sideLenght, ConsoleColor color)
        {
            Color = color;
            ObjectName = name;
            SideLenght = sideLenght;
        }

        public override double Area()
        {
            return Math.Sqrt(3)/4*Math.Pow(SideLenght,2);
        }
        public override double Perimetry()
        {
            return SideLenght * 3;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(ObjectName, SideLenght);
        }
    }
}
