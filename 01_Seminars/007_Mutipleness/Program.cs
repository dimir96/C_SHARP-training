int GetNumber ()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

//----------------------------------------------

int first = GetNumber();
int second = GetNumber();

if (first % second == 0)
{
    Console.WriteLine("Кратно");
}
else
{
 Console.WriteLine("Не кратно, остаток "+first % second);
}