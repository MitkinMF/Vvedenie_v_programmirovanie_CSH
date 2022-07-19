//24.Вывести на экран таблицу квадратов чисел от 1 до N

int N=12;
TableOfSquares(N);

void TableOfSquares (int N) //функция вывода таблицы квадратов от 1 до N
{
    int a=0;
    for (int i=1;i<=N;i++)
    {
        a=i*i;
        System.Console.WriteLine($"{i} в квадрате = {a}");
    }
}


