using System;
using day8tp.Filehandling;

namespace day8tp
{
    class Program
    {
        static void Main(string[] args)
        {
             FileHandel fileHandel = new FileHandel();
            //fileHandel.WriteToFile("I am Lucky and Doing training for betterment");
            fileHandel.ReadFromfile();
        }
    }
}
