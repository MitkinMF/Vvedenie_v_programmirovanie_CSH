/*Максимальная строка
В матрице найти номер строки, сумма чисел в которой максимальна.
Входные данные
Во входном файле записаны числа N и M - количество строк и
столбцов матрицы (каждое из них - из диапазона от 1 до 100),
а затем сама матрица. Элементы матрицы - числа из диапазона integer.
Выходные данные
В выходной файл вывести номер строки,
сумма чисел в которой максимальна. Если таких строк несколько,
вывести последнюю из них.

Пример входного файла
3 2
1 2
3 4
5 6
*/
using System;
string s=Console.ReadLine();
int N=int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries )[0]);
int M=int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries )[1]);
int[,] a=new int[N,M];
for (int i=0; i<N;i++)
{
    s=Console.ReadLine();
    string[] ss=s.Split(' ', StringSplitOptions.RemoveEmptyEntries );
    for(int j=0;j<ss.Length;j++)
    a[i,j] = int.Parse(ss[j]);
}
//вывод
for(int i=0;i<a.GetLength(0); i++) 
  {
     for(int j=0; j<a.GetLength(1); j++)
        { 
        System.Console.Write($"{a[i,j]} ");
        }
 System.Console.WriteLine();
}
int max=0;
int imax=0;
for(int i=0;i<a.GetLength(0); i++)
{
    int sum=0;
    for (int j=0; j<a.GetLength(1); j++)
    {
        sum=sum+a[i,j];
        if(sum>max)
         {
            max=sum;
            imax=i;
         }
    }
} 
System.Console.WriteLine(imax+1);