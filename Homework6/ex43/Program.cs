float EnterValueFloat(string str)
{
    Console.WriteLine(str);
    string val = Console.ReadLine()!;
    while (!float.TryParse(val, out float i))
    {
        Console.WriteLine($"Неккоректный ввод. {str}");
        val = Console.ReadLine()!;
    }
    float value = float.Parse(val);
    return value;
}

float[] FindСoordinatesLines(string str)
{
    float[] point = new float[2];
    for(int i = 0; i < 2; i++)
    {
        Console.WriteLine(str);
        point[i] = EnterValueFloat($"Введите значение {i + 1} -ой координаты");
    }
    return point;
}

float[] FindThePointOfIntersection(float[] point1, float[] point2)
{
    float[] point = new float[2];
    point[0] = (point2[0] - point1[0])/(point1[1]-point2[1]);
    point[1] = point1[1] * point[0] + point1[0];
    return point;
}

float[] line1 = FindСoordinatesLines("Введите координаты первой линии");
float[] line2 = FindСoordinatesLines("Введите координаты второй линии");
float[] result = FindThePointOfIntersection(line1, line2);
Console.WriteLine($"({result[0]}; {result[1]})");