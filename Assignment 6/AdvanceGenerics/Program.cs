using System;
using AdvanceGenerics.Models;
using AdvanceGenerics.TrainingList;
using System.Collections.Generic;

namespace AdvanceGenerics
{
    class Program
    {
        static void Main()
        {
            var obj = new TaazaaTrainingList();
            List<Details> temp =  obj.TrainingList();
            int  t = temp.Count;
            for(int i=0;i<=t;i++)
            {
                Console.WriteLine(temp[i].Email+" "+temp[i].PhoneNumber);

            }
            

           
        }
    }
}
