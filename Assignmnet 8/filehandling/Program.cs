using System;
using System.IO;

namespace filehandling
{
    class Program
    {
        class File
        { 
            public void data()
            {
                StreamWriter sw = new StreamWriter("lucky");
                Console.WriteLine("enter the text that you want to add in file");
                string str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();

            } 

        }
        static void Main(string[] args)
        {
            File f = new File();
            f.data();
            Console.ReadKey();
            
        }
    }
}
