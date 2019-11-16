using System;


namespace lab8_task1
{
    public class Car
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public int Speed { get; private set; }
        public int Year { get; private set; }
        public Car(string name, string color, int speed, int year)
        {
            Name = name;
            Color = color;
            Speed = speed;
            Year = year;
        }
    }
}
