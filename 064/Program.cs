/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 5, 6, 7, 8""
*/
// сделал через рекурсию

Natural(1,5);
System.Console.WriteLine();
Natural(4,8);

int Natural(int M, int N)
{
    if(M<N) 
    {
        System.Console.Write($"{M}, ");
        return Natural(M+1,N);
    }
    else 
    {
        System.Console.Write($"{N}");
        return N;
    }
}
