//27.Возведите число А в натуральную степень B используя цикл
int A=67;
int B=4;
Exponentiation(A,B);

void Exponentiation(int A, int B) //функция возведения числоа A в степень B
{
    int a=0;
    for (int i=1;i<=B;i++)
    {
        if (i==1) a=A;
        else a*=A;
    }
System.Console.WriteLine(a);
}
