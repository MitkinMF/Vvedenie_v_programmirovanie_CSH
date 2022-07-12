int i=0;
int N=10;
while(i<N) // универсальный цикл
{
    i=i+1;
    System.Console.WriteLine(i);
}

//for
for (i=0;i<N;i=i+1)
{
    System.Console.WriteLine(i);
}

// do
do
int a;
{
    System.Console.WriteLine("введите положительное число");
    a=Convert.ToInt32(Console.ReadLine());
}
while(a<=0);