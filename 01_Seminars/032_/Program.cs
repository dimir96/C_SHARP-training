Console.Clear();
// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Write("Введите количество елементов в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);

Console.WriteLine();
WriteArray(array);

for (int i = 0; i < array.Length; i++)
{
    array[i]=-array[i];
}

Console.WriteLine();
WriteArray(array);





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
    Console.WriteLine();
}
