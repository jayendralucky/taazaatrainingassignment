using System;
using System.Collections.Generic;
using AdvanceGenerics.Models;
namespace AdvanceGenerics.TrainingList
{
    public class TaazaaTrainingList
    {
        public List<Details>  TrainingList()
        {
            List<Details> obj =new List<Details>();
            obj.Add(new Details{
                Email ="abc@gmail.com",
                PhoneNumber=999

            });
            obj.Add(new Details{
                Email ="xyz@gmail.com",
                PhoneNumber=888
            });
            return obj;
        }
    }
}