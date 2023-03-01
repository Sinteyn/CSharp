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

void RandomFillArrayThreeDigitNumbers(int[] array)
{
    Random rnd = new Random();
    int size = array.Length;
    
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}

int EvenNumberСounter(int[] array)
{
    int count = 0;

    foreach(int element in array)
    {
        if(element % 2 == 0) count++;
    }
    return count;
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
RandomFillArrayThreeDigitNumbers(array);
int count = EvenNumberСounter(array);
ArrayOutput(array);

Console.WriteLine($"В этом массиве {count} четных элемента(ов)");