using System;

namespace valuetype
{
    class Program   
{  
    static void Main(string[] args)   
    {  
      int v1 = 12;  
        methodtoshowref(ref v1);  
        Console.WriteLine(v1);  
        Console.ReadLine();  
    }  
    public static void methodtoshowref(ref int v2)  
    {  
        v2 = 100;  
    }  
}
}

