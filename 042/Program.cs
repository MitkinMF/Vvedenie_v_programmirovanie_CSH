// 42. Выяснить являются ли три числа сторонами треугольника

double a=10, b=10,c=10;

System.Console.WriteLine(IsTriangle(a,b,c));


bool IsTriangle(double a, double b, double c)
{
    return (a+b>c && a+c>b && b+c>a);
}
