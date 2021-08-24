using System;
using System.Collections.Generic;

namespace assignment6
{
    class Program
    {


        static void Main(string[] args)
        {
            List<string> list  = new List<string>();
            for(int i=0;i<=3;i++)
            {
                switch(i)
                {
                    case 1:
                    list.Add("jayendra singh");
                    list.Add("vedant singh");
                    Console.WriteLine("Names has been added to the list");
                    break;
                    case 2:
                    if(list.Contains("vedant singh"))
                    {
                        Console.WriteLine("Name has been found");
                    }
                    else
                    {
                        Console.WriteLine("The given name does not present in the list");

                    }
                    break;

                }
            }

        }
    }
}
