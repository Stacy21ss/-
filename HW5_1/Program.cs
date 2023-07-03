// Pадача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] FillArrayWithRandomNumber (int size)
{
    int [] arr = new int [size];
    Random rnd = new Random ();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
return arr;
}
 System.Console.WriteLine("Введите количество элементов массива");
 int len = Convert.ToInt32(Console.ReadLine());
 int[] array = FillArrayWithRandomNumber (len);
 System.Console.WriteLine(string.Join (", ", array));
 int count = 0;
 for (int i = 0; i < array.Length; i++)
 {
    if (array[i] % 2 == 0) count++;
 }
 System.Console.WriteLine($"Количество четных элементов заданного массива равно {count}");