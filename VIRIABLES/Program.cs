//значимые типы (у которых есть struct)
int a;

//ссылочные (у которых есть class)
string s; // в s хранится адрес ячейки
s="Hello"; 
string s1;
s1=s;
int[] arr; // массив изначально NULL
arr=new int[5]; 
int[] arr1;
arr1=arr;
arr[0]=2; // в этом случае и в arr и arr1 первый элемент поменяется