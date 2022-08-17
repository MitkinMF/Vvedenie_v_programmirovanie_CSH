﻿/*54. Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] a= new int[,]  // заданный массив
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
};

//решение
PrintArray(SortDescending(a));

//методы
int [,] SortDescending (int[,] a) //метод упорядочит по убыванию элементы каждой строки 2D массива
{
    for(int i=0;i<a.GetLength(0); i++) //цикл перебора строк массива
    {
        for(int j=0; j<a.GetLength(1)-1; j++) //цикл перебора элементов строки массива
        { 
            int max=0;  //максимальное
            int jMax=0; //индекс максимального
            for(int k=j; k<a.GetLength(1); k++) //цикл перебора элементов строки массива начиная c j-того 
            {
                if (a[i,k]>max)   
                {
                    max=a[i,k]; //находим максимальное
                    jMax=k;     //находим индекс максимального
                }        
            }    
            // далее меняем местами значения в a[i,j] и a[i,jMax] если  jMax!=j
            if (jMax!=j)
            {
                int temp=a[i,j];
                a[i,j]=a[i,jMax]; 
                a[i,jMax]=temp; 
            }
        } 
    }
    return a;
}


void PrintArray (int[,] a) //метод выводит 2D массив в терминал
{
    for(int i=0;i<a.GetLength(0); i++) 
    {
        for(int j=0; j<a.GetLength(1); j++)
        { 
            System.Console.Write($"{a[i,j]} ");
        }
    System.Console.WriteLine();
    }
} 