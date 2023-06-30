// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
int prod (int number)
{
    int result = 1;
    for (int i = 2; i<= number; i++)
    {
        result*=i;
    }
    return result;
}
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведение чисел от 1 до {number}  равна {prod (number)}");