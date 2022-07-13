//С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

double a,b;

System.Console.WriteLine("введите число а");
string? s=Console.ReadLine(); //ввод данных a
a=Convert.ToDouble(s); // конвертация в double

System.Console.WriteLine("введите число b");
s=Console.ReadLine();   //ввод данных b
b=Convert.ToDouble(s); // конвертация в double

if (a%b==0) //проверка на кратность
{
    System.Console.WriteLine("a кратно b ");
}

else 
{
    System.Console.WriteLine($"остаток от деления {a} на {b} равен: {a%b}");
}

