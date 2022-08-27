int[] array = { 23, 453, 232, 11, 6, 231, 11 };
int n = array.Length;
int find = 231;
int index = 0;

while (index < n) 
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
    }
    index++;
}

