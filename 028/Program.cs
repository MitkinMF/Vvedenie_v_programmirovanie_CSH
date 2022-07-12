//Определить количество цифр в числе. Сделать подпрограмму.

int N=125667564; //число
int CountDigits(int N) //определение функции
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
System.Console.WriteLine(CountDigits(N));