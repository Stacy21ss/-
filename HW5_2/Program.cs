// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] FillArrayWithRandomNumber (int size)
{
    int [] arr = new int [size];
    Random rnd = new Random ();
    for ( int i = 0; i < size; i++) 
    {
        arr [i] = rnd.Next(-50,50);
    }
    return arr;
 }
System.Console.WriteLine("Введите количество элементов массива");
 int len = Convert.ToInt32(Console.ReadLine());
 int[] array = FillArrayWithRandomNumber (len);
 System.Console.WriteLine(string.Join (", ", array));
int result = 0;
 int countingarray (int [] ar)
 {
    for ( int i = 0; i < ar.Length; i++)
    {
        if (i % 2 == 1) result+=ar [i];
    }
    return result;
 }
 System.Console.WriteLine($" Сумма нечетных элементов массива {countingarray(array)}");
