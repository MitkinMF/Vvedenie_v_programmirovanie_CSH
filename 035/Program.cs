//35. Написать программу замены элементов массива на противоположные

int N=13;
int[] a;
Init(out a,N,0,15);

Print(a);

//Решение
Reverse(a);

System.Console.WriteLine();
Print(a);

//Функции
void Init(out int[] t, int Lenght,int min=0, int max=10) //функция создание массива 
//c заполнением его псевдослучайными числами
{
    t=new int[Lenght];
    Random random = new Random();
    for (int i=0;i<t.Length;i++)
        t[i]=random.Next (min, max+1);
}

void Print (int[] t) //функция вывода массива
{
    for (int i=0;i<t.Length;i++)
        System.Console.Write($"{t[i]} "); // Write выводит данные в строку 
}

void Reverse(int[] a) //функция переворачивания массива
{
    int temp;
    for (int i=0;i<=a.Length/2;i++)
    {  
        temp = a[i];
        a[i]=a[a.Length-i-1];
        a[a.Length-i-1] = temp;
    }
}
