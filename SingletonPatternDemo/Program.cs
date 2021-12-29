using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    class Program
    {
        static void Main(string[] args)

        {
            ////Singleton s1 = new Singleton();
            ////s1.MyMethod();
            ////Singleton s2 = new Singleton();
            ////s2.MyMethod();
            //Singleton s1 = Singleton.MyObject();
            //s1.MyMethod();
            //Singleton s2 = Singleton.MyObject();
            //s2.MyMethod();

            //PrintEmployees();
            //PrintStudents();
            Parallel.Invoke(() => PrintEmployees(), () => PrintStudents());

        }

        private static void PrintStudents()
        {
            SingletonDemo s1 = SingletonDemo.getInstance;
            s1.PrintDetails("Message from Students");
        }

        private static void PrintEmployees()
        {
            SingletonDemo s2 = SingletonDemo.getInstance;
            s2.PrintDetails("Mesasage from Employees");
        }
    }
}
