using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            ColorFactory colorFactory = new ColorFactory();
            Circle circle = shapeFactory.GetData((int)ShapeType.Circle).DataItem as Circle;
            circle.GetInfo();
            Red red = colorFactory.GetData((int)ColorType.Red).DataItem as Red;
            red.GetInfo();
            
        }
    }
}
