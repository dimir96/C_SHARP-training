Console.Clear();
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Поправка: на семинаре дал добро на заволнение массива рандомными числами. 
// В оригинале нужно пользователю ввести строку - ряд чисел через запятую, 
// а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)

//----------МЕТОДЫ----------//
    string GetArray ()
    {
        Console.Write($"Введите целые числа, через запятую: ");
        return Console.ReadLine();
    }
    int GetArrayLenth ()
    {
        Console.Write($"Сколько чисел вы ввели? ");
        return Convert.ToInt32(Console.ReadLine());
    }

    int[] CleanArray(string dirtyStringArray, int arrayLength)
    {
        int[] integerArray = new int[arrayLength];
        int j = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            string tempNumber = String.Empty;
            while (j < dirtyStringArray.Length)
            {
                
                if(dirtyStringArray[j]>=48 && dirtyStringArray[j]<=57) 
                {
                    tempNumber = tempNumber+dirtyStringArray[j];
                    j++;
                }
                else
                {
                    j++;
                    break;
                }
            }
            integerArray[i] = Convert.ToInt32(tempNumber);
        }
                
        return integerArray;
    }

    void PrintArray (int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}, "); 
        }
        Console.Write("]");
    }


//----------РЕШЕНИЕ----------


    PrintArray( CleanArray( GetArray() , GetArrayLenth() ) ); 
