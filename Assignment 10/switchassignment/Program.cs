using System;

namespace switchassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string  c="Y";
            while(c=="Y"||c=="y")
            {
                Console.WriteLine("Taazaa meneu");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                    Console.WriteLine("created");
                    break;
                    case 2:
                    Console.WriteLine("updated");
                    break;
                    case 3:
                    Console.WriteLine("deleted");
                    break;
                    case 4:
                    Console.WriteLine("exit the program");
                    break;
                    default:
                    Console.WriteLine("Inavlid");
                    break;
                }
                Console.WriteLine("do you want to continue ");
                c =Console.ReadLine();
            }
        }
    }
}
