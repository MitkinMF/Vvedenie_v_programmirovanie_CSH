//Определить количество цифр в числе. Сделать подпрограмму.

int N=56467654; //число

System.Console.WriteLine(CountDigits(N));


int CountDigits(int N) //функция подсчета цифр
{
    if (N==0) return 1;
    int k=0;
    while (N!=0)
    {
        k++;
        N=N/10;
    }
    return k;
}
