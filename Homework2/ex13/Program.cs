int num = new Random().Next(0, 100000);
Console.WriteLine(num);

string Thirdnum(int num)
{
    if (num < 100)
        return "Третьей цифры нет";
    else
    {
        string strnum = Convert.ToString(num);
        string third = Convert.ToString(strnum[2]);
        return third;
    }
}

Console.WriteLine(Thirdnum(num));