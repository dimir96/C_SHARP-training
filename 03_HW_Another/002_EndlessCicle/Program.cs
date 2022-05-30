Console.Clear();
// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается
// Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (можно придумать еще самостоятельно). Например:
// SetName – Установить имя
// Help – вывести список команд
// SetPassword – Установить пароль
// Exit – выход
// WriteName – вывести имя после ввода пароля

//---------Parameters----------//
string command = String.Empty;
string name = String.Empty;
string password = String.Empty;

//---------Commands----------//
string exit = "exit";
string setName = "set name";
string setPassword = "set password";
string showName = "show name";
string help = "help";

while (true)
{   
    Console.WriteLine();
    Console.Write("Введите команду: ");
    command = Console.ReadLine();
    if (command == exit) break; 
    if (command == setName) 
    {
        Console.Write("Установите имя пользователя: ");
        name = Console.ReadLine();
    }
    if(command == setPassword)
    {
        Console.Write("Установите пароль: ");
        password = Console.ReadLine();
       
    }
      if(command == showName)
    {
        if (password == String.Empty) 
        {
            Console.WriteLine("Ошибка! Сначала установите пароль.");
            continue;
        }
        CheckPassword:
        Console.Write("Введите пароль: ");
        string tempPassword = Console.ReadLine();
        if (tempPassword == password)
        {
           Console.WriteLine(name);
        }
        
        if (tempPassword != password)   
        {
            Console.WriteLine("Ошибка! Неправильный пароль.");  
            goto CheckPassword;
        } 
        if (name == String.Empty) 
        {
            Console.WriteLine("Сначала установите  имя пользователя.");
            continue;
        }
    }
    if (command == help) 
    {
        Console.WriteLine("set name - устанавливает имя пользователя.");
        Console.WriteLine("set password - устанавливает пароль.");
        Console.WriteLine("show name - показывает имя пользователя после ввода пароля.");
        Console.WriteLine("help - выводит список всех команд.");
        Console.WriteLine("exit - заканчивает программу.");
    }
}