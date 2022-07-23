//45. Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
/*
решение уравнения: 
k1*x+b1=k2*x+b2 
x=(b2-b1)/(k1-k2)
*/
// входные данные
double b1=4;
double b2=4;
double k1=4;
double k2=4;

//решение
Solve(b1, b2, k1, k2);


//функции
void Solve (double b1,double b2, double k1, double k2) //функция нахождения значений x и y
{
if (k1==k2) // проверка на параллельность
{
    if (k1==k2 && b1==b2) // проверка на полное совпадение
        System.Console.WriteLine($"Прямые совпадают");
    else 
        System.Console.WriteLine($"Прямые параллельны");
}
else
{ 
    double x=(b2-b1)/(k1-k2);  
    double y=k1*x+b1;
    System.Console.WriteLine($"Точка пересечения прямых:  x={x},  y={y}");
}
}
