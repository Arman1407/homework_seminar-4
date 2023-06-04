﻿// Суперсдвиг
// (Время: 1 сек. Память: 16 Мб Сложность: 20%)
// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

// Выходные данные
// В выходной файл OUTPUT.TXT выведите полученную последовательность.

// Примеры
// №	                INPUT.TXT	                      OUTPUT.TXT
// 1	                  5
//                       5 3 7 4 6
//                       3	                               7 4 6 5 3

// 2	                  5
//                       5 3 7 4 6
//                      -3	                               4 6 5 3 7





Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine()!);
int[] a = new int[n];
int[] b = new int[n];

for (int i = 0; i < n; i++)
    a[i] = new Random().Next(1, 21); // [1; 20]

Console.WriteLine($"Начальный массив: [{string.Join(", ", a)}]");
Console.Write("Введите кол-во сдвига: ");
int k = int.Parse(Console.ReadLine()!);
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        b[i] = a[n - k + i];
    for (int i = 0; i < n - k; i++)
        b[k + i] = a[i];
    Console.WriteLine($"Конечный массив: [{string.Join(", ", b)}]");
}
else
{
    k = -k;
    for (int i = 0; i < k; i++)
        b[n - k + i] = a[i];
    for (int i = 0; i < n - k; i++)
        b[i] = a[k + i];
    Console.WriteLine($"Конечный массив: [{string.Join(", ", b)}]");
}

