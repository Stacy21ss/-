// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначое число");
int num = Convert.ToInt32(Console.ReadLine());
int digit1 = num % 100;
int digit2 = digit1 % 10;
int result = (digit1 - digit2) / 10;
Console.WriteLine(result);