Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA<numberB)
{
    Console.WriteLine(numberA + " меньшее, а " + numberB + " большее.");
}
else
{
    Console.WriteLine(numberB + " меньшее, а " + numberA + " большее.");
}