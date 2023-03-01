double Degree(double num, double deg)
{
    if (deg == 0)
        return 1;

    return num * Degree(num, deg = deg - 1);
}