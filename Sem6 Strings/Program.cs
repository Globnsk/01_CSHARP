//Задайте массив символов (тип char []). Создайте строку из 
//символов этого массива. 
// char[] chars = new char[] {'a', 'b', 'c', 'd'};
// string s2 = new String (chars);
// Console.Write(s2);


//На основе символов строки (тип string) сформировать массив 
//символов (тип char[]). Вывести массив на экран.

string str = "Hello!";
Console.Write(str + " => [");
char[] array = new char[str.Length];
for(int i = 0; i<str.Length; i++)
{
array[i] = str[i];
Console.Write(array[i] + ",");
}
Console.Write("]");