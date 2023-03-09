void PrintArrayDouble(double[,] matrix)
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

void FillArrayDouble(double[,] matrix, double[] minMax)
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

void FillArrayInt(int[,] matrix, int[] minMax)
{
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minMax[0], minMax[1]);
        }
    }
}

double[,] CreateArrayDouble(){
        int row = EnterValuesInt("Введите кол-во строк матрицы");
    while(row <= 0){
        Console.WriteLine("Неккоректный ввод");
        row = EnterValuesInt("Введите кол-во строк матрицы");
    }
    int column = EnterValuesInt("Введите кол-во столбцов матрицы");
    while(column <= 0){
        Console.WriteLine("Неккоректный ввод");
        column = EnterValuesInt("Введите кол-во столбцов матрицы");
    }
    return new double[row, column];
}

int[,] CreateArrayint(){
    int row = EnterValuesInt("Введите кол-во строк матрицы");
    while(row <= 0){
        row = EnterValuesInt("Неккоректный ввод. Введите кол-во строк матрицы");
    }
    int column = EnterValuesInt("Введите кол-во столбцов матрицы");
    while(column <= 0){
        column = EnterValuesInt("Неккоректный ввод. Введите кол-во столбцов матрицы");
    }
    return new int[row, column];
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

double[] EnterMinMaxDouble()
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

int[] EnterCoordinates()
{
    int[] coordinates = new int[2];
    int row = EnterValuesInt("Введите строку искомого элемента в матрице");

    if(row < 0){
        Console.WriteLine("Неккоректный ввод");
        row = EnterValuesInt("Введите строку искомого элемента в матрице");
    }

    int column = EnterValuesInt("Введите столбец искомого элемента в матрице");

    if(column < 0){
        Console.WriteLine("Неккоректный ввод");
        column = EnterValuesInt("Введите столбец искомого элемента в матрице");
    }

    coordinates[0] = row;
    coordinates[1] = column;

    return coordinates;
}

bool YesNo(String answer)
{
    if (answer == "Y")
    {
        return true;
    }
    return false;
}

string IntOrDoubleMatrix()
{
    Console.WriteLine("Создаем массив целых чисел? Y/N");
    string answer = Console.ReadLine()!.ToUpper();

    while (!answer.Equals("Y") && !answer.Equals("N"))
    {
        Console.WriteLine("Неккоректный ввод. Создаем массив целых чисел? Y/N");
        answer = Console.ReadLine()!.ToUpper();
    }
    return answer;
}

void FindElementInt(int[,] matrix, int[] coordinates)
{
    if (coordinates[0] > matrix.GetLength(0) || coordinates[1] > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        int row = coordinates[0];
        int column = coordinates[1];

        Console.WriteLine($"Элеммент с координатами {row}, {column} --> {matrix[row, column]}");
    }
}

void FindElementDouble(double[,] matrix, int[] coordinates)
{
    if (coordinates[0] > matrix.GetLength(0) || coordinates[1] > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        int row = coordinates[0];
        int column = coordinates[1];

        Console.WriteLine($"Элеммент с координатами {row}, {column} --> {matrix[row, column]}");
    }
}

bool flag = YesNo(IntOrDoubleMatrix());

if (flag)
{
    int[,] matrixint = CreateArrayint();
    FillArrayInt(matrixint, EnterMinMaxInt());
    PrintArrayInt(matrixint);
    FindElementInt(matrixint, EnterCoordinates());
}
else
{
    double[,] matrixDouble = CreateArrayDouble();
    FillArrayDouble(matrixDouble, EnterMinMaxDouble());
    PrintArrayDouble(matrixDouble);
    FindElementDouble(matrixDouble, EnterCoordinates());
}
