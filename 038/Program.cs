//38.В одномерном массиве из 123 чисел
//найти количество элементов из отрезка [10,99]

int N=123;
int[] a;
Init(out a,N,min:10,max:300);
//вывод массива (до обработки)
Print(a,"A");


//решение задачи
System.Console.WriteLine();
CountNumbers(a); //вызов функции подсчета чисел из диапазона [10,99]



//Функции
void CountNumbers (int[] a) //функция подcчета чисел из диапазона [10,99]
{
    int numb=0;
    for (int i=0;i<a.Length;i++)
        if (a[i]>=10 && a[i]<=99) numb++; //условие диапазона
    System.Console.WriteLine($"Количество чисел из диапазона [10,99] = {numb}");
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