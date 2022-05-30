Console.Clear();

// В переменной string есть секретное сообщение, 
// во второй есть пароль. Пользователю программы даётся 3 попытки 
// ввести пароль и увидеть секретное сообщение.

string sicretMassage = "Ты большой молодец, теперь ты знаешь мой год рождения :)";
string password = "1996";
Console.WriteLine("Сыграем в игру: отгадай пароль и увидешь секретное сообщение");
Console.WriteLine();
int index = 1;

while(index<=3)
{
    Console.Write($"{index} попытка! Введи пароль: ");
    string gessPassword =  Console.ReadLine();
    if (gessPassword ==password) 
    {
        Console.WriteLine(sicretMassage);
        break;
    }
    if (index==3) 
    {
        Console.WriteLine("Ты проиграл :( попробуй еще раз!");
        break;
    }
    Console.WriteLine(Help(index));
    Console.WriteLine();
    index++;
}


string Help(int i)
{
    if (i==1) 
    {
        return "Подсказка: Это год моего рождения";
    }
    
    if (i==2)
    {
        return "Подсказка: Последняя цифра пароля это 6";
    }
    return String.Empty;
}