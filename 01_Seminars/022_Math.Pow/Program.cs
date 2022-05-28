Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
double pow =0;

for (int i = 1; i <= n; i++)
{
    pow = Math.Pow(i, 2);
    Console.Write($"{pow}, ");
}