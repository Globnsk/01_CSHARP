// Задача 4

// int N = 27;
// int num = 0;

// while (num<=N)
// {
    //Console.WriteLine (num);
    //num=num+2;
// }

// Задача 1
//int a = 256;
//int b = a%10;
//int d = (a / 100) * 10 + a%10;
//Console.WriteLine(d);

// Задача 2

//int a = 617;
//int c = ((a%100) / 10);
//int d = a%10;
//double b = Math.Pow(c,d);
//Console.WriteLine(b);

//Задача 3
//int a = 1024;
//int b = 12;
//if (a % b == 0)
//{
  //  Console.Write("Да");
//}
//else 
//{
   // Console.Write("НЕТ," +' '+(a % b));  
//}


//Задача 4

int a = 6;
int b = a / 100;
int c = (b / 10)*10;
int d = b - c;
if (b == 0)
{
Console.Write("Третьей цифры нет");
}
else 
{
    Console.Write(d);
}