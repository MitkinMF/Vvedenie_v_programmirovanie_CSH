//Найти сумму чисел от 1 до А
int A=10;
Sum(A);

void Sum(int A) //функция расчета и вывода суммы чисел от 1 до A
{
    int a=0;
    for (int i=0;i<=A;i++)
    {
        a+=i;
    }
System.Console.WriteLine(a);
}
