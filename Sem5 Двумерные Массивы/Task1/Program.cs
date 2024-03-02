int [,] Create2dArray(int min, int max, int rows, int cols)
{
    int [,] array = new int [rows,cols];
    for (int=0; int<rows; int++);
    {
        for (int j=0; j<cols; j++)
        {
            array[int,j] = new Random().Next(min,max+1);
        }

    }
    return array;
}

void ShowArray(int [,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        console.Write($"{array[i,j]}");
    }
    console WriteLine()";"
}

// 


int [,] Create2dArray(int min, int max, int rows, int cols){
    int [,] array = new int [rows,cols];
    for(int i=0; i<rows; i++){
        for(int j=0; j<cols; j++){
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0;i<array.GetLength(0);i++){
        for(int j =0; j<array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


//

int[,] Create2dArray(int min, int max, int rows, int cols)
{
    int [,] array = new int[rows,cols];
    for(int i= 0; i<rows;i++)
    {
        for(int j = 0; j<cols; j++)
        {
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0;i<array.GetLength(0);i++)
    {
        for(int j = 0;j<array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] MakeSquares(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (i % 2 == 0 && j % 2 == 0)
                array[i,j] *= array[i,j];
        }
    }
    return array;
}


int[,] matrix = Create2dArray(1,9,3,3);
Show2dArray(matrix);
Console.WriteLine();
int[,] matrix2 = MakeSquares(matrix);
Show2dArray(matrix2);

//Сумма элементов на главной диагонале

int Sum (int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        sum += array[i,i];
    }
    return 
//Екатерина 

    string [,] CreateNew (){
    int[,] array = new int[input, input];
    for (int i = 0; i < input; i++){
        for (int j = 0; j < input; j++){
            array[i, j] = ".";
        }
    }
    return array;
}
void FillArray (string[,] array){
    for (int i = 0; i < GetLength(0); i++){
        for (int j = 0; j < GetLength(1); j++){
            if (i == GetLength(0) / 2 || i = j || j = GetLength(1) / 2)
                array[i, j] = "*";
            
        }
    }
}

//

int Sum (int[,] array){
    int sum = 0;
    int count = 0;
    if(array.GetLength(0)<array.GetLength(1)){
        count = array.GetLength(0);
    }
    else{
        count = array.GetLength(1);
    }
    for (int i = 0; i < count; i++){
        sum += array[i,i];
    }
    return sum;
}
//Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива. 
//Пример

// 2 3 4 3   
 //4 3 4 1    =>  [3 3 5]
 //2 9 5 4

 int[] GetArray(int[,] array)
{
    int[] array2 = new int[array.GetLength(0)];
    for(int i = 0; i<array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j<array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        array2[i] = sum / array.GetLength(1);
    }
    return array2;
}


Console.WriteLine("Введите минимальное значение массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = Create2dArray(min,max,rows,cols);
Show2dArray(matrix);
int[] array = GetArray(matrix);
Console.WriteLine();

foreach(int item in array)
{
    Console.Write($"{item} ");
}