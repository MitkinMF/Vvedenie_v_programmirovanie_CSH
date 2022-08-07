//создать массив NxM и заполнить, вывести массив

int N=3;
int M=2;

int[,] a=new int[N,M];
//Инициализация случайными числами
Random random=new Random(); // создали объект типом Random

for(int i=0;i<a.GetLength(0); i++) // получить измерение по первому измерению
  {
     for(int j=0; j<a.GetLength(1); j++) // получить измерение по второму измерению
    { 
    a[i,j]= random.Next(1,11); 
    }
  }

  
for(int i=0;i<a.GetLength(0); i++) 
  {
     for(int j=0; j<a.GetLength(1); j++)
        { 
        System.Console.Write($"{a[i,j]} ");
        }
 System.Console.WriteLine();
  }