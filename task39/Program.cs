// Ввести число N, вывести все натуральные числа от 1 до N

void RoadToNumber (int number)
{
    if ( number == 0) 
    {
        return 0;
    }
    RoadToNumber(number - 1);
    Console.WriteLine($"{number}");
}
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
RoadToNumber(number);