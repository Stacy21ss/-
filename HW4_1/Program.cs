// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void st (int A, int B)
{
    int result = Convert.ToInt32(Math.Pow(A,B));
    Console.WriteLine($"Число {A} в степени {B} будет равно = {result}");
}
System.Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
st (A, B);
