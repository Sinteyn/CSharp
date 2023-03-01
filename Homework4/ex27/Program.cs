int SumOfDigits(int num)
{
    if (num / 10 == 0)
        return num;
    return num % 10 + SumOfDigits(num / 10);
}