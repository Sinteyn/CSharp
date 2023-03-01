Console.WriteLine("Введите первое число:  ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
double b = Convert.ToDouble(Console.ReadLine());

if (a > b)
    Console.WriteLine(a + " больше чем " + b);
else if (a < b)
    Console.WriteLine(b + " больше чем " + a);
else
    Console.WriteLine(a + " равно " + b);