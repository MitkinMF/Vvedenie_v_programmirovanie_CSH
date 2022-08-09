//43. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

//Решение
int N=0;
System.Console.WriteLine("Введите целое число больше 1");
do //цикл повторяется при выполнении условвия while 
{
   N=InputInt();
   if (N<1) System.Console.WriteLine("Введите целое число больше 1");
}
while(N<1);

System.Console.WriteLine($"Введено {CountPositiveNumbers(FillArray(N))} чисел больше 0 "); 

//Методы
int CountPositiveNumbers(int[] a) //функция подсчета чисел больше 0
{
int quantPosNumb=0;
for (int i=0; i<a.Length; i++)
   {
      if (a[i]>0) quantPosNumb++;
   }
return quantPosNumb;
}

//Метод возвращает целое число введенное с клавиатуры, с проверкой
int InputInt() 
{
string s;
int N;
bool f;
do //цикл повторяется при выполнении условвия while
    {
        s=System.Console.ReadLine();
        f=int.TryParse(s,out N); // возвращает в f истину или ложь, в n отправляет результат конвертации 
        if (f==false) System.Console.WriteLine("Wrong input. Введите целое число");
    }
while(f==false);
return N;
}

int[] FillArray(int N) //Метод заполняет целыми числами, веденными с клавиатуры, массив величиной N
{
int[] a=new int [N];
int count=N;
System.Console.WriteLine("Введите целое число");
for (int i=0; i<a.Length; i++)
   { 
      a[i]=InputInt();
      if (count>1) System.Console.WriteLine($"Осталось ввести {count-1} чисел ");
      count--;
   }
   return a;
}  


//Метод который не требует введения количетва N, числа вводятся через пробел
/*  
int[] Input() //Метод возвращает массив чисел введенных с клавиатуры
{
   string? s=Console.ReadLine();
   string[] ss=s.Split(' ', StringSplitOptions.RemoveEmptyEntries); // создает массив из строки в которой разделителем для чисел служит пробел ' '
   int[] a=new int[ss.Length]; 
   for (int i=0; i<a.Length; i++)
   { 
      a[i]=int.Parse(ss[i]);  //перевод string в int
   }
   return a;
}
*/