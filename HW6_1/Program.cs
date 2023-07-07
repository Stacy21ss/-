// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел в массиве");
int len = Convert.ToInt32(Console.ReadLine());
int [] array = new int [len];
int count = 0;
for (int i = 0; i < len; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array [i] = Convert.ToInt32(Console.ReadLine());
    if (array [i] > 0) count ++;
}
Console.WriteLine(string.Join (", ", array));
Console.WriteLine($"Вы ввели {count} число (-а, -ел) больше 0 ");
