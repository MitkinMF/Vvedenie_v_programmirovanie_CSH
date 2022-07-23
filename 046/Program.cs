//46. Показать числа Фибоначчи


int N=15;  //Количество элементов последовательности Фибоначи

Fibonachi(N);

//функция
void Fibonachi(int N) //рассчитывает и отображает последовательность Фибоначи
{
switch(N)
{
       case 0:
        System.Console.WriteLine($"F0=0 "); 
        break;
    case 1:
        System.Console.Write($"F0=0 F1=1 "); 
        break;
    default:
        double f0=0;
        double f1=1;
        System.Console.Write($"F0=0 F1=1 ");
        for(int i=2; i<=N; i++)
        {
            double f=f1+f0;
            System.Console.Write($"F{i}={f} ");
            f0=f1;
            f1=f;
        }
        break;
}      
}