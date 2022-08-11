/*Минимум в таблице

Дана таблица чисел, состоящая из N строк по M чисел в каждой. Все числа в таблице - натуральные, не превышающие 1000. Требуется найти наименьшее число в этой таблице.

Входные данные
Во входном файле записано сначала число N - количество строк, а затем число M - количество столбцом таблицы (100>=N>=1, 100>=M>=1). Далее идет сама таблица.

Выходные данные
В выходной файл выведите наименьшее число, которое встречается в таблице.

Пример входного файла
1 4
6 4 10 4
3 7 5 7
6 3 4 3
*/

using System;
string s=Console.Read();
int N=int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
int M=int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
int[,] a=new int[N,M];

for (int i=0; i<N;i++)
{
    s=Console.Readline();
    string[] ss=s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for(int j=0;j<ss.Length;j++)
        {
            a[i,j] = int.Parse(ss[j]);
        }
}

int mini = 0;
int minj = 0;
int min=a[0,0];

//решение
for(int i=0;i<a.GetLength(0); i++) 
{
    for(int j=0; j<a.GetLength(1); j++)
    { 
        if(a[i,j]<a[mini,minj])
        {
            mini=i;
            minj=j;
        }
    }    
}
System.Console.WriteLine(a[mini,minj]);