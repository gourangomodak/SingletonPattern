using System;

namespace SingletonDesignPattern
{
    public sealed class ThreadSafetyDoubleCheckLockingSingleton
    {
        static ThreadSafetyDoubleCheckLockingSingleton instance = null;
        static readonly object padlock = new object();
        static int counter = 0;
        ThreadSafetyDoubleCheckLockingSingleton()
        {
            counter++;
            Console.WriteLine("No of times instance created : {0}", counter.ToString());
        }
        public static ThreadSafetyDoubleCheckLockingSingleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafetyDoubleCheckLockingSingleton();
                        }
                    }
                }
                return instance;
            }
        }
        public void printDetails(string str)
        {
            Console.WriteLine(str);
        }
        public void GetClassName()
        {
            Console.WriteLine("ThreadSafetyDoubleCheckLockingSingleton");
        }
    }
}
