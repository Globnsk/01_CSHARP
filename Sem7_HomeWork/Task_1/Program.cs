﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы

void Foo(int n, int m)
{
    if (n > m)
    {
        return;
    }
    Console.Write(n+" ");
    Foo(n+1, m);
}

Foo(2, 8);