//string str = Console.ReadLine();
//Console.WriteLine(str.Length);

// Сосчитаем количество цифр в строке
int DigitsCounter(string str)
{
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsAsciiDigit(str[i]) == true)
        {
            j += 1;
        }
    }
    return j;
}
//Сформируем массив из цифр
int[] CreateArray(int digitsnumber, string str)
{
    int[] digitsfromstring = new int[digitsnumber];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsAsciiDigit(str[i]) == true)
        {
            digitsfromstring[j] = str[i] - '0'; // Внимание!!!! Переводим char в int

            j += 1;

        }
    }
    return digitsfromstring;
}


// Печать массива цифр из строки
void PrintResult(string str, int[] arr)
{
    Console.Write(str + " => ");
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + ", ");
}
//Считаем с консоли строку
string str = Console.ReadLine();
// Определим количество цифр в строке
int i = DigitsCounter(str);
// Создадим массив из цифр
int[] array = CreateArray(i, str);
// выведем на экран получившийся массив
PrintResult(str, array);
