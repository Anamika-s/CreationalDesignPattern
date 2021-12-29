using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Teacher : IName
    {
        public string GetFirstName()
        {
            return "Teacher First Name";
        }

        public string GetLastName()
        {
            return "Teacher Last Name";
        }
    }
}
