using System;

namespace arrayassin
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int [10];// declaring of array
            arr[0] = 10; // intializing of array 
            arr[1] = 20;
            arr[2] = 30;
            arr[4] = 40;
            arr[5] = 50;
           foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
