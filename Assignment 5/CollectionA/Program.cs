using System;
using System.Collections;
using CollectionA.Jayendra;

namespace CollectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            var objlist = new student();
            var List =objlist.studentdetails();
            int count = List.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(List[i].Sid+" " +List[i].Sname);
            }
            
        }

    }
}
