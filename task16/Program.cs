// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
Console.Clear();

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if(num1 == Math.Pow(num2,2) || num2 == Math.Pow(num1,2))// <||> - или; <|> - не всегда корректно работает, может проверить 1-но условие
{
    Console.WriteLine("квадратом является");
}
else
{
    Console.WriteLine("квадратом не является");
}
