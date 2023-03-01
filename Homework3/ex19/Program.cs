int enter_fivedigit_number()
{
    Console.WriteLine("Введите пятизначное число");
    string? num = Console.ReadLine();

    while (string.IsNullOrEmpty(num) || !int.TryParse(num, out int i) || num.Length != 5)
    {
        Console.WriteLine("Некорректный ввод. Введите пятизначное число");
        num = Console.ReadLine();
    }
    int right_number = int.Parse(num);
    return right_number;
}

bool check_palindrome(int fivedigit_number)
{
    int[] digits = new int[5];

    for (int i = 4; i >= 0; i--)
    {
        digits[i] = fivedigit_number % 10;
        fivedigit_number /= 10;
    }

    for (int i = 0; i < 5; i++)
    {
        if (digits[i] != digits[4 - i])
            return false;
    }

    return true;
}

int num = enter_fivedigit_number();
bool flag = check_palindrome(num);

if (flag)
    Console.WriteLine("Число " + num + " является палиндромом");
else 
    Console.WriteLine("Число " + num + " не является палиндромом");