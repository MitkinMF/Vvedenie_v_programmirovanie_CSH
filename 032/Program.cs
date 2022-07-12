//Задать массив из 8 элементов и вывести их на экран
int[] t; //объявление маcсива
t=new int[8]; //создание массива
t[0]=10;
t[1]=12;
for (int i=0;i<t.Length;i++)
{
    t[i]=i*10;
}

for (int i=0;i<t.Length;i++)
    System.Console.Write($"a[{i}]={t[i]} ");
