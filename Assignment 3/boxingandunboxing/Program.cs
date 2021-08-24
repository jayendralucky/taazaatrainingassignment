using System;

namespace boxingandunboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=100;//value type
          object obj =i;//boxing process
          i=200;// boxing process is done 
          System.Console.WriteLine(i);
          System.Console.WriteLine(obj);
          int j = (int)obj;// unboxing is done 
          Console.WriteLine(j);

        }
    }
}
