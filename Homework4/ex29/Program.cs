int EnterNumberOfElements()
{
    Console.WriteLine("Введите желаемое кол-во эелементов массива");
    string? num = Console.ReadLine();

    while (string.IsNullOrEmpty(num) || !int.TryParse(num, out int i))
    {
        Console.WriteLine("Некорректный ввод. Введите желаемое кол-во эелементов массива");
        num = Console.ReadLine();
    }
    int right_number = int.Parse(num);
    return right_number;
}

void CreateNewArray(int numsOfElements)
{
    File.WriteAllText("array.txt", string.Empty);
for (int i = 0; i < numsOfElements; i++)
{
    if(i == numsOfElements - 1)
    {
        File.AppendAllText("array.txt", Convert.ToString(new Random().Next(-10, 10)));
        break;
    } 
    File.AppendAllText("array.txt", Convert.ToString(new Random().Next(-10, 10)) + ", ");
}
string array = File.ReadAllText("array.txt");
Console.WriteLine("[" + array + "]");
}

int numsOfElements = EnterNumberOfElements();
CreateNewArray(numsOfElements);