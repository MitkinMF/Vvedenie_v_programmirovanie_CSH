//48. Написать программу копирования массива

int[] a;
Init(out a, 12, -9,9); // инициализация массива a
Print(a,"A");

//решение задачи
int[] b;
CloneArray(a, out b);
System.Console.WriteLine(); //перенос строки
Print(b,"B");


//b=(int[])a.Clone)(); // клонирование массива а в b  метод Clone

// Функции
void CloneArray(int[] a, out int[] b ) //функция клонирования массива
{
    b=new int[a.Length];
    for(int i=0;i<a.Length; i++)
        b[i]=a[i];
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