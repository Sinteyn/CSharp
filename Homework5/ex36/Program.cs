int[] CreateArray(int size) => new int[size];

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

void RandomFillArray(int[] array)
{
    Random rnd = new Random();
    int size = array.Length;
    
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-1000, 1001);
    }
}

int FindSumOfElementsOfOddIndx(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

void ArrayOutput(int[] array)
{
    Console.Write("Массив --> [");
    
    foreach(int el in array) 
    {
        if(el != array[array.Length - 1])
        Console.Write(el + ", ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int size = EnterSizeOfArray();
int[] array = CreateArray(size);
RandomFillArray(array);
ArrayOutput(array);
int sumElementsOnOdd = FindSumOfElementsOfOddIndx(array);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumElementsOnOdd}");

