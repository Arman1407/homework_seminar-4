// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);

// n = Math.Abs(n); // Модуль числа
for (int m = n * n; m <= n; m++)
Console.Write($"{m} ");


// for (int i = (-1) * n; i <= n; i++)