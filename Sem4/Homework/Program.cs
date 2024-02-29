// Составление чила из элементов массива
// 1. вводим с консоли размер массива
//int InputArrSize()
//{
Console.WriteLine("Введите размер массива (целое число от 1 до 9)");
string input = Console.ReadLine();
int n = Convert.ToInt32(input);
//}

int[] arr = new int[n];
// Заполняем массив случайными числами

Random rnd = new Random();
int i = 0;
while (i < n )
{
    arr[i] = rnd.Next(1, 10);
    Console.Write(arr[i] + ", ");
    i = i + 1;
}
// 
int num = 0;
int exp = 1;
for (i = n; i > 0; i--)
{
    num = num + arr[i - 1] % 10 * exp;
    exp = exp * 10;
}
Console.Write(" => " + num);
