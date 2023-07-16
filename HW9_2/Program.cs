// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumDigital (int numberM, int numberN)
{ 
    if ( numberM > numberN) 
    {
        return 0;
    }
    return numberM + SumDigital(numberM +1, numberN);
}
System.Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigital(numberM, numberN));