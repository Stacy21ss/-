// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (num % 2 == 0)
    while (count <= num)
    {
       Console.WriteLine($"{count+1}"); 
       count+=2;
    }
else
{
    while (count < num )
    {
        count+=2;
       Console.WriteLine($"{count-1}"); 
    }
}
  
    
