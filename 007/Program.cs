
//Выяснить является ли число чётным

Console.WriteLine ("Введите число a");
string? s = Console.ReadLine();
int a = Convert.ToInt32(s);

if (a%2 == 0) //проверка на четность
{
    Console.WriteLine("Число a является чётным.");
} 
else
{
     Console.WriteLine("Число a не является чётным.");
}

 