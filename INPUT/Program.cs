//
int i=0;
string? s=Console.ReadLine();
string[] ss=s.Split(' ');
int[] a=new int[ss.Length];

for(int i=0; i<a.Length; i++)
    a[i]=int.Parse(ss[i]);
    System.Console.WriteLine(a[i]);

for(int i=0; i<ss.Length; i++)
    System.Console.WriteLine(a[i]);