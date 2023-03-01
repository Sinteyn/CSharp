double[] CreateDoubleArray(int size) => new double[size];

void FillRandomDoubleArray(double[] array, double[] minMax)
{
    Random rnd = new Random();
    int size = array.Length;

    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(minMax[0] + rnd.NextDouble() * (minMax[1] - minMax[0]), 4);
    }
}

int EnterSizeOfArray()
{
    Console.WriteLine("Введите желаемое кол-во элементов массива");
    string size = Console.ReadLine()!;

    while(string.IsNullOrEmpty(size) || !int.TryParse(size, out int i) || int.Parse(size) < 0)
    {
        Console.WriteLine("Неккоректный ввод. Введите желаемое кол-во элементов массива");
        size = Console.ReadLine()!;
    }
    int rightSize = int.Parse(size);
    return rightSize;
}

double EnterMaxValue()
{
    Console.WriteLine("Введите максимальное значение элемента в массиве");
    string max = Console.ReadLine()!;

    while(string.IsNullOrEmpty(max) || !double.TryParse(max, out double i))
    {
        Console.WriteLine("Некорректный ввод. Введите максимально значение элемента в массиве");
        max = Console.ReadLine()!;
    }
    double rightMax = double.Parse(max);
    return rightMax;
}

double EnterMinValue()
{
    Console.WriteLine("Введите минимальное значение элемента в массиве");
    string min = Console.ReadLine()!;

    while(string.IsNullOrEmpty(min) || !double.TryParse(min, out double i))
    {
        Console.WriteLine("Некорректный ввод. Введите минимальное значение элемента в массиве");
        min = Console.ReadLine()!;
    }
    double rightMin = double.Parse(min);
    return rightMin;
}

double[] CheckMinMax()
{
    double[] minMax = new double[2];
    double min = EnterMinValue();
    double max = EnterMaxValue();

    while(max < min)
    {
        Console.WriteLine($"Неккоректный ввод {min} > {max}");
        min = EnterMinValue();
        max = EnterMaxValue();
    }
    minMax[0] = min;
    minMax[1] = max;

    return minMax;
}

double DifferenceBetweenMinMaxValues(double[] array)
{
    double diff = Math.Round(array.Max() - array.Min(), 4);
    return diff;
}

void PrintArray(double[] array)
{
    int size = array.Length;

    Console.Write("Массив --> [");
    
    foreach(double el in array)
    {
        if(el != array[size - 1])
        Console.Write($"{el}, ");
    } 
    Console.WriteLine(array[size - 1] + "]");

}

int size = EnterSizeOfArray();
double [] dblArray = CreateDoubleArray(size);
double[] minMax = CheckMinMax();

FillRandomDoubleArray(dblArray, minMax);
PrintArray(dblArray);

double diffMinMax = DifferenceBetweenMinMaxValues(dblArray);

Console.WriteLine($"Разность большего и меньшего элемента массива = {diffMinMax}");
