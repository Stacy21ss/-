// Перевернуть масиив

int[] FillArrayWithRandomNumber (int size)
 {
    int [] arr = new int [size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,10); 
    }
return arr;
 }
 int temp =0;
 int [] ReverseArray (int [] arr)
 {
for (int i = 0; i < arr.Length / 2; i++)
    {
    temp = arr [i];
    arr [i] = arr [arr.Length - 1 - i];
    arr [arr.Length - 1 - i] = temp;
    }
    return arr;
 }
 System.Console.WriteLine("Введите количество элементов массива");
 int len = Convert.ToInt32(Console.ReadLine());
 int[] array = FillArrayWithRandomNumber (len);
 System.Console.WriteLine(string.Join (", ", array));
  System.Console.WriteLine(string.Join (", ", ReverseArray (array)));
 