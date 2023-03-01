Console.WriteLine("Введите первое число: ");
double first = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double second = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double third = Convert.ToDouble(Console.ReadLine());

if (second < first & third < first)
    Console.WriteLine("Максимальное из трех чисел --> " + first);
else if (first < second & second > third)
    Console.WriteLine("Максимальное из трех чисел --> " + second);
else if (first < third & third > second)
    Console.WriteLine("Максимальное из трех чисел --> " + third);
else
    Console.WriteLine("Максимальное из трех чисел --> " + third);