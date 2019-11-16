using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_task1._1
{
    class Square : Shape
    {
        public int SideLenght { get; set; }

        public override string ObjectName { get; }
        public override int Vertex { get; }
        public override ConsoleColor Color { get; set; }
        public Square(string name)
        {
            SideLenght = new Random().Next(1, 13);
            Color = (ConsoleColor)(new Random().Next(0, 15));
            ObjectName = name;

        }
        public Square(string name, int sideLenght)
        {
            Color = (ConsoleColor)(new Random().Next(0, 15));
            ObjectName = name;
            SideLenght = sideLenght;

        }
        public Square(string name,int sideLenght, ConsoleColor color)
        {
            Color = color;
            ObjectName = name;
            SideLenght = sideLenght;
        }

        public override double Area()
        {
            return Math.Pow(SideLenght, 2);
        }
        public override double Perimetry()
        {
         return SideLenght * 4;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(ObjectName, SideLenght);
        }
    }
}
