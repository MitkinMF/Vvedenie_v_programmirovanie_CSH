//36.Определить, присутствует ли в заданном массиве, некоторое число

int N=12;
int[] a;
Init(out a,N,max:100);
//вывод массива (до обработки)
Print(a,"A");


//решение задачи
int f=400; //число 400 для поиска
a[3]=f;  // записываем в 4-ый элемент массива число 400
Search(a, f); //вызов функции линейного поиска

//Функции
void Search (int[] a, int f  ) //функция линейного поиска
{
    int j=0;
    while(j<a.Length && a[j]!=f) //цикл с условием поиска в массиве и j++
        j++;  
    if (j==a.Length)
         System.Console.WriteLine("\nNot found");
    else
         System.Console.WriteLine($"\nElement {f} found at A[{j}]");
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