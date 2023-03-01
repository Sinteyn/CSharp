int num = new Random().Next(99, 999);
Console.WriteLine(num + "Случайное трехзначное число");

int SecondNum(int x)
{
    return x / 10 % 10;
}

Console.WriteLine(SecondNum(num) + "Вторая цифра числа " + num);