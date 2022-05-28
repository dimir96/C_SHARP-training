Console.Clear();

double GetCoordinate(string corName, string pointName)
{
    Console.Write($"Введите координату {corName} точки {pointName}: ");
    return Convert.ToInt64(Console.ReadLine());
}

double x1 = GetCoordinate("x", "A");
double y1 = GetCoordinate("y", "A");
double x2 = GetCoordinate("x", "B");
double y2 = GetCoordinate("x", "B");


double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

Console.Write($"Расстояние между точками равно {result}.");