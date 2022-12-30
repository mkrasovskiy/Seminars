Console.Clear();
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(m, n));

string PrintNumbers(int start, int end)
{
    if (start == end)
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}