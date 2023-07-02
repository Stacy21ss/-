// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
 bool Checknumber ( int [] array, int number)
 {
    for ( int i = 0; i < array.Length; i++)
    {
        if ( array [i] == number)  return true;
    }
     return false;
 }
 System.Console.WriteLine("Введите количество элементов массива");
 int len = Convert.ToInt32(Console.ReadLine());
 int[] array = FillArrayWithRandomNumber (len);
 System.Console.WriteLine(string.Join (", ", array));
System.Console.WriteLine("Введите число");
 int number = Convert.ToInt32(Console.ReadLine());
if (Checknumber(array, number)) System.Console.WriteLine($"В данном массиве присутсвует число {number}");
    else System.Console.WriteLine($"В данном массиве искомого числа нет");
