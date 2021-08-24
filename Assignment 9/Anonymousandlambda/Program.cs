using System;
delegate void operation(int  n1,int n2);

namespace Anonymousandlambda
{
    class Program
    {
        static void Main()
        {
            //ANONYMOUS METHOD
            operation obj =delegate(int n1,int n2)
            {
                Console.WriteLine(n1*n2);
            };
            //Lambda method
            operation obj1 =(int n3,int n4)=>
            {
                Console.WriteLine(n3+n4);
            };
            obj(20,30);
            obj1(40,50);
            
        }
    }
}
