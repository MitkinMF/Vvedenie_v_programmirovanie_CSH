//Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

Console.WriteLine ("Введите целое число");
string? s = Console.ReadLine();
int a = Convert.ToInt32(s);

int b=a%10; // остаток от деления на 10 (или последняя цифра десятичного числа)
System.Console.WriteLine($"последняя цифра числа {b}");
