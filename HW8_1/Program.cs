// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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



System.Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [row, column];
FillMatrixWithRandomNumber (matrix);
PrintMatrix (matrix);
int [,] ChangeMatrix (int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    { 
    int temp = 0;
       for (int j = 0; j < matrix.GetLength(1); j++) 
       {
        for (int k = j+ 1; k < matrix.GetLength(1); k++ )
        if (matrix [i,k] > matrix [i,j]) 
        {
            temp = matrix [i,j];
            matrix [i,j] = matrix[i,k];
            matrix [i,k] = temp;
        }
       }
       System.Console.WriteLine();
       }
       return matrix;
}
ChangeMatrix(matrix);  
PrintMatrix (matrix);


