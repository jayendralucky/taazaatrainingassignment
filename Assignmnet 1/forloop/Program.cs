using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the no for which you want to print tabl
e:- ");
 int a=Convert.ToInt32(Console.ReadLine());
 for(int i=1;i<=10;i++){
 Console.WriteLine(a+" X "+i+" = "+a*i);
 }
 Console.WriteLine("Made by Gurpreet Singh");
 }
 }
}
