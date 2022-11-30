int[] array = { 16, 72, 830, 84, 24, 57, 36, 47, 84 };

int n = array.Length;
int find = 84;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}