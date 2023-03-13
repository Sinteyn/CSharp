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

int MinSummRow(int[,] matrix)
{
    int summ = 0;
    int[] sums = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];
        }
        sums[i] = summ;
        summ = 0;
    }

    summ = sums[0];
    int ind = 0;

    for (int k = 1; k < sums.Length; k++)
    {
        if (sums[k] < summ)
        {
            summ = sums[k];
            ind = k;
        }
    }
    return ind;
}

int[,] matr = CreateArrayint();
FillArrayInt(matr, EnterMinMaxInt());
PrintArrayInt(matr);
Console.WriteLine();
Console.WriteLine("Номер строки с наименьшей суммой элементов --> " + MinSummRow(matr));