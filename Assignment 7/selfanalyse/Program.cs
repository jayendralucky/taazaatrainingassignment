using System;
using selfanalyse.Computer;

namespace selfanalyse
{
    class Program
    {
        static void Main(string[] args)
        {
            var vicky =new Lucky(101,2.0);
             var rohan =new Lucky(102,3.0);

             var cmp = vicky.ComputerName();
             Console.WriteLine(cmp);

             var sal = rohan.ComputerName();
             Console.WriteLine(sal);

             var f =Lucky.Filename();
             Console.WriteLine(f);

             Console.WriteLine(Lucky.Filename());

        }
    }
}
