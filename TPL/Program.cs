using System;
using System.Threading.Tasks;
using System.Threading;

namespace TPL
{
    class MyApp
    {
        public static void longTask()// act as Dbcontext
        {
            Thread.Sleep(20000);
        }
        public async static void MyCall()// act as a ,repository
        {
            await Task.Run(new Action(longTask));
            Console.WriteLine("At this point new thread has been created");
        }
        public static void Main()// act as a controller
        {
            MyCall();
            Console.WriteLine("I am main Thread");
            Console.ReadLine();
            
        }
    }
}
