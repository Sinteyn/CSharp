void PrintAllNaturalNums(int N)
{
    if (N == 1)
    {
        Console.Write(1);
        return;
    }
    if (N > 0)
    {
        Console.Write(N + ", ");
        PrintAllNaturalNums(N - 1);
    }
    else
    {
        Console.Write($"Нет натуральных чисел от {N} до 1");
        return;
    }
}

int EnterValuesInt(string massage)
{
    Console.WriteLine(massage);
    string val = Console.ReadLine()!;

    while (!int.TryParse(val, out int i))
    {
        Console.WriteLine("Неккоректный ввод. " + massage);
        val = Console.ReadLine()!;
    }
    int value = int.Parse(val);
    return value;
}

int N = EnterValuesInt("Введите значение N");

Console.Write($"N = {N} --> \"");
PrintAllNaturalNums(N);
Console.WriteLine("\"");