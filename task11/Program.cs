// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

bool Kratnost (int number)
{
    if (number % 7 == 0 && number % 23 == 0 )
        {
           return true;
        }
    else return false;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (Kratnost(number)) Console.WriteLine($"Число {number} кратно 7 и 23");
else Console.WriteLine($"Число {number} не кратно 7 и 23");