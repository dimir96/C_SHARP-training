// // Вид 1
// void  Method1()
// {
//     Console.WriteLine("Автор ....");
// }

// Method1();


// // Вид 2

// void Meethod2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Meethod2("Текст сообщения");

// void Meethod21(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
    
// }
// Meethod21(msg:"Текст ", count:4);


// // Вид 3

// int Meethod3()
// {
//     return DateTime.Now.Year;

// }

// int year = Meethod3();
// Console.WriteLine(year);

// // Вид 4
// string Meethod4(int count, string text)
// {
//     int i=0;
//     string result = String.Empty;
//     while (i<count)
//     {
//         result =  result + text;
//         i++;
//     }
//     return result;
// }

// string res = Meethod4(10, "asdf");
// Console.WriteLine(res);



// string Meethod41(int length, string text)
// {
    
//     string result = String.Empty;
//     for (int i = 0; i < length; i++)
//     {
//         result =  result + text;
//     }
//     return result;
// }
// string res2 = Meethod41(10, "asdf");
// Console.WriteLine(res2);


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


string text = "Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля." 
            + "Вы так красноречивы. Вы дадите мне чаю?";


string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result = result + text[i];
       
    }    

    return result;
}

string  newText = Replace(text, ' ','|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к','К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с','С');
Console.WriteLine(newText);
Console.WriteLine();



// int[] arr = {1, 2, 5, 4, 8, 78, 658, 4, 25};

// void PrintArray(int[] array)
// {
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPosition = i;
        
//         for (int j = i+1; j < array.Length; j++)
//         {
//             if (array[j]>array[maxPosition]) maxPosition=j;
//         }   

//         int temporary = array[i];
//         array[i]=array[maxPosition];
//         array[maxPosition]=temporary;

//     }
// }   



// PrintArray(arr);

// SelectionSort(arr);
// PrintArray(arr);