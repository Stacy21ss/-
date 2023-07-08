// Задача 51: Задайте двумерный массив. Найдите сумму элементов на главной диагонали
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void FillMatrixWithRandomNumber ( int [,] matrix)
{
    Random rnd = new Random ();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++) 
       {
       matrix [i,j] = rnd.Next(0,10);
       }
    }
}
void PrintMatrix ( int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++) 
       {
       System.Console.Write($"{matrix [i,j]} ");
       }
       System.Console.WriteLine();
    }
}
int Sum ( int [,] matrix)
{
    int res = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++) 
       {
        if (i ==  j)  res += matrix [i,j];
       }
       System.Console.WriteLine();
    }
    return res;
}

System.Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [row, column];
FillMatrixWithRandomNumber (matrix);
PrintMatrix (matrix);
System.Console.WriteLine($"Сумма элементов главной диагонали = {Sum (matrix)}");
