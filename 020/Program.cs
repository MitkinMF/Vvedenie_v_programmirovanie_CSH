//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

double x,y;
System.Console.WriteLine ("введите координаты точки (x,y):");
System.Console.WriteLine ("");
System.Console.WriteLine("введите х:");
string? s=Console.ReadLine(); //ввод данных x
x=Convert.ToDouble(s); // конвертация в double

System.Console.WriteLine("введите y:");
s=Console.ReadLine();   //ввод данных y
y=Convert.ToDouble(s); // конвертация в double

if (x>0 && y>0) //проверка на 1-ую четверть
{
    System.Console.WriteLine($"Точка с координатами ({x},{y}) находится в 1-ой четверти системы координат");
}

else if (x<0 && y>0) //проверка на 2-ую четверть
{
    System.Console.WriteLine($"Точка с координатами ({x},{y}) находится в 2-ой четверти системы координат");
}

else if (x<0 && y<0) //проверка на 3-ую четверть
{
    System.Console.WriteLine($"Точка с координатами ({x},{y}) находится в 3-ей четверти системы координат");
}

else if (x>0 && y<0) //проверка на 4-ую четверть
{
    System.Console.WriteLine($"Точка с координатами ({x},{y}) находится в 4-ой четверти системы координат");
}

else if (x==0 && y==0)
{
    System.Console.WriteLine($"Точка является началом координат");
}
