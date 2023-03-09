int[,] CreateArrayint()
{
    int row = EnterValuesInt("Введите кол-во строк матрицы");
    while (row <= 0)
    {
        row = EnterValuesInt("Неккоректный ввод. Введите кол-во строк матрицы");
    }
    int column = EnterValuesInt("Введите кол-во столбцов матрицы");
    while (column <= 0)
    {
        column = EnterValuesInt("Неккоректный ввод. Введите кол-во столбцов матрицы");
    }
    return new int[row, column];
}

void FillArrayInt(int[,] matrix, int[] minMax)
{
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minMax[0], minMax[1] + 1);
        }
    }
}

void PrintArrayInt(int[,] matrix)
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

int[] EnterMinMaxInt()
{
    int[] minMax = new int[2];
    int min = EnterValuesInt("Введите минимальное значение для матрицы");
    int max = EnterValuesInt("Введите максимальное значение для матрицы");

    while (max < min)
    {
        Console.WriteLine($"Неккоректный ввод {min} > {max}");
        min = EnterValuesInt("Введите минимальное значение для матрицы");
        max = EnterValuesInt("Введите максимальное значение для матрицы");
    }

    minMax[0] = min;
    minMax[1] = max;

    return minMax;
}

double[] ArithmeticMeanColumn(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] result = new double[size];
    double sum = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        result[i] = (sum / matrix.GetLength(0));
        sum = 0;
    }
    return result;
}

void PrintResult(double[] res, string massage)
{
    int size = res.Length;
    Console.Write(massage);

    for (int i = 0; i < size - 1; i++)
    {
        Console.Write($"{res[i]}; ");
    }
    Console.WriteLine($"{res[size - 1]}.");
}

int[,] matr = CreateArrayint();
FillArrayInt(matr, EnterMinMaxInt());
PrintArrayInt(matr);
PrintResult(ArithmeticMeanColumn(matr), "Среднее арифметическое каждого столбца: ");