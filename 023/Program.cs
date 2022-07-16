//Найти расстояние между точками в пространстве 2D

double x1,x2,y1,y2, dist;

System.Console.WriteLine("введите кординату x1 точки A");
string? s=Console.ReadLine(); //ввод данных 
x1=Convert.ToDouble(s); // конвертация в double

System.Console.WriteLine("введите кординату y1  точки A");
s=Console.ReadLine();   //ввод данных 
y1=Convert.ToDouble(s); // конвертация в double

System.Console.WriteLine("введите кординату x2  точки B ");
s=Console.ReadLine();   //ввод данных c
x2=Convert.ToDouble(s); // конвертация в double

System.Console.WriteLine("введите кординату y2  точки B");
s=Console.ReadLine();   //ввод данных 
y2=Convert.ToDouble(s); // конвертация в double

dist=Math.Sqrt (Math.Pow((x2-x1), 2) + Math.Pow((y2-y1),2));  

System.Console.WriteLine($"расстояние между точками A и B равно {dist}");