/*Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
// Через рекурсию


System.Console.WriteLine(Sum(1,15));
System.Console.WriteLine(Sum(4,8));

int Sum(int M, int N)
{
    if (M==N) return M;
    else return Sum(M+1,N)+M;
}