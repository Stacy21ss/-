// Ввести числа M и N, Вывести все натуральные числа от M до N

void RoadToNumber (int number1, int number2)
{
    if  (number2 == number1 - 1 )
    {
        return;
    }
    RoadToNumber(number1, number2 - 1);
    System.Console.WriteLine();
    Console.Write($"{number2}");
}
System.Console.WriteLine("Введите число M");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int number2= Convert.ToInt32(Console.ReadLine());
RoadToNumber(number1, number2);