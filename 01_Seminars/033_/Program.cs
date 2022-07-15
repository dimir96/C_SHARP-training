Console.Clear();
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите количество елементов в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);

Console.Write("Какое число вы хотите найти?: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());

bool check =false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]==searchNumber)
    {
        check = true;
        break;
    }
}

if (check==true) 
{
    Console.WriteLine($"Число {searchNumber} находиться в массиве"); 
}

else
{
    Console.WriteLine($"Число {searchNumber} НЕ находиться в массиве");
}




int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }  
    return array;  
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }  
}
