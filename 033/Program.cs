//33. Задать массив из 8 элементов, заполненных нулями и 
//единицами вывести их на экран

int[] t; //объявление маcсива
Init(out t,8,max:1);   //max:1 принудительное значение для max

Print(t,"t"); 

void Init(out int[] t, int Lenght,int min=0, int max=10)  //функция создание массива 
//c заполнением его псевдослучайными числами
{
    t=new int[Lenght];
    Random random = new Random();
    for (int i=0;i<t.Length;i++)
    t[i]=random.Next (min, max+1);
}

void Print (int[] t, string variableName) //вывод элементов массива 
{
    for (int i=0;i<t.Length;i++)
    System.Console.Write($"{variableName}[{i}]={t[i]} ");
}