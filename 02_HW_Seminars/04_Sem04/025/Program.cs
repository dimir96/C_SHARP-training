Console.Clear();
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber (string lable)
{
    Console.Write($"Введите число {lable}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int pointA = GetNumber("A");
int pointB = GetNumber("B");
double CustomPower(int mainNumber, int powNumber)
{
    double result = 1;
    for (int i = 0; i < powNumber; i++)
    {
        result = result*mainNumber;
    }
    return result;
}
double result = CustomPower(pointA, pointB);
Console.WriteLine($"Число {pointA} в степени {pointB} равно {result}");