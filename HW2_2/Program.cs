// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("Третьей цифры нет");
else if (number >= 100 & number < 1000) Console.WriteLine($"Третья цифра {number % 10}");
else 
{
    string num = number.ToString();
    Console.WriteLine($"Третья цифра {num[2]}");
}
