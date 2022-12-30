Console.Clear();
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine($"{m}->{SumNumbers(m)}");

int SumNumbers(int number)
{
    if (number == 0)
        return 0;
    return (number % 10 + SumNumbers(number / 10));
}
