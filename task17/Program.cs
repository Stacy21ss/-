// Сортировать массив методом min/max
int [] arr = {1,3,4,6,1,2,9,6};
void PrintArray (int [] array)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray (arr);
void SelectionSort (int [] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int MinPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j ] < array[MinPosition]) MinPosition = j;
        }
        int temporary = array[i];
        array[i] = array[MinPosition];
        array[MinPosition] = temporary;
    }
}
Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);