using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class FactoryClass
    {
        public static IName GetObject(string typeOfObject)
        {
            IName obj = null;
            if (typeOfObject.ToLower() == "student")
                obj = new Student();
            else if (typeOfObject.ToLower() == "teacher")
                obj = new Teacher();
            return obj;
        }
    }
}
