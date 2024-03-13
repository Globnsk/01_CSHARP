﻿// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void ArrayReverse(int[] array, int size)
{
    if (size < 1)
    {
        return;
    }
    
    Console.Write(array[size - 1]+" ");
    ArrayReverse(array, size - 1);
}

int[] array = [15, 6, 99, 17, 137, 0];
ArrayReverse(array, array.Length);
