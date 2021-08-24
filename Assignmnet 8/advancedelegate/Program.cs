using System;
using advancedelegate.Arithemetic;
delegate void ArithmeticDelegate(double D1,double d2);

namespace advancedelegate
{
    class Program
    {
        static void Main()
        {
            
            ArithmeticDelegate cobj= new ArithmeticDelegate(ArithmeticOperation.Addition);//using delegate
            cobj.Invoke(5,4);//invoke will execute addition function
            cobj+=ArithmeticOperation.Multiply;
            cobj.Invoke(2,3); 

           
            
           
        }
    }
}
