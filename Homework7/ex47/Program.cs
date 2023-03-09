void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 8}", matrix[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

void FillDoubleArray(double[,] matrix, double[] minMax)
{
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(minMax[0] + rand.NextDouble() * (minMax[1] - minMax[0]), 1);
        }
    }
}

double[,] CreateArray() => new double[EnterValuesInt("Введите кол-во строк матрицы"),
                                         EnterValuesInt("Введите кол-во столбцов матрицы")];

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

double EnterValuesDouble(string massage)
{
    Console.WriteLine(massage);
    string val = Console.ReadLine()!;

    while (!double.TryParse(val, out double i))
    {
        Console.WriteLine("Неккоректный ввод. " + massage);
        val = Console.ReadLine()!;
    }
    double value = double.Parse(val);
    return value;
}

double[] EnterMinMax()
{
    double[] minMax = new double[2];
    double min = EnterValuesDouble("Введите минимальное значение для матрицы");
    double max = EnterValuesDouble("Введите максимальное значение для матрицы");

    while (max < min)
    {
        Console.WriteLine($"Неккоректный ввод {min} > {max}");
        min = EnterValuesDouble("Введите минимальное значение для матрицы");
        max = EnterValuesDouble("Введите максимальное значение для матрицы");
    }

    minMax[0] = min;
    minMax[1] = max;

    return minMax;
}

double[,] matr = CreateArray();
FillDoubleArray(matr, EnterMinMax());
PrintArray(matr);