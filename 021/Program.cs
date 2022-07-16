//Задать номер четверти, показать диапазоны для возможных координат

double a;
System.Console.WriteLine ("Введите номер четверти координатной плоскости");
string? s=Console.ReadLine(); //ввод данных 
a=Convert.ToDouble(s); // конвертация в double

if (a==1) //проверка на 1-ую четверть
{
    System.Console.WriteLine("В 1-ой четверти диапазоны значений: х (0, +inf), у(0,++inf)");
}

else if (a==2) //проверка на 2-ую четверть
{
    System.Console.WriteLine("Во 2-ой четверти диапазоны значений: х(0, -inf), у(0,+inf)");
}

else if (a==3) //проверка на 3-ую четверть
{
    System.Console.WriteLine("В 3-ей четверти диапазоны значений: х(0, -inf), у(0,-inf)");
}

else if (a==4) //проверка на 4-ую четверть
{
    System.Console.WriteLine("В 4-ой четверти диапазоны значений: х(0, +inf), у(0,-inf)");
}

else
{
    System.Console.WriteLine("Не верный номер");
}
