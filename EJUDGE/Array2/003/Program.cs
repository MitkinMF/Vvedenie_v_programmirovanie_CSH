/*
В квадратной таблице NxN подсчитать суммы чисел, стоящих на диагоналях.
Входные данные
Во входном файле содержится число N (100>=N>=1), а затем матрица NxN.
Элементы матрицы - числа из диапазона integer.
Выходные данные
В выходной файл выдать сначала сумму чисел на главной,
а затем - на побочной диагонали.
*/

int N=3;
int M=3;

int [,] a;//описываем массив

a=new int [N,M];//создаем массив
//Инициализация случайными числами
Random random=new Random();//Создали объект типа Random

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
    {
        a[i,j]=random.Next(1,5);
    }
}

//Вывод массива на экран
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
         System.Console.WriteLine();
}

int sum1=0;
int sum2=0;

for (int i = 0; i < a.GetLength(0); i++)
{
    sum1=sum1+a[i,i];
    sum2=sum2+a[i,N-i-1];       
}
System.Console.WriteLine(sum1);
System.Console.WriteLine(sum2);
