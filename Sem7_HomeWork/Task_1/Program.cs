﻿// Задайте значения m и n. Напишите программу, которая выведет все натуральные 
// числа в промежутке от m до n. Использовать рекурсию, не использовать циклы.

void Foo(int m, int n)
{
    if (m > n)
    {
        return;
    }
    Console.Write(m+" ");
    Foo(m+1, n);
}

Foo(2, 8);
