//По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.

bool Check_kvadrat(double a, double b) // определение функции
{
    return a*a==b;
}

double a;
double b;
string? s=Console.ReadLine(); //ввод данных
a=Convert.ToDouble(s); // конвертация в double
s=Console.ReadLine();
b=Convert.ToDouble(s); // конвертация в double

if (Check_kvadrat(a,b))
{
System.Console.WriteLine("b является квадратом a");
}

else
{
    if (Check_kvadrat(b,a))
   {
    System.Console.WriteLine("а является квадратом b");
   }
   else 
   {
    System.Console.WriteLine("числа не являются квадратами друг друга");
   }
}


