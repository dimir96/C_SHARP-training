int[] array = {17,27,473,4,5,476,774,48,9};

int n = array.Length;
int find = 476;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
}