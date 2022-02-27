using System;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //NoThreadSafeSingleton noThreadSafeSingleton = NoThreadSafeSingleton.GetInstance;

            //Parallel.Invoke(
            //    () => CreateThreadSafeInstance1(),
            //    () => CreateThreadSafeInstance2()
            //    );

            //ThreadSafetyDoubleCheckLockingSingleton threadSafetyDoubleCheckLockingSingleton = ThreadSafetyDoubleCheckLockingSingleton.GetInstance;

            //ThreadsafewithEagerLoadingSingleton threadsafewithEagerLoadingSingleton = ThreadsafewithEagerLoadingSingleton.GetInstance;

            //NestedClassUsedReasonExample nestedClassUsedReasonExample = NestedClassUsedReasonExample.GetInstance;

            //NestedClassUsedReasonExample.InsideClass obj = new NestedClassUsedReasonExample.InsideClass();
        }
        static void CreateThreadSafeInstance1()
        {
            ThreadSafetySingleton threadSafetySingleton = ThreadSafetySingleton.GetInstance;
            threadSafetySingleton.printDetails("From CreateThreadSafeInstance1");
        }
        static void CreateThreadSafeInstance2()
        {
            ThreadSafetySingleton threadSafetySingleton = ThreadSafetySingleton.GetInstance;
            threadSafetySingleton.printDetails("From CreateThreadSafeInstance2");
        }
    }
}
