// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();

Console.Write("Введите пятизначное число:");
string num = Console.ReadLine();

string newNum = String.Empty;


for (int i = num.Length-1; i >= 0; i--)
{
    char tempChar = num[i];
    newNum = newNum + tempChar;
}
if (num == newNum) Console.WriteLine("Число - полиндром!");
else Console.WriteLine("Число - НЕ полиндром!");