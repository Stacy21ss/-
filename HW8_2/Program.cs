// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int [] SumRow (int [,] matrix)
{ 
int [] mat = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
       for (int j = 0; j < matrix.GetLength(1); j++) 
       {
       sum+=matrix [i,j];
       }
       mat[i] = sum;
       System.Console.WriteLine($"Сумма чисел в {i+1} строке = {mat[i]}");
    
    }
    return mat;
}
System.Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [row, column];
FillMatrixWithRandomNumber (matrix);
PrintMatrix (matrix);
int [] mat = SumRow (matrix);
int Min = mat [0];
int MinIn = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
if (mat[i] < Min) MinIn = i;
}
System.Console.WriteLine($"В {MinIn+1} строке наименьшая сумма чисел");