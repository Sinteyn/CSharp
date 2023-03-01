float EnterValueFloat(string str)
{
    Console.WriteLine(str);
    string val = Console.ReadLine()!;
    while (!float.TryParse(val, out float i))
    {
        Console.WriteLine($"Неккоректный ввод. {str}");
        val = Console.ReadLine()!;
    }
    float value = float.Parse(val);
    return value;
}

int EnterValueInt(string str)
{
    Console.WriteLine(str);
    string val = Console.ReadLine()!;
    while (!int.TryParse(val, out int i))
    {
        Console.WriteLine($"Неккоректный ввод. {str}");
        val = Console.ReadLine()!;
    }
    int value = int.Parse(val);
    return value;
}

int CounterMoreZero()
{   
    int count = 0;
    int len = EnterValueInt("Введите кол-во чисел, которые хотите ввести");
    for(int i = 0; i < len; i++)
    {
        if(EnterValueFloat("Введите число") > 0) count++; 
    }
    return count;
}


Console.WriteLine(CounterMoreZero());