using System;

namespace abstractclass
{
   public abstract class Happy
    {
       public abstract void lucky();
       public void no()
       {
           Console.WriteLine("day is happy today");
       }
        
    }
    class Sad:Happy// if we dont use override it will show error
    {
        public override void lucky()
        {
            Console.WriteLine("lucky the abstract method is calling");
        }

    }
    class name 
    {
        public static void Main()
        {
        Sad s = new Sad();
        s.lucky();
        s.no();

        }
        

    }
}

