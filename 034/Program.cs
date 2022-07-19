//34.Задать массив из 12 элементов, заполненных числами из диапазона[-9, 9].
// Найти сумму положительных/отрицательных элементов массива

//инициализация массива
int N=12;
int[] a;
Init(out a,N,-9,9);

//вывод массива (до обработки)
Print(a,"A");

//решение задачи
int sumNegative;
int sumPositive;
Solve(a, out sumPositive, out sumNegative);

//Вывод результатов
System.Console.WriteLine($"\nсумма положительных значений: {sumPositive}");   //оператор \n производит вывод с новой строки   
System.Console.WriteLine($"сумма отрицательных значений:{sumNegative}");    

//функции
void Init(out int[] t, int Lenght,int min=0, int max=10) //функция создание массива 
//c заполнением его псевдослучайными числами
{
    t=new int[Lenght];
    Random random = new Random();
    for (int i=0;i<t.Length;i++)
        t[i]=random.Next (min, max+1);
}

void Print (int[] t, string variableName) //вывод результатов
{
    for (int i=0;i<t.Length;i++)
        System.Console.Write($"{variableName}[{i}]={t[i]} "); // Write выводит данные в строку 
}

void Solve(int[] a, out int sumPositive,  out int sumNegative) //функция решения
{ 
    sumPositive=0; //нужно обязательно присвоить значение!!!
    sumNegative=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]>0)
            sumPositive=sumPositive+a[i];
    
    for(int i=0;i<a.Length;i++)
        if (a[i]<0)
            sumNegative+=a[i];
}