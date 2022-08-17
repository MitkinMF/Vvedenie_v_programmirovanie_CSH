class Program
{
    struct Fraction
    {
        private int numerator, denumerator;
        public Fraction (int numerator, int denumerator)
        {
            if (denumerator==0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
            this.numerator=numerator;
            this.denumerator=denumerator;
        }
    public Fraction Plus(Fraction a, Fraction b)
    {
        Fraction c = new Fraction(a.numerator*b.denumerator+ b.numerator*a.denumerator, a.denumerator*b.denumerator);
        return c;
    }

    public static Fraction Minus(Fraction a, Fraction b)
        {
            Fraction c = new Fraction(a.numerator*b.denumerator-b.numerator*a.denumerator, a.denumerator*b.denumerator);
        }
    public static Fraction Multi(Fraction a, Fraction b)
        {
            Fraction c = new Fraction(a.numerator*b.numerator, a.denumerator*b.denumerator);
        }

    public static Fraction Divide(Fraction a, Fraction b)
        {
            Fraction c = new Fraction(a.numerator*b.numerator, a.denumerator*b.denumerator);
        }


    public void Print ()
    {

    }



    }

    static void Main()
    {
        Fraction a=new Fraction(1,2);
        Fraction b=new Fraction(1,3);
        Fraction c=new Fraction.Plus(a,b);


        try
        {
            Fraction fraction=new Fraction(1,0);
        }
        catch
        {
            System.Console.WriteLine("Ошибка");
        }
       // DateTime date=new DateTime(14,8,2022);
    }
}