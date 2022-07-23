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
System.Console.WriteLine("Введите номер дня недели от 1 до 7");
string? s=Console.ReadLine(); //ввод данных
a=Convert.ToInt32(s); // конвертация строки в int

if (a>=1 && a<=7) // проверка на правильность номера
{
    System.Console.WriteLine($"{days_of_week[a]}"); //вывод дня недели по его ключу в словаре    
}

else
{
    System.Console.WriteLine($"неверный номер"); 
}


switch(a)
{
    case 1:
      System.Console.WriteLine($"Monday"); 
      break;
    case 2:
      System.Console.WriteLine($"Tuesday"); 
      break;
    case 3:
      System.Console.WriteLine($"Wednesday"); 
      break;
    case 4:
      System.Console.WriteLine($"Thursday"); 
      break;
    default:
        System.Console.WriteLine($"wrong"); 
        break;
}