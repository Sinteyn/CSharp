Console.WriteLine("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine("Число " + num + " четное");
else
    Console.WriteLine("Число " + num + " нечетное");