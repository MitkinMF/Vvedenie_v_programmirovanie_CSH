//41. В Указанном массиве вещественных чисел найдите разницу 
//между максимальным и минимальным элементом

int N=20;
double[] a;
Init(out a,N);
//вывод массива (до обработки)
Print(a,"A");

//решение задачи
System.Console.WriteLine();
FoundDeltaMinMax(a); //вызов функции подсчета чисел из диапазона [10,99]

//Функции
void FoundDeltaMinMax (double[] a) //функция поиска мин. и макс. значений и разницы м/у ними.
{
    double minA=a[0];
    double maxA=a[0];
    for (int i=1;i<a.Length;i++)
        if (a[i]>maxA) maxA=a[i]; 
        else if (a[i]<minA) minA=a[i]; 
    double delta=maxA-minA;
    System.Console.WriteLine($"Разница между мин. и макс. значением = {delta}");
} 

void Init(out double [] t, int Lenght)  //функция создание массива 
//c заполнением его псевдослучайными числами
{
    t=new double[Lenght];
    Random random = new Random();
    for (int i=0;i<t.Length;i++)
    t[i]=random.NextDouble ()*100;  //NextDouble используется без аргументов. 
                                    //Возвращает вещественное число от 0 до 1.

}


void Print (double[] t, string variableName) //вывод элементов массива 
{
    for (int i=0;i<t.Length;i++)
    System.Console.Write($"{variableName}[{i}]={t[i]} ");
} 
