//Удалить вторую цифру целого числа введенного с клавиатуры.

Console.WriteLine ("Введите целое число");
string? s = Console.ReadLine();

string? s_cut1 = s.Substring(0,s.Length-(s.Length-1)); // Обрезает первую цифру числа
string? s_cut2 = s.Substring(2); //Обрезает число начиная с третьей цифры

System.Console.WriteLine($"Число без второй цифры - {s_cut1 + s_cut2}");