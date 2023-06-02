// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), result = 1;
// for (int i = 2; i <= n; i++)
// result *= i;
// Console.WriteLine($"{n}! = {result}");


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!), res = 1;
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);

for (int i = 1; i == n; i++)
res *= n;


Console.Write($"{res}");


