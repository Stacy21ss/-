// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double [] FillArrayWithRandomNumber (int size)
{
    double [] arr = new double [size];
    Random rnd = new Random ();
    for ( int i = 0; i < size; i++) 
    {
        arr [i] = Math.Round(rnd.Next(0,100) + rnd.NextDouble(), 2);
    }
    return arr;
}
System.Console.WriteLine("Введите количество элементов массива");
 int len = Convert.ToInt32(Console.ReadLine());
 double [] array = FillArrayWithRandomNumber (len);
 System.Console.WriteLine(string.Join (", ", array));
double maxNum = 0;
 double  MaxNumber (double [] arr1)
 {
    for (int i = 0; i < arr1.Length; i++)
    {
        if ( arr1 [i] > maxNum) maxNum = arr1 [i];  
    }
    return maxNum;
 }
 double minNum = array [0];
 double  MinNumber ( double [] arr2)
 {
    for ( int i = 1; i < arr2.Length ; i++)
    {
        if ( arr2 [i] < minNum) minNum = arr2 [i];  
    }
    return minNum;
 }
 System.Console.WriteLine($" Разница между минимальным и максимальным значением массива равно {MaxNumber(array) - MinNumber(array)}");

