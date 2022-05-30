Console.Clear();

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[123];
int mainMaxBorder = 200;
int searcMinBorder =10;
int searcMaxBorder =99;
FillArray(array,mainMaxBorder);
WriteArray(array);
int arrayLenth = 0;
int length=0;
for (int i = 0; i < array.Length; i++) // проверка чисел в границах для установки длинны массива
{
   if(array[i]>=searcMinBorder && array[i]<=searcMaxBorder) 
   {
       length += 1;
   }
}      
Console.WriteLine($"Количество элементов значения которых лежат в отрезке [10,99] - {length}.");



void FillArray(int[] array, int borderMax)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,borderMax+1);
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


