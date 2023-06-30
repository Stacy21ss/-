// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int sum (int number)
{
    int summ = 0;
    while  (number > 0)
    {
        int i = number % 10;
        summ+=i;
        number = number / 10;
        
    }
    return summ;
}
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе =  {sum(number)}");
