using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo
{
    class ColorFactory : AbstractFactory
    {
        public override FactoryDataItem GetData(int type)
        {
            FactoryDataItem factoryDataItem = null;
            switch ((ColorType)type)
            {
                case ColorType.Red:
                    factoryDataItem = new FactoryDataItem(new Red());
                    break;
                case ColorType.Green:
                    factoryDataItem = new FactoryDataItem(new Green());
                    break;
                case ColorType.Yellow:
                    factoryDataItem = new FactoryDataItem(new Yellow());
                    break;
            }
            return factoryDataItem;
        }
    }
}
