// делегаты
namespace Mitkin
{

    class Program
    {
        delegate bool IsChar(char c); // IsChar


        static int CountChar(string s, IsChar isChar)
        {
            int k=0;
            for(int i=0; i<s.Length;i++)
                if () k++;
            return k;    
        }

        // подсчитать количество латинских символов
        // подсчитать количество  маленьких латинских символов
        // подсчитать количество  цифр  

        static int CountCharBigLatin(string s)
        {
            int k=0;
            for(int i=0; i<s.Length;i++)
                if (s[i]>='a' && s[i]<='z') k++;
            return k;    
        }


        static bool IsBigLatin(char c)
        {
            return c>='A' && c<='Z';
        }



        static void Main()
        {

            IsChar isChar=new IsChar(IsSmallLatin);
            System.Console.WriteLine(s?);

            IsChar isChar=new IsChar(IsBigLatin);  // использование делегата
            IsChar isChar=IsBigLatin;  // упрощенное создание делегата
            isChar+=IsBigLatin;  // в делегат можно поместить несколько методов
            isChar-=IsSmallLatin;  // убирает метод из делегата
            System.Console.WriteLine(CountChar(s,new IsChar()));
            
            System.Console.WriteLine(s, 
            delegate(char c) //анонимный делегат
            {
                return c>='a' && 
            }

            System.Console.WriteLine(s, 
            (char c)=>  //лямбда выражения
            {
                return c>='a' && 
            }));   

            System.Console.WriteLine(CountChar( s, 
            (c)=>c>='a' && c<='z'  //лямбда выражения однострочным
            ));
             
            [] ss=Console.ReadLine.Split('');
            //int[] a=Array.ConvertAll<string,int>(ss,new Converter<string, int>)

            System.Console.WriteLine(isChar);


        }
    }
}