Console.Clear();
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


int[] numbers = new int[12];
int borders = 9;
FillArray(numbers,borders);
WriteArray(numbers);
int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0) sumPositive += numbers[i];
    else sumNegative += numbers[i];
}

Console.WriteLine(sumPositive);
Console.WriteLine(sumNegative);




void FillArray(int[]array, int border)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-border,border+1);
    }    
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }  
    Console.WriteLine();
}
