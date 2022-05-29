Console.Clear();
// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается


int i=0;
while (i==0)
{
    Console.WriteLine("Введите exit чтобы выйти из бесконечного цикла");
    
    
    if(Console.KeyAvailable) // Очень много гуглил чтобы найти слушатель нажатия клавиши в консоли который не блокирует выполнение программы.
    {
        string password = Console.ReadLine();
    
        if (password == "exit") break;
        
    }
    
System.Threading.Thread.Sleep(600); // а здесь только для красоты чтоб не летело миллион строк в секунду 
}