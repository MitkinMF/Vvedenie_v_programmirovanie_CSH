//С клавиатуры вводятся два числа a и b. Найти максимальное из них.

double a;
double b;

System.Console.WriteLine("введите число а");
string? s=Console.ReadLine(); //ввод данных
a=Convert.ToDouble(s); // конвертация в double

System.Console.WriteLine("введите число b");
s=Console.ReadLine();
b=Convert.ToDouble(s); // конвертация в double

if (a<b)
{
    System.Console.WriteLine($"а={a} меньше b={b}");
}

else
{
    System.Console.WriteLine($"b={b} меньше а={a}");
}