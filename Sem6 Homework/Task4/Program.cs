//Задача 4 : Обратный порядок слов в строке

// Входная строка со словами, разделенными пробелами
string input = Console.ReadLine();
// Вызов метода для обращения порядка слов в строке
string result = ReverseWords(input);
// Вывод результата
Console.WriteLine(result);

// Метод для обращения порядка слов в строке
string ReverseWords(string str)
{
    // Разделение строки на слова
    string[] words = str.Split(' ');
    // Обращение порядка слов
    Array.Reverse(words);
    // Соединение слов обратно в строку с пробелами
    return string.Join(" ", words);
}

