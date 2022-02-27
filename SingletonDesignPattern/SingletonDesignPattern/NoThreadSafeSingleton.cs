using System;

namespace SingletonDesignPattern
{
    public sealed class NoThreadSafeSingleton
    {
        static NoThreadSafeSingleton instance = null;
        static int counter = 0;
        NoThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("No of times instance created : {0}", counter.ToString());
        }
        public static NoThreadSafeSingleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NoThreadSafeSingleton();
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
            Console.WriteLine("NoThreadSafeSingleton");
        }
    }
}
