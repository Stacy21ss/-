// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
System.Console.WriteLine("Введите координату X:  первой точки");
int Ax = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y:  первой точки");
int Ay = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z:  первой точки");
int Az = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату X:  второй точки");
int Bx = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y:  второй точки");
int By = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z:  второй точки");
int Bz = Convert.ToInt32(Console.ReadLine());
double result = Math.Round(Math.Sqrt (Math.Pow(Ax-Bx, 2) + Math.Pow(Ay-By, 2)+ Math.Pow(Az-Bz, 2)), 2);
System.Console.WriteLine($" Расстояние между точками {result}");