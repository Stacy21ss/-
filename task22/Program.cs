//  Задача 31: Задайте массив из N элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
 // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
 
 int[] FillArrayWithRandomNumber (int size)
 {
    int[] arr = new int[size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9,10); 
    }
return arr;
 }
 System.Console.WriteLine("Введите количество элементов массива");
 int len = Convert.ToInt32(Console.ReadLine());
 int[] array = FillArrayWithRandomNumber (len);
 System.Console.WriteLine(string.Join (", ", array));
 int SumP = 0;
 int SumN = 0;
 for (int i = 0; i < array.Length; i++)
 {
 if (array[i] > 0) SumP+= array[i];
 else SumN += array[i];
 }
 System.Console.WriteLine($" Сумма положительных чисел массива = {SumP}, Сумма отрицательных чисел массива = {SumN}");