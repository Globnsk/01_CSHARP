void PrintSquare(int limit)
{
    int i = 1;
    while(i <= limit){
        Console.Write($"{i*i} ");
       i++;
    }

}
PrintSquare(15);