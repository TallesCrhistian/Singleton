using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonClass
    {
        private static SingletonClass instance;
        private static readonly object lockObject = new object();

        private SingletonClass() 
        {
        }

        public static SingletonClass GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new SingletonClass();
                }

                return instance;
            }
        }

        public void CreateSomething()
        {
            Console.WriteLine("Create something!");
        }
    }
}
