// Напишите программу которая принимает числа А и Б, и возводит А в натуральную степень Б с помощью рекурсии

int DigitalPow (int numberA, int numberB)
{ 
    if ( numberB < 1) 
    {
        return 1;
    }
   return numberA * DigitalPow (numberA, numberB - 1);
}
System.Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(DigitalPow(numberA, numberB));