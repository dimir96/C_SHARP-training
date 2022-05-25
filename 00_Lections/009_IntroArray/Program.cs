int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}


int[] array = {41,52,38,44,88,756,75,87,98};


Console.WriteLine(array[0]);