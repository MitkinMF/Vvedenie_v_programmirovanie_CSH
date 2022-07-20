//44. Написать программу преобразования десятичного числа в двоичное

int n=3; 

System.Console.WriteLine(DecToBin (n));



string DecToBin(int n) //Функция преобразование в двоичное число
{
    if (n==0) return"0";
    string s="";
    while (n!=0)
    {
        s=(n%2)+s; // строка
        n/=2; //n
    }
return s;
}
