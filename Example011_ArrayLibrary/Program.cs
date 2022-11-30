void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOF(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //"Такой элемент не найден". Искусственный прием, который придумали прогеры, чтобы понять, что числа такого нет. Т.е. что произошло непредусмотренное.
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOF(array, 84);
Console.WriteLine(pos);