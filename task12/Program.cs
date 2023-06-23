// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
void comparison(int num1, int num2)
{
if (num1 * num1 == num2 || num2 * num2 == num1) 
    {
    System.Console.WriteLine ("Одно число является квадратом другого");  
    }
else
    {
     System.Console.WriteLine ("Первое число не является квадратом другого и наоборот");  
    } 
}


Console.WriteLine ("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
comparison (num1, num2);
