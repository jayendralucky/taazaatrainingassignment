using System;

namespace Lucky
{
    public interface A
	    {
	        void lucky();
	        
	    }
	    class name:A
	    {
	        public void lucky()
	        {
	            Console.WriteLine("i am good");
	        }
	    
	        public static void Main()
	        {
	        name h =new name();
	        h.lucky();
	        Console.ReadLine();
	        }
	        

	    }
	}
