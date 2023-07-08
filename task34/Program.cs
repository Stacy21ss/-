// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1^2 4 49 2
// 5 81 2 9
// 64 4 4 4

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
void PrintNewMatrix ( int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++) 
       {
        if (i % 2 == 0 && j % 2 ==0)  matrix [i,j] = Convert.ToInt32(Math.Pow (matrix[i,j], 2));
       System.Console.Write($"{matrix [i,j]} ");
       }
       System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [row, column];
FillMatrixWithRandomNumber (matrix);
PrintMatrix (matrix);
System.Console.WriteLine();
PrintNewMatrix (matrix);