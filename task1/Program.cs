Console.WriteLine("Ведите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
    {
        Console.WriteLine ("Первое число это квадрат второго");
    }
    else 
    {
        Console.WriteLine ("Первое число не является квадратом второго");
    }