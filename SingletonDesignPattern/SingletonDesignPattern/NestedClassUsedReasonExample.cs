using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    class NestedClassUsedReasonExample
    {
        static NestedClassUsedReasonExample instance = null;
        static int counter = 0;
        NestedClassUsedReasonExample()
        {
            counter++;
            Console.WriteLine("No of times instance created : {0}", counter.ToString());
        }
        public static NestedClassUsedReasonExample GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NestedClassUsedReasonExample();
                }
                return instance;
            }
        }

        public class InsideClass : NestedClassUsedReasonExample
        {

        }
        public void printDetails(string str)
        {
            Console.WriteLine(str);
        }
        public void GetClassName()
        {
            Console.WriteLine("NestedClassUsedReasonExample");
        }
    }
}
