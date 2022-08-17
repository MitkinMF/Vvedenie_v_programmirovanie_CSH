// 69.Найти сумму элементов от M до N, N и M заданы 
int M=1;
int N=10;


System.Console.WriteLine(Sum(M,N));

int Sum(int M, int N)
{
    if (M==N) return M;
    else return Sum(M+1,N)+M;
}

