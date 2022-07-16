//Программа проверяет пятизначное число на палиндром.

Console.WriteLine ("Введите целое пятизначное число");
string? s = Console.ReadLine();

if (s.Length==5) //проверка на пятизначность
{
    if (s[0]==s[4] && s[1]==s[3] )  //проверка на палиндром
    {
        System.Console.WriteLine($"Число {s} - палиндром");
    }

    else
    {
        System.Console.WriteLine($"Число {s} - не палиндром");
    }
}    
else
{
    System.Console.WriteLine($"Необходимо пятизначное число");
}
