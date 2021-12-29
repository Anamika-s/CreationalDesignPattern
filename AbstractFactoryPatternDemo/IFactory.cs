using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo
{
    interface IFactory
    {
        FactoryDataItem GetData(int id); 
    }
}
