void Loop(int i, int N)
{
    System.Console.Write($"{i} ");
    if (i<N) Loop(i+1,N);
    else return;
}

//Loop(1,10);


int F(int n)
{
    if(n>0) return F(n-1)*n;
    else return 1;
}
System.Console.WriteLine(F(5));