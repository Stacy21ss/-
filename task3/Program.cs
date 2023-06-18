Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count=0;
while (count<= 2 * num)
{
    Console.Write($"{-num+count}, ");
    count++;
}
