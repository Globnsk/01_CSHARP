char[,] chars = new char[2,4] {
    {'a', 'b', 'c', 'd'},
    {'R', 'E', 'j', 'O'}
    };
 string s2 = String.Empty;
 //string result = string.Empty;

for (int i = 0; i < chars.GetLength(0); i++)
{
    for (int j = 0; j < chars.GetLength(1); j++)
    {
        s2 += chars[i, j];
    }
}

Console.WriteLine(s2);
 //for (int i = 0; i < chars.GetLength(0); i++)
 //s2 = 
//Console.Write(s2);
