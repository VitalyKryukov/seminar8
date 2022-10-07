// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 = 
// A (7,-5); B (1,-1) -> 7,21
Console.Clear();

Console.WriteLine("Введите координаты x1: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты x2: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double Distance = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)),2);
Console.WriteLine($"Расстояние от точки A до точки B равно {Distance}");