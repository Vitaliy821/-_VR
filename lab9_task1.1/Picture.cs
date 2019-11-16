using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_task1._1
{
    class Picture : IDraw
    {
        public int listLenght;
        public List<Shape> shapes;

        public Picture()
        {
            shapes = new List<Shape>();
        }
        public Picture(int listLenght)
        {
            shapes = new List<Shape>(listLenght);
        }
        public void AddFigure(Shape shape)
        {
            shapes.Add(shape);
        }
        public void DeleteFigure(string name)
        {
            
            shapes.Remove(shapes.Find(x=>x.ObjectName == name));
        }
        public void DeleteFigure(int vertex)
        {

            shapes.Remove(shapes.Find(x => x.Vertex == vertex));
        }
        public void DeleteFigure(double area)
        {
            if (area > 15)
            {
                shapes.Remove(shapes.Find(x => x.Area() == area));
            }
        }

        public void Draw()
        {
            for (int index = 0; index<shapes.Count;index++ )
            {
                shapes[index].Draw();
            }
        }


        public Shape this[int index]
        {
            get { return shapes[index]; }
        }

       
    }
}
