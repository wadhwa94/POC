using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitPOC
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("started Execution main entry making call to func1");
            var task = Class1.func1();
            Console.WriteLine("leaving main");
            task.Wait();
           // Console.Read();
        }

    }
}
