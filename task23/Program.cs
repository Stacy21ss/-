// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
 int [] newarray = array;
 for (int i = 0; i < array.Length; i++)
 {
    newarray [i] *= (- 1);
 }
 System.Console.WriteLine(string.Join (", ", newarray));