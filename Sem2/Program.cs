//ЗАДАЧА 1

//int num = 322;


//if (num % 7 ==0 && num % 23 == 0)
//{
//Console.Write("ДА");
//} 
//else
//Console.Write("НЕТ");

// ЗАДАЧА 2

//int x=10;
//int y=-15;
//if (x>0){
//if (y>0){
//  Console.Write("1");
//}
//else 
//Console.Write("4");
//}
//else
//if (y>0){
//Console.Write("2");
//}
//else
//Console.Write("3");

// 
//ЗАДАЧА 3
//int num = 97;
//int first = num / 10;
//int second = num % 10;
//if (first > second)
//{
//Console.Write(first);
//}
//else
//Console.Write(second);


//   ЗАДАЧА 4

int num = 45234256;
if (num / 10 > 0)
{

int last = num / 10;
int i = 1;
while (last > 0)
{
   last = last / 10;
   i = i + 1;
}

int ii = 1;
int exp = 10;
for (ii = 1; ii <= i - 2; ii++)
{
   exp = exp * 10;
}
int first = num / exp;
Console.Write(first + ",");


for (ii = i - 2; ii >= 1; ii--)
{
   exp = exp / 10;
   int next = num / (exp);
   next = next % 10;
   Console.Write(next + ",");
}
Console.Write(num%10);
}
else
Console.Write(num);

