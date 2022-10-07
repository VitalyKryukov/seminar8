// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
//      1  2  3  4   5
// 2 -> 1,4
Console.Clear();

Console.WriteLine("Введите число: ");
double number = double.Parse(Console.ReadLine());

double count = 1;
// double pow = 1;

while (count <= number)
{
    double pow = Math.Pow(count,2);// если переменную инициализировали, повторно ее не нужно инициализировать!!!
    Console.Write($" {pow}, ");
    count++;
}
