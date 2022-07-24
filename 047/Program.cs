//47. Написать программу масштабирования фигуры

string s = "(0,0) (2,0) (2,2) (0,2)";
double k=0.5; // коэффициент масштабирования
//решения
System.Console.WriteLine("Решение с помощью строковых методов:");
SolveString(s,k);
System.Console.WriteLine("\nРешение с помощью массива чисел:");
SolveArray(s,k);

//Решение помощью строковых методов использовано 2 цикла 
//ВАЖНО: будет работать крректно только при указанных в условии входных данных!!!
//так как в цикле вывода не учтено изменение длины строки

void SolveString(string s, double k)
{
    char[] ss=s.ToCharArray(); // создает массив символов из строки
    string ns="";
    double n;
    bool f;

    //цикл создания новой строки с числами

    for (int i=0; i<ss.Length; i++)
    { 
        f=double.TryParse(ss[i].ToString(),out n); 
        // возвращает в f истину или ложь,  
        //в n отправляет результат конвертации. 
        // Для того, чтобы работал TryParse нужно
        //снова конвертировать ss[i] из char в string
        if (f!=false) 
        {
        n=n*k; //масштабирование координаты
        ns=ns+n.ToString(); //формируем выходную строку 
        //для вывода ответа с помощью строковых методов
        }
    }

    //цикл вывода ответа 
    for (int i=0; i<ns.Length/2; i++) 
    {
        System.Console.Write($"({ns.Substring(i*2, 1)},{ns.Substring(i*2+1, 1)}) "); 
    }
}

//Далее идет решение с использованием массива чисел. Этот вариант объёмнее но
//работает при различных входных данных. Используется 3 цикла.

void SolveArray(string s, double k)
{
    char[] ss=s.ToCharArray(); // создает массив символов из строки
    double n;
    bool f;
    int N=0;

    //цикл подсчета чисел
    for (int i=0; i<ss.Length; i++) 
    { 
        f=double.TryParse(ss[i].ToString(),out n); 
        if (f!=false) N++; //счетчик цифр N длина массива чисел
    }
    
    double[] a=new double[N];
    int j=0;

    //цикл заполнения массива чисел
    for (int i=0; i<ss.Length; i++)
    { 
        f=double.TryParse(ss[i].ToString(),out n); 
        if (f!=false) 
        {
        a[j]=n*k;               
        j++;
        }
    }
    //цикл вывода ответа
    for (int i=0; i<a.Length/2; i++) 
    {
    System.Console.Write($"({a[i*2]},{a[i*2+1]}) "); 
    }
}
