// Задача 1. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"
// Позиции в массиве считать от единицы.


// int[,] numbers = new int[,] 
// {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;

// if (x > numbers.GetLength(0))
// {
//     Console.WriteLine("Позиция по рядам выходит за пределы массива");
// }
// if (y > numbers.GetLength(1))
// {
//     Console.WriteLine("Позиция по колонкам выходит за пределы массива");
// }
// if(x < numbers.GetLength(0) && y < numbers.GetLength(1))
// {
// Console.Write(numbers[(x-1),(y-1)]);
// }




// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Поиск элемента по позициям


// // Проверка позиций на вхождение в массив

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         if (x > numbers.GetLength(0))
//             {
//                 Console.WriteLine("Позиция по рядам выходит за пределы массива");
//             }
//             if (y > numbers.GetLength(1))
//             {
//                 Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//             }
//             if(x < numbers.GetLength(0) && y < numbers.GetLength(1))
//         {
// Console.Write(numbers[(x-1),(y-1)]);
//         }
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer



// Задача 2.
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// 1. Задали массив

// int[,] array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
// // 2. Обмен элементами певой и последней строки

// for (int j = 0; j < (array.GetLength(1)); j++)
// {
//     int index = array[array.GetLength(0)-1, j];
//     array[array.GetLength(0)-1, j] = array[0, j];
//     array[0, j] = index;
// }
// // 3. Печать массива

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j]+"\t");

//     }
// }


// Задача 3
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] numbers = new int[,]
            {
                {1, 2, 3},
                {1, 1, 10},
                {7, 8, 2},
                {0, 0, 1}
            };
int[] SumRows = new int[numbers.GetLength(0)];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    SumRows[i] = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        SumRows[i] = SumRows[i] + numbers[i, j];
    }
}
int min=SumRows[0];
int indexmin = 0;
for (int i = 0; i < SumRows.Length; i++)
{  
    if (SumRows[i] < min)
    {
        min = SumRows[i];
        indexmin = i;
    }
}
Console.Write(indexmin);


// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     /// Вычисление сумм по строкам (на выходе массив с суммами строк)
//     public static int[] SumRows(int[,] array)
//     {int[] SumRows = new int[array.GetLength(0)];
//       for (int i = 0; i < array.GetLength(0); i++)
// {
//      SumRows[i] = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         SumRows[i] = SumRows[i] + array[i, j];
//     }
       
// }
//     return SumRows; 
//     }
    
//     // Получение индекса минимального элемента в одномерном массиве
//     public static int MinIndex(int[] array)
//     {
     
// int min=array[0];
// int indexmin = 0;
// for (int i = 0; i < array.Length; i++)
// {  
//     if (array[i] < min)
//     {
//         min = array[i];
//         indexmin = i;
//     }
// }
//       return indexmin;
//     }
//     public static void PrintResult(int[,] numbers)
//     {   
//        int[] SumRows = new int[numbers.GetLength(0)];

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     SumRows[i] = 0;
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         SumRows[i] = SumRows[i] + numbers[i, j];
//     }
// }
// int min=SumRows[0];
// int indexmin = 0;
// for (int i = 0; i < SumRows.Length; i++)
// {  
//     if (SumRows[i] < min)
//     {
//         min = SumRows[i];
//         indexmin = i;
//     }
// }
// Console.Write(indexmin);
//     }
// }