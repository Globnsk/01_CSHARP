
int[] arr = { 99, 14, 27, 18, 11, 64, 88, 51, 6, 97 };
int max = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//if (arr[i] > max)
//{
// max = arr[i];
//}
//}
foreach (int element in arr)
{
    if (element > max)
    {
        max = element;
    }
}
Console.Write(max);