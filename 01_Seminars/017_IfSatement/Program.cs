Console.Clear();
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());


if (x==0 || y==0)
{
    Console.Write("X или Y не могут быть равны 0.");
    return;
}

int quaterNumber = 0;

if (x>0 && y>0)
{
    quaterNumber = 1;
}

if (x<0 && y>0)
{
    quaterNumber = 2;
}

if (x<0 && y<0)
{
    quaterNumber = 3;
}

if (x>0 && y<0)
{
    quaterNumber = 4;
}

Console.WriteLine($"Точка находиться в {quaterNumber} четверти");