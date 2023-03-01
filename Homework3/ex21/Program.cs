double[] enter_coordinates()
{
    double[] coordinates = new double[3];

    Console.WriteLine("Введите Х координату");
    coordinates[0] = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите Y координату");
    coordinates[1] = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите Z координату");
    coordinates[2] = double.Parse(Console.ReadLine()!);
    return coordinates;
}   

double distance_between_points(double[] A, double[] B)
{
    return Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2) + Math.Pow(B[2] - A[2], 2));
}

Console.WriteLine("Ввод координат первой точки");
double[] a = enter_coordinates();

Console.WriteLine("Ввод координат второй точки");
double[] b = enter_coordinates();

Console.WriteLine("Расстояние между точками = " + distance_between_points(a,b));
