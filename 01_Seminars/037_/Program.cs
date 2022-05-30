Console.Clear();

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите размер массива: ");
int length =Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.Write("Введите граници массива: ");
int borders = Convert.ToInt32(Console.ReadLine());
FillArray(array, borders);
WriteArray(array);
Console.WriteLine();

int resultArrayLength = 0;
int j = array.Length-1;


if (length%2==0)
{
    resultArrayLength = length/2;
}
else
{
    resultArrayLength = length/2+1;
}
int[] resultArray = new int[resultArrayLength];

if (length%2==0)
{
    for (int i = 0; i < resultArrayLength; i++)
    {
        resultArray[i]= array[i]*array[j];
        j--;
    }
}
else
{
    int i = 0;
    while ( i < resultArrayLength-1)
    {
        resultArray[i]= array[i]*array[j];
        j--;
        i++;
    }
    resultArray[i]= array[i];
}

WriteArray(resultArray);




void FillArray(int[] array, int borders)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-borders,borders+1);
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