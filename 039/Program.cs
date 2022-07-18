//39. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int N=12;
int[] a;
Init(out a,N);


//решение задачи

int s=0;
for (int i=0; i<a.Length;i=i+2)
{
    s=s+a[i];
}    
System.Console.WriteLine(s);
for (int i=0; i<a.Length;i=i+2)
{
    if (i%3!=0)
        s=s+a[i];
}    
System.Console.WriteLine(s);



void Init(out int[] t, int Lenght,int min=0, int max=10)  //функция создание массива 
//c заполнением его псевдослучайными числами
{
    t=new int[Lenght];
    Random random = new Random();
    for (int i=0;i<t.Length;i++)
    t[i]=random.Next (min, max+1);
}
