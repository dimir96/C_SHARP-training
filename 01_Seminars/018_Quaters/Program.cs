Console.Clear();
Console.Write("Введите номер четверти: ");
int quoterNumber = Convert.ToInt32(Console.ReadLine());

int x = 0;
int y = 0;

if (quoterNumber<0 || quoterNumber>4)
{
    Console.Write("Введите число от одного до четырех");
    return;
}


if (quoterNumber==1)
{
    Console.WriteLine("х в диапазомне от 0 до плюс бесконечности");
    Console.WriteLine("у в диапазоне от 0 до плюс бесконечности");
}

if (quoterNumber==2)
{
    Console.WriteLine("х в диапазомне от  минус бесконечности до 0");
    Console.WriteLine("у в диапазоне от 0 до плюс бесконечности");
}

if (quoterNumber==3)
{
    Console.WriteLine("х в диапазомне от  минус бесконечности до 0");
    Console.WriteLine("у в диапазомне от  минус бесконечности до 0");
}

if (quoterNumber==4)
{
    Console.WriteLine("х в диапазомне от 0 до плюс бесконечности");
    Console.WriteLine("у в диапазомне от  минус бесконечности до 0");
}

