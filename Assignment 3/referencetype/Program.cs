﻿using System;

namespace referencetype
{
    class A {  
    public int value   
    {  
        get;  
        set;  
    }  
    public A(int passbyref)  
    {  
        this.value = passbyref;  
    }  
}  
class Program  
{  
    static void Main(string[] args)  
    {  
        A v1 = new A(12);  
        A v2 = new A(22); //Breakpoint  
        v2 = v1;  
        Console.WriteLine(v1.value);  
        Console.WriteLine(v2.value);  
        Console.ReadLine();  
    }  
}
}

