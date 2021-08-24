using System.Collections;
using System.Collections.Generic;
using CollectionA.Lucky;
namespace CollectionA.Jayendra
{
    public class student
    {
        public ArrayList studentdetails()
        {
            ArrayList arrayList=new ArrayList();
            arrayList.Add("jayendra");
            arrayList.Add("vedant");
            arrayList.Add("sonia");
            return arrayList;
        }
        public List<Sports> studentdetail()
        {
            List<Sports> obj = new List<Sports>();
            obj.Add(new Sports{
                Sid =101,
                Sname="lucky"
            });
            return obj;

        }
        }
        
    }
