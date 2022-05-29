// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());
int ostatok = num;
int i =0;

for ( i = 0; num > 0; i++)
{
    num = num/10;
    
        
}

Console.WriteLine($"Число {i}-значное");