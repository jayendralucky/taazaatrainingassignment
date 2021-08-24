using System;
using day4assingnment1.Movie;
using day4assingnment1.Study;


namespace day4assingnment1
{
    class Program
    {
        static void Main(string[] args)
        {
           IMovie obj = new Luckymovie();
           IStudy obj1 =new Luckystudy();
           int temp = obj.salman();
           Console.WriteLine(temp);
        }
    }
}
