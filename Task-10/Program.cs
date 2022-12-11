Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
    n /= 10;
    count++;
}
Console.WriteLine(count);
