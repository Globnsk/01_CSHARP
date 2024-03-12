//Задача 3: Проверка строки на палиндром

// Входная строка для проверки
Console.WriteLine("Введите сроку символов");
string input = Console.ReadLine();
// Вызов метода для проверки, является ли строка палиндромом
bool isPalindrome = IsPalindrome(input);
// Вывод результата
Console.WriteLine(isPalindrome ? "Да" : "Нет");

// Метод для проверки, является ли строка палиндромом
bool IsPalindrome(string str)
{
    // Нормализация строки путем удаления не буквенно-цифровых
    //символов и приведения к нижнему регистру
    string normalized = new
    string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    // Сравнение строки с ее перевернутым вариантом
    return normalized.SequenceEqual(normalized.Reverse());
}

