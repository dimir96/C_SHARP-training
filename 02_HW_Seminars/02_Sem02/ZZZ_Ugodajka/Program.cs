Console.Clear();
// Игра угадайка. Программа загадывает случайное число. 
// Пользователь его угадывает. Если пользователь дает неправильный ответ, 
// то программа сообщает, больше загаданное число или меньше.

// **Усложнение: на отгадывание дается 3 попытки


Console.WriteLine("Сыграем в игру я загадал число от 1 до 10, у тебя есть три попытки что бы отгадать!");
Console.WriteLine();
int gess = new Random().Next(1,11);
int index = 1;

while(index<=3)
{
    Console.Write($"{index} попытка! Введите число: ");
    int answer =  Convert.ToInt32(Console.ReadLine());
    if (gess == answer) 
    {
        Console.WriteLine("Правильно!!!");
        break;
    }
    if (index==3) 
    {
        Console.WriteLine("Ты проиграл :( попробуй еще раз!");
        break;
    }
    Console.WriteLine($"Не правильно, число {Сomparison(gess, answer)}");
    Console.WriteLine();
    index++;
}


string Сomparison(int gess, int answer)
{
    if (answer<gess) return "больше";
    return "меньше";
}