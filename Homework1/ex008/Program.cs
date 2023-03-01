Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 2;

while (i <= num)
{
    Console.Write(i + ", ");
    i += 2;
}

Console.WriteLine(" <-- все четные числа от 1 до " + num);