﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine ("Это не выходной день");
    break;
    case 2:
        Console.WriteLine ("Это не выходной день");
     break;
    case 3:
        Console.WriteLine ("Это не выходной день");
     break;
    case 4:
        Console.WriteLine ("Это не выходной день");
     break;
    case 5:
        Console.WriteLine ("Это не выходной день");
    break;
    case 6:
        Console.WriteLine ("Это выходной день");
    break;
    case 7:
        Console.WriteLine ("Это выходной день");
    break;
    default:
        Console.WriteLine ("Такого дня недели не существует");
    break;
}
