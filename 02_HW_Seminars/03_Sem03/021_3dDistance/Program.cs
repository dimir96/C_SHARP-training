Console.Clear();
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int GetCoordinate(string corName, string pointName)
{
    Console.Write($"Введите координату {corName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = GetCoordinate("x", "A");
int y1 = GetCoordinate("y", "A");
int z1 = GetCoordinate("z", "A");
int x2 = GetCoordinate("x", "B");
int y2 = GetCoordinate("x", "B");
int z2 = GetCoordinate("z", "B");
double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.Write($"Расстояние между точками равно {result}.");