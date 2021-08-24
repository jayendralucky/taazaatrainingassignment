using System;


namespace specialoperation
{
    class Program
    {
         public void show(params object[] v)
        {
            for(int i=0;i<v.Length;i++)
            {
               Console.WriteLine(v[i]);
            }
           foreach(var i in v)
           {
               Console.WriteLine(i);
           }

        } 
        static void Main(string[] args)
        {
            Program program = new Program();
            program.show(2,4,5,7,9,10,12,58); 
            
           
            
             
             
             
        }
    }
}
