Console.Clear();
//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Write("Введите размер массива: ");
int length =Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

FillArray(array);
WriteArray(array);
Console.WriteLine();
int counter=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        counter++;
    }
}
Console.WriteLine(counter);





void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
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