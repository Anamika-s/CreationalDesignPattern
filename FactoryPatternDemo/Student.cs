using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Student : IName   
    {
        public string GetFirstName()
        {
            return "Student First Name";
        }

        public string GetLastName()
        {
            return "Student Last Name";
        }
    }
}
