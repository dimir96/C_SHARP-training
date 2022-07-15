// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> Нет


Console.Write("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=6 && number<=7)  Console.WriteLine("Да.");
if (number>7)  Console.WriteLine("Это не день недели.");
if (number<=5) Console.WriteLine("Нет.");