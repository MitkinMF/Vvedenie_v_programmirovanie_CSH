//37.Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int N=10;
int[] a;
Init(out a,N,min:100,max:1000);
//вывод массива (до обработки)
Print(a,"A");


//решение задачи
System.Console.WriteLine();
CountEven (a); //вызов функции подсчета четных и нечетных чисел



//Функции
void CountEven (int[] a) //функция подсчета четных и нечетных чисел
{
    int even=0;
    int notEven=0;
    for (int i=0;i<a.Length;i++)
        if (a[i]%2==0) even++;
        else notEven++;
    System.Console.WriteLine($"Количество четных чисел = {even}");
    System.Console.WriteLine($"Количество нечетных чисел = {notEven}");
} 

void Init(out int[] t, int Lenght,int min=0, int max=10)  //функция создание массива 
//c заполнением его псевдослучайными числами
{
    t=new int[Lenght];
    Random random = new Random();
    for (int i=0;i<t.Length;i++)
    t[i]=random.Next (min, max+1);
}

void Print (int[] t, string variableName) //вывод элементов массива 
{
    for (int i=0;i<t.Length;i++)
    System.Console.Write($"{variableName}[{i}]={t[i]} ");
}    