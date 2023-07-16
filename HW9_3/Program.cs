// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction (int numberM, int numberN)
{ 
    if (numberM == 0) return numberN+1;
    else if (numberM > 0 && numberN == 0) return AkkermanFunction(numberM-1, 1);
    else  return AkkermanFunction(numberM-1, AkkermanFunction(numberM, numberN -1 )); 
}
System.Console.WriteLine("Введите число m");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число n");
int numberN = Convert.ToInt32(Console.ReadLine());
int res = AkkermanFunction(numberM, numberN);
System.Console.WriteLine(res);