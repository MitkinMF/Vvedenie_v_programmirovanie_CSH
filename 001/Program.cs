// С клавиатуры вводится целое число. Вывести квадрат числа 
double a;
double b;
string? s;
s=Console.ReadLine(); //ввод данных
a=Convert.ToDouble(s); // конвертация в double
b=a*a; //обработка данных
System.Console.WriteLine("{0}^2={1}",a,b); //строка форматированиия
System.Console.WriteLine($"{a}^2={b}"); // строка интерполяции









//комментарии

/*
Console.WriteLine("Hello, World!");
Console.WriteLine(11%3);

int MaxFromToNumbers;
MaxFromToNumbers=2;
double d=3.14;
System.Console.WriteLine(int.MaxValue);
System.Console.WriteLine(double.MaxValue);
string s="Hello"+"erwe"; // Конкатенация строк (склеивание)
char c='a';
string? s; //объявили значение 
s=Console.ReadLine(); // присвоили значение

System.Console.WriteLine(s);
*/
