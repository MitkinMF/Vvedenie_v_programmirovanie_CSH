class Program
{
struct Point
{
    private double  x, y;  // начальное значение конструктора

    //конструктор 1
    public Point()
    {
        x=0;y=0;
    }
 //конструктор 2
    public Point(double value)
        {
            x=value;y=value;
        }
 //конструктор 3
    public Point(double _x, double y)
        {
            x=_x; this.y=y;
        }

    //публичные методы (альтернатива свойствам)
    public double GetX()
    {
        return x;
    }
    public double GetY()
        {
            return y;
        }

    public void SetX(double value)
        {
            return x;
        }
    public void SetY(double value)
        {
            return y;
        }
//свойства: механизм обращени 

    public double X 
    {
        //акцесоры доступа
        get
        {
            return x;
        }
        set
        {
            x=value;
        }
    }

     public double Y
    {
        //акцесоры доступа
        get
        {
            return y;
        }
        set
        {
            y=value;
        }
    }

    static public double Dist(double x1, double y1, double x2, double y2) //Перегрузка 1
    {
    return Math.Sqrt (Math.Pow((x2-x1), 2) + Math.Pow((y2-y1),2));  // вычисление расстояния м/у двумя точками по теореме пифагора
    }
    static public double Dist(Point A, Point B)
    {
    return Math.Sqrt (Math.Pow((A.x-B.x), 2) + Math.Pow((A.y-B.y),2)); //Перегрузка 2
    }
}

static void Main()
{
    Point A,B;
    A=new Point(0,0);
    B=new Point();
    A.X=5;
    double  x1=0, y1=0, x2=4, y2=0;
    double distanse = Point.Dist(A,B);
    System.Console.WriteLine(distanse); 
}

}