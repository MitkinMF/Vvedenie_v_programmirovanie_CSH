//25.Вывести на экран кубы чисел от 1 до N

int N=12;
Cubes(N);

void Cubes(int N) //функция вывода таблицы кубов от 1 до N
{
    int a=0;
    for (int i=1;i<=N;i++)
    {
        a=i*i*i;
        System.Console.WriteLine($"{i} в кубе = {a}");
    }
}


