
/*Вводится сначала число N, а затем N чисел. Выведите эти N чисел в обратном порядке.

Входные данные
Вводится число N (100>N>0), а затем N чисел из диапазона Integer.

Выходные данные
Выведите N чисел в обратном порядке

Пример входного файла
7
2 4 1 3 5 3 1
*/

using System;
int n=int.Parse(Console.ReadLine());
string s=Console.ReadLine();
//s=s.Trim(); удаляет пробелы вначале и конце строки   
string[] ss=s.Split(' ', StringSplitOptions.RemoveEmptyEntries); //  StringSplitOptions.RemoveEmptyEntries - удаляет пустые вхождения после split
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);

int temp;
    for (int i=0;i<=a.Length/2;i++)
    {  
        temp = a[i];
        a[i]=a[a.Length-i-1];
        a[a.Length-i-1] = temp;
    }
    
 for (int i=0;i<a.Length;i++)
   { 
    System.Console.Write($"{a[i]} ");
   }