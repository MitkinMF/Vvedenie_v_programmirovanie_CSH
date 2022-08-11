/*
Даны две квадратных таблицы чисел. Требуется построить третью,
каждый элемент которой равен сумме элементов, стоящих на том же месте
в 1-й и 2-й таблицах.

Входные данные
Во входном файле записано сначала число N, затем записана первая таблица,
а после нее - вторая. Элементы таблиц - числа от 0 до 100.
100>=N>=1.
*/
// Практиковался с генерацией файла с таблицами, чтением таблиц из этого файла и выводом решеения в новый файл. 

Random random = new Random();
int N=random.Next(1,101); //размерность таблиц  100>=N>=1

CreateFile(N); //вспомогательный метод, создает файл Tables.txt с размерностью N в первой строке и двумя таблицами через пустую строку

Solve(); //метод решения: читает файл Tables.txt, суммирует элементы таблиц и создает файл NewTable.txt c новой таблицей

//методы
void Solve() // решение задачи
{
    using (StreamReader sr = new StreamReader("Tables.txt"))  //открывает текстовый поток чтения файла "Tables.txt"
    { 
        string s = "";
        s=sr.ReadLine(); //читаем первую строку из файла: размерность N 
        int N=int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]); //получаем из файла размерность N 
    
        s=sr.ReadLine(); //читает пустую строку в Tables.txt
        
        int[,] a=ReadTable(N); // создаем 2D массив a
        
        s=sr.ReadLine(); //читает пустую строку в Tables.txt между таблицами

        int[,] b=ReadTable(N); // создаем 2D массив b

        using (StreamWriter sw = new StreamWriter("NewTable.txt")) //открывает текстовый поток для записи в файл "NewTable.txt"
        {
            for(int i=0; i<N; i++)   // цикл записи таблицы
                {
                    for(int j=0; j<N; j++) //цикл заполнения строки
                    {
                        a[i,j]+=b[i,j]; //собственно сложение одинаковых элементов массивов
                        sw.Write($"{a[i,j]}  "); // записывает число в поток
                    }
                sw.Write($"\n"); // перенос на новую строку
                }
        }
    
        //метод в методе :) 
        int[,] ReadTable(int N) //метод чтения таблицы из файла, возвращает 2D массив
            {  
                int[,] a=new int[N,N];
                string s = "";
                for (int i=0; i<N;i++) //заполнение 2D массива c помощью sr.ReadLine построчно
                {
                    s=sr.ReadLine();
                    string[] ss=s.Split(' ', StringSplitOptions.RemoveEmptyEntries); //создание массива string
                    for(int j=0;j<ss.Length;j++)
                        {
                            a[i,j] = int.Parse(ss[j]); // конвертация string в int
                        }
                }
            return a;
            }          
    }
}


void CreateFile(int N) //вспомогательный метод, создает файл Tables.txt с размерностью N в первой строке и двумя таблицами через пустую строку
{
    Random random = new Random();
    using (StreamWriter sw = new StreamWriter("Tables.txt")) //открывает текстового потока для записи в файл "Tables.txt"
    {
        sw.Write($"{N}\n");
        sw.Write($"\n"); // перенос на новую строку

        FillTable(); //запись первой таблицы в файл

        sw.Write($"\n"); // перенос на новую строку   

        FillTable(); //запись второй таблицы в файл

        //метод в методе :)   
        void FillTable() //метод заполнения таблицы 
            {
                for(int i=0; i<N; i++)   // цикл записи матрицы
                {
                    for(int j=0; j<N; j++) //цикл заполнения строки
                    {
                        sw.Write($"{random.Next(0,101)}  "); // записывает число
                    }
                sw.Write($"\n"); // перенос на новую строку
                }
            }
    }
    }
  
