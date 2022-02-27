using System;

namespace SingletonDesignPattern
{
    public sealed class ThreadSafetySingleton
    {
        static ThreadSafetySingleton instance = null;
        static readonly object padlock = new object();
        static int counter = 0;
        ThreadSafetySingleton()
        {
            counter++;
            Console.WriteLine("No of times instance created : {0}", counter.ToString());
        }
        public static ThreadSafetySingleton GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafetySingleton();
                    }
                    return instance;
                }
            }
        }
        public void printDetails(string str)
        {
            Console.WriteLine(str);
        }
        public void GetClassName()
        {
            Console.WriteLine("ThreadSafetySingleton");
        }
    }
}
