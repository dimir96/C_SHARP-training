int MaxDigit(int digit)
{
    int first = number/10;
    int second = number%10;
        
    if (first>second) 
    {
        return first;
    }
    
        return second;
       
}

int RandomInt(int min, int max)
{
    return new Random().Next(min, max)
}

int number = RandomInt(10,100);

Console.WriteLine(number);

Console.WriteLine(MaxDigit(number));
