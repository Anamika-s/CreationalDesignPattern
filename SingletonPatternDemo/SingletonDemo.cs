using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    sealed class SingletonDemo
    {
        private static int Count = 0;
        static readonly Object obj = new object();
        static SingletonDemo instance = null;
        public static SingletonDemo getInstance
        {
            get
            {
                if (instance == null)

                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonDemo();
                        }
                    }
                }
                return instance;
            }
        }
        SingletonDemo()
        {
            Count++;
            Console.WriteLine("Count is " + Count);

        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
