using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    sealed class Singleton
    {
        public static Singleton getInstance = null;
        public static Singleton MyObject()
        {
            if(getInstance==null)
            {
                getInstance = new Singleton();
            }
            return getInstance;
        }
        Singleton() { }
        public void MyMethod()
        {
            Console.WriteLine("This is a method");
        }
    }
}
