Console.Clear();
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string GetNumber ()
{
    Console.Write($"Введите число: ");
    return Console.ReadLine();
}

int[] CreateArray(string textArray)
{
    int[] integerArray= new int[textArray.Length];
    for (int i = 0; i < textArray.Length; i++)
    {
        integerArray[i] = textArray[i] - '0';
        
    }
    return integerArray;
}


// ---------------------------------------------------------------------------

int[] digitArray = CreateArray(GetNumber());
int sum = 0;
for (int i = 0; i < digitArray.Length; i++)
{
    sum = sum + digitArray[i];
    
}

Console.WriteLine($"Сумма всех цифр числа равна {sum}.");