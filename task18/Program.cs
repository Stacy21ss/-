// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
// System.Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// for (int i = 1; i<= number; i++)
// {
//     result = result + i;
// }
// System.Console.WriteLine($"Сумма чисел от 1 до {number}  равна {result}");
int Sum (int number)
{
    int result = 0;
    for (int i = 1; i<= number; i++)
    {
        result+=i;
    }
    return result;
}
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма чисел от 1 до {number}  равна {Sum (number)}");