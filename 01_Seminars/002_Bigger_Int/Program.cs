Console.Write("Ввердите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввердите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = number1 * number1;

if (number2 == square) Console.Write("ДА");
else 
{
    Console.Write("НЕТ");
}