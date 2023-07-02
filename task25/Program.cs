// Задача 35: Задайте одномерный массив из N случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

 int[] FillArrayWithRandomNumber (int size)
 {
    int[] arr = new int[size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-99,100); 
    }
return arr;
 }
 System.Console.WriteLine("Введите количество элементов массива");
 int len = Convert.ToInt32(Console.ReadLine());
 int[] array = FillArrayWithRandomNumber (len);
 System.Console.WriteLine(string.Join (", ", array));
int count = 0;
for ( int i = 0; i < array.Length; i++)
{
     if ( array [i] >= 10 && array [i] <= 99 ) count++;
}
System.Console.WriteLine($"Количество элементов массива в диапазоне [10,99] равно {count}");
