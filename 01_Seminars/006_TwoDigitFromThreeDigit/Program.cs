
int number = new Random().Next(100,1000);
Console.WriteLine(number);
int TwoDigitNumber (int number)
{
    int first = number /100;
    int third = number % 10;
    return first*10+third;
}

Console.WriteLine(TwoDigitNumber(number));
