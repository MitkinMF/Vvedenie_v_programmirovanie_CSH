//30. Написать программу вычисления произведения чисел от 1 до N

int N=6;

Мultiplication(N);


void Мultiplication(int N) //функция расчета и вывода произведения чисел от 1 до N
{
    int a=1;
    for (int i=1;i<=N;i++)
    {
        a*=i;
    }
System.Console.WriteLine(a);
}
