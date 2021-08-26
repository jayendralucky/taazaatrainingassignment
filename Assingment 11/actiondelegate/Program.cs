using System;

namespace actiondelegate
{
    class Program
    {
        static void ConsolePrint(int i)
        {
             Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);
            
        }
    }
}
