int[,,] CreateArrayint()
{
    int row = EnterValuesInt("Введите кол-во строк матрицы");
    while (row <= 0)
    {
        Console.WriteLine("Неккоректный ввод.");
        row = EnterValuesInt("Введите кол-во строк матрицы");
    }
    int column = EnterValuesInt("Введите кол-во столбцов матрицы");
    while (column <= 0)
    {
        Console.WriteLine("Неккоректный ввод");
        column = EnterValuesInt("Введите кол-во столбцов матрицы");
    }
    int depth = EnterValuesInt("Введите глубину матрицы");
    while (depth <= 0)
    {
        Console.WriteLine("Неккоректный ввод");
        depth = EnterValuesInt("Введите глубину матрицы");
    }
    return new int[row, column, depth];
}

void FillArrayNonRepeatTwoDigit(int[,,] matrix)
{
    Random rand = new Random();
    List<int> check = new List<int>();
    int num = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                num = rand.Next(10, 100);
                while (check.Contains(num))
                {
                    num = rand.Next(10, 100);
                }
                check.Add(num);
                matrix[i, j, k] = num;
            }
        }
    }
}

void PrintArrayInt(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write("{0, 8}", matrix[i, j, k]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
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

void PrintIndexingArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write("{0, 10}", matrix[i, j, k] + "(" + i + "," + j + "," + k + ")");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

int[,,] matr = CreateArrayint();
while (matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2) > 90)
{
    Console.WriteLine("Невозможно создать такого размера трёхмерный " +
                         "массив из неповторяющихся двузначных чисел");
    matr = CreateArrayint();
}

FillArrayNonRepeatTwoDigit(matr);
PrintArrayInt(matr);
Console.WriteLine();
PrintIndexingArray(matr);