using System;
using day8t.AdvDelegate;

//delegate void PhoneDelegate();
delegate bool StudyDelegate();
namespace day8t
{
    class Program
    {
        static void Main()
        {
            //function delegate
           Study study = new Study();
           Func<string,string> func = study.Name;
           string s = func("lucky");
           Console.WriteLine(s);

           // action delegate
           Action action = study.PhoneNo;
           action();

           // predicate delegate
           Predicate<string> predicate = study.StudyStatus;
           var v=predicate("lucky");
           Console.WriteLine(v);
        }
    }
}
