int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}

int a1 = 45;
int b1 = 7;
int c1 = 75;
int a2 = 41;
int b2 = 58;
int c2 = 85;
int a3 = 1;
int b3 = 35;
int c3 = 20;

// int max1 = Max(a1, b1, c1);
// int max2= Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3); 
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3));

Console.WriteLine(max);