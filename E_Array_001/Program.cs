//dd
using System;

namespace Mitkin
{
    class Program
    {
        static void Main()
        {
            string? s=Console.ReadLine();
            string[] ss=s.Split(' ');
            int[] a=new int[ss.Length];
            for(int i=0; i<a.Length; i++)
                a[i]=int.Parse(ss[i]);
          Array.Reverse(a);

          for(int i=0; i<ss.Length; i++)
            System.Console.Write($"{a[i]} ");

        }
    }
}
