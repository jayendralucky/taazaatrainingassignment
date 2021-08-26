using System;
using delegatep.Noida;
delegate int customdelegate();

namespace delegatep
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Broker();
            customdelegate cobj = new customdelegate(obj1.flat1);
            var temp1 = cobj.Invoke();
            Console.WriteLine(temp1);
            
             cobj+=obj1.flat3;
            var temp2 = cobj.Invoke();
            Console.WriteLine(temp2);

            
            


            

        }
    }
}
