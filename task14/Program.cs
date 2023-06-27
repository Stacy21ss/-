//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
 // A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
System.Console.WriteLine("Введите координату X:  первой точки");
int Ax = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y:  первой точки");
int Ay = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату X:  второй точки");
int Bx = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y:  второй точки");
int By = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt (Math.Pow(Ax-Bx, 2) + Math.Pow(Ay-By, 2));
System.Console.WriteLine($" Расстояние между точками {result}");