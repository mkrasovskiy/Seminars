Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированное число {number}");
int n1 = number / 100;
int n3 = number % 10;
Console.WriteLine(n1 * 10 + n3 * 1);
