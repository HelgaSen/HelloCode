//Находим максимальное из 9 чисел с помощью массива
int Max(int arg1, int agr2, int arg3)
{
    int result = arg1;
    if (agr2 > result) result = agr2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 12, 565, 64, 466, 46, 799, 48, 5, 12 };

int max = Max(Max(array[0],array[1],array[2]),Max(array[3],array[4],array[5]),Max(array[6],array[7],array[8]));

Console.WriteLine(max);