// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
System.Console.WriteLine("Введите позицию в массиве, номер строки - ");
int r = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите позицию в массиве, номер столбца - ");
int col = Convert.ToInt32(Console.ReadLine());
if (r == 0 & col == 0) System.Console.WriteLine($"Такой позиции  нет");
else if (r <= row  && col <= column ) System.Console.WriteLine($"На этой позиции число {matrix [r-1,col-1]}");
else System.Console.WriteLine($"На такой позиции числа нет");

