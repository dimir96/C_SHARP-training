Console.Clear();

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int length =Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

FillArray(array);
WriteArray(array);
Console.WriteLine();
int min=array[0];
int max=array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max)
    {
        max=array[i];
    }
    if (array[i]<min)
    {
        min=array[i];
    }
}
Console.WriteLine(max-min);





void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10,100);
    }    
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
        
    }  
    Console.WriteLine();
}