// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int count (int number)
{
   int i = number.ToString().Length;
    return i;
}
Console.WriteLine("Введите число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"В числе : {number}  - {count(number)} цифры(-а)");