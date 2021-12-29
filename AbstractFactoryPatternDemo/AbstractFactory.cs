using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo
{
    abstract class AbstractFactory : IFactory
    {
        public abstract FactoryDataItem GetData(int id);
        
    }
    enum ShapeType { Circle = 1, Rectangle = 2, Triangle = 3 };
     class Circle
    {
        public void GetInfo()
        {
            Console.WriteLine("Its a circle");
            
        }
    }
    class Rectangle
    {
        public void GetInfo()
        {
            Console.WriteLine("Its a Rectangle");

        }
    }
    class Triangle
    {
        public void GetInfo()
        {
            Console.WriteLine("Its a Triangle");

        }
    }
    enum ColorType {  Red = 1, Green =2, Yellow=3};
    class Red
    {
        public void GetInfo()
        {
            Console.WriteLine("Its a Red Color");
        }
    }
    class Green
    {
        public void GetInfo()
        {
            Console.WriteLine("Its a Green Color");
        }
    }
    class Yellow
    {
        public void GetInfo()
        {
            Console.WriteLine("Its a Yellow Color");
        }
    }

}
