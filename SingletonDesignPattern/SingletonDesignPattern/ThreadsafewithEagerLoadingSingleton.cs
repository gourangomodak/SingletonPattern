using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    class ThreadsafewithEagerLoadingSingleton
    {
        static readonly ThreadsafewithEagerLoadingSingleton instance = new ThreadsafewithEagerLoadingSingleton();
        //for lazy initialization
        //static readonly Lazy<ThreadsafewithEagerLoadingSingleton> instance = new Lazy<ThreadsafewithEagerLoadingSingleton>(() => new ThreadsafewithEagerLoadingSingleton());
        static int counter = 0;
        ThreadsafewithEagerLoadingSingleton()
        {
            counter++;
            Console.WriteLine("No of times instance created : {0}", counter.ToString());
        }
        public static ThreadsafewithEagerLoadingSingleton GetInstance
        {
            get
            {
                return instance;
                //for lazy initialization
                //return instance.Value;
            }
        }
        public void printDetails(string str)
        {
            Console.WriteLine(str);
        }
        public void GetClassName()
        {
            Console.WriteLine("ThreadsafewithEagerLoadingSingleton");
        }
    }
}
