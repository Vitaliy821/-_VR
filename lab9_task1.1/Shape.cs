using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_task1._1
{
    abstract class Shape : IDraw
    {
        public abstract ConsoleColor Color { get; set; }
        public abstract int Vertex { get; }
        public abstract string ObjectName { get; }
        abstract public double Area();
        public abstract void Draw();
        abstract public double Perimetry();
        
    }
}
