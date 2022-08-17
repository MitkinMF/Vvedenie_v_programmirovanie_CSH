//71. Написать программу вычисления функции Аккермана 

int m=3;
int n=5;
System.Console.WriteLine(A(m,n));

int A(int m, int n)
{
    if (m==0) return n+1;
    else if (n==0 && m>0) return A(m-1,1);
    else return A(m-1, A(m,n-1));
}

