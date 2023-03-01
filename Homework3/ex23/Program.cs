double enter_number()
{
    Console.WriteLine("Введите число ");
    string number = Console.ReadLine()!;

    while (string.IsNullOrEmpty(number) || !double.TryParse(number, out double i))
    {
        Console.WriteLine("Некорректный ввод. Введите число");
        number = Console.ReadLine()!;
    }
    double right_number = double.Parse(number);
    return right_number;
}

void cube_table(double number)
{
    if (number >= 1)
    {
        for (int i = 1; i<number; i++)
            Console.Write(Math.Pow(i, 3) + ", ");
        Console.WriteLine(Math.Pow(number, 3));
    }
    else
        Console.WriteLine("Число меньше 1");
}

double num = enter_number();
Console.Write(num + " --> ");
cube_table(num);
