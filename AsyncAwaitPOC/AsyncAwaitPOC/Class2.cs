using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitPOC
{
    class Class2
    {
        public async Task Func2()
        {

            Console.WriteLine("Entered func2: Writing in console for func2 function");
            HttpClient client = new HttpClient();

            // GetStringAsync returns a Task<string>. That means that when you await the
            // task you'll get a string (urlContents).
            Console.WriteLine("Making a call to load the website : Writing in console for func2 function");
            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");

           
            await getStringTask;
            afterAwaitFunction();

        }
        public void afterAwaitFunction()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Writing in console for dosomework function");
        }
    }
}
