//29. Подсчитать сумму цифр в числе

int N=2222222; //число

DigitsSum(N);



void DigitsSum(int N) // Функция подсчета суммы цифр
{
    int a=0;
    int buff=0;
    int forPrint=N;
    while (N!=0)
    {   
        buff=N;
        a+=buff%10;
        N=N/10;
    }
    System.Console.WriteLine($"Сумма цифр числа {forPrint} = {a}");
}

