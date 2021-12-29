using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo
{
    class ShapeFactory : AbstractFactory
    {
        public override FactoryDataItem GetData(int type)
        {
            FactoryDataItem factoryDataItem = null;
            switch((ShapeType)type)
            {
                case ShapeType.Circle:
                    factoryDataItem = new FactoryDataItem(new Circle());
                    break;
                case ShapeType.Rectangle:
                    factoryDataItem = new FactoryDataItem(new Rectangle());
                    break;
                case ShapeType.Triangle:
                    factoryDataItem = new FactoryDataItem(new Triangle());
                    break;
            }
            return factoryDataItem;
        }
    }
}
