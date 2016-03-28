using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitPOC
{
    class Class1
    {

        
        public static async Task func1()
        {
            Console.WriteLine("Entered func1: Writing in console for func2 function");
            Class2 obj = new Class2();
            await obj.Func2();
            Console.WriteLine("after making an await on func2: Writing in console for func2 function");

        }
    }
}
