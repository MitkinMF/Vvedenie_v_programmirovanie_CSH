//С клавиатуры вводятся два вещественных числа.
//Проверять является ли одно из них квадратом второго
double a;
double b;
string? s=Console.ReadLine(); //ввод данных
a=Convert.ToDouble(s); // конвертация в double
s=Console.ReadLine();
b=Convert.ToDouble(s); // конвертация в double

if (a*a==b)
{
    System.Console.WriteLine("b является квадратом a");
}

else
{
    if (b*b==a)
   {
    System.Console.WriteLine("а является квадратом b");
   }
   else 
   {
    System.Console.WriteLine("числа не являются квадратами друг друга");
   }
}





/*
b=a*a; //обработка данных
System.Console.WriteLine("{0}^2={1}",a,b); //строка форматированиия
System.Console.WriteLine($"{a}^2={b}"); // строка интерполяции

if (2*2==4)
{

}
else
{

}
*/