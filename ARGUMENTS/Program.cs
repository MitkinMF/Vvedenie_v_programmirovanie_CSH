 /*// подпрограмма смены значений переменных 
void Swap(ref int a, ref int b)  // модификатор ref  дает ссылку на переменные
{
    int t;
    a=b;
    b=t;
}

void Calc(int a, int b, out int sum, out int sub)  // модификатор out тоже самое что и ref, только им нужно задать значение
{
    sum=a+b;
    sub=a-b;
}

int n=Convert.ToInt32(Console.ReadLine());
int.Parse(Console.ReadLine()); //тоже что и  Convert.ToInt32
*/
// защита от дурака
string s;
int n;
bool f;
do
{
s=System.Console.ReadLine();
f=int.TryParse(s,out n); // возвращает в f истину или ложь, в n отправляет результат конвертации 
if (f==false) System.Console.WriteLine("Wrong input");
}
while(f==false);
System.Console.WriteLine(n);

/*

int a,b,sum,sub;
a=1;
b=2;
Calc(a,b,ref sum, sub)



int a,b;
a=1;
b=2;
System.Console.WriteLine($"{a} {b}");
Swap(ref a, ref b); 
System.Console.WriteLine($"{a} {b}");
 */