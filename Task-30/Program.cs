Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(n));

string PrintNumbers(int end)
{
    if (end == 1)
    {
        Console.WriteLine(1);
        return "1";
    }
string s = PrintNumbers(end - 1) + ' ' + end.ToString();
Console.WriteLine(s);
return (s);
}