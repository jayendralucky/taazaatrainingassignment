using System;

namespace predicatedelegate
{
    class Program
    {
        static bool Isupper(string str)
        {
            return str.Equals(str.ToUpper());
        }
        static void Main(string[] args)
        {
            Predicate<String> isupper = Isupper;
            bool result = isupper("gjhsagh");
            Console.WriteLine(result);
        }
    }
}
