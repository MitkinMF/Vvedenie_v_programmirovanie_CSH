//По заданному с клавиатуры номеру дня недели вывести его название

var days_of_week = new Dictionary<int, string>() //инициализация словаря дней недели
{
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Воскресенье"},
};

int a;
System.Console.WriteLine("Номер дня недели от 1 до 7");
string? s=Console.ReadLine(); //ввод данных
a=Convert.ToInt32(s); // конвертация строки в int

if (a>=1 && a<=7) // проверка на правильность номера
{
    System.Console.WriteLine($"{days_of_week[a]}"); //вывод дня недели во его ключу в словаре    
}
else

{
    System.Console.WriteLine($"неверный номер"); 
}


/*

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
*/