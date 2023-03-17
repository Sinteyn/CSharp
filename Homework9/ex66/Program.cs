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

int Summ(int m, int n)
{
    if (m < 0) return Summ(m + 1, n);
    if (n < 0) return Summ(m, n + 1);
    if (m == 0) return (n * (n + 1)) / 2;
    else if (n == 0) return (m * (m + 1)) / 2;
    else if (m == n) return m;
    else if (m < n) return n + Summ(m, n - 1);
    else return n + Summ(m, n + 1);
}

int m = EnterValuesInt("Введите значение M");
int n = EnterValuesInt("Введите значение N");

Console.WriteLine($"M = {m}; N = {n} --> {Summ(m, n)}");