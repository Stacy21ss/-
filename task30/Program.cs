// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void PrintFib (int n)
{
    System.Console.Write("0 1");
    int neig1 = 0;
    int neig2 = 1;
    int res = 0;
    for (int i = 0; i < n - 2; i++)
    {
        res = neig1 + neig2;
        System.Console.Write($" {res} ");
        neig1 = neig2;
        neig2= res;
    }
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2) System.Console.WriteLine("Неккоректный ввод");
else PrintFib (number);