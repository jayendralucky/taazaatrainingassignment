using System;
namespace ExceptionHandling.Coustomer
{
    //Exception class in csharp is a base class in exception handling which can handel all the exception
   // arithemeticexception is a base class of dividebyzeroexception that why base class can handel drive class exception
    public class Coustomers
    {
        int result;
         Coustomers()
         {
             result =0;

         }
         public void Divide(int n, int m)
         {
             try
             {
                 result =n/m;
             }
             catch(ArithmeticException e)
             {
                 Console.WriteLine("Yes Exception has been caught");
             }
             finally
             {
                 Console.WriteLine(result);
             }
         }
        
    }
}