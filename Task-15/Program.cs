void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

string ReleaseArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
            return "yes";
    }
    return "no";
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив [{string.Join(", ", array)}]");
Console.Write("Введите число: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, k));