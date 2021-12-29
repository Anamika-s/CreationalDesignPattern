using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teacher teacher = new Teacher();
            //Console.WriteLine(teacher.GetFirstName());
            //Console.WriteLine(teacher.GetLastName());
            //Student student = new Student();
            //Console.WriteLine(student.GetFirstName());
            //Console.WriteLine(student.GetLastName());
            Console.WriteLine("What type of object you want");
            string type = Console.ReadLine();
            IName obj = FactoryClass.GetObject(type);
            Console.WriteLine(obj.GetFirstName());
            Console.WriteLine(obj.GetLastName());
            

        }
        
    }
}
