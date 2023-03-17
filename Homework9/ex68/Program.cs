int Akker(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m != 0) && (n == 0)) return Akker(m - 1, 1);
    return Akker(m - 1, Akker(m, n - 1));
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

int m = EnterValuesInt("Введите значение M");
int n = EnterValuesInt("Введите значение N");

if (m < 0 || n < 0)
    Console.WriteLine("Невозможно вычислить функцию Аккермана для отрицательных чисел");
else
    Console.WriteLine($"m = {m}, n = {n} --> A(m, n) = {Akker(m, n)}");