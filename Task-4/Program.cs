﻿Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n * n == m)
    Console.WriteLine("yes");
else if (m * m == n)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
