//С клавиатуры вводятся три числа. Найти максимальное из трех чисел

double a,b,c;

System.Console.WriteLine("введите число а");
string? s=Console.ReadLine(); //ввод данных a
a=Convert.ToDouble(s); // конвертация в double

System.Console.WriteLine("введите число b");
s=Console.ReadLine();   //ввод данных b
b=Convert.ToDouble(s); // конвертация в double

System.Console.WriteLine("введите число с");
s=Console.ReadLine();   //ввод данных c
c=Convert.ToDouble(s); // конвертация в double

if (a==b && a==c) // проверка на равенство
{
    System.Console.WriteLine("числа равны");
}

else if (a>b && a>c)
{
    System.Console.WriteLine($"а={a} максимальное число");
}

else if (b>a && b>c)
{
    System.Console.WriteLine($"b={b} максимальное число");
}


else 
{
    System.Console.WriteLine($"c={c} максимальное число");
}
