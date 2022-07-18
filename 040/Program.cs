// 40. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
//Создайте массив, который является произведением пар чисел в одномерном массиве a.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int N=12;
int[] a=new int[N];
Random random=new Random(100); // конструктор объекта random
for (int i=0; i<a.Length;i++)
{
    a[i]=random.Next(1,11);
}

//решение 

int[] b=new int[a.Length/2];
for (int i=0; i<a.Length/2;i++) //В c# не обязательно ставить фигурные скобки
    b[i]=a[i]*a[a.Length-i-1];

for (int i=0; i<b.Length;i++)
    System.Console.WriteLine($"{b[i],4}");