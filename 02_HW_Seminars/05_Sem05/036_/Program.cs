﻿Console.Clear();
//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Write("Введите размер массива: ");
int length =Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

FillArray(array);
WriteArray(array);
Console.WriteLine();
int sum=0;

for (int i = 1; i < array.Length; i=i+2)
{
    sum += array[i];
}
Console.WriteLine(sum);





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