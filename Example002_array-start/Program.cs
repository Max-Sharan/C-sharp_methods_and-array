int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 10, 157, 31, 45, 57, 122, 19, 28, 471 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));  // метод внутри метода, можно и в одну строку!

Console.WriteLine("Победитель первой 3-ки = " + Max(array[0], array[1], array[2]));
Console.WriteLine("Победитель второй 3-ки = " + Max(array[3], array[4], array[5]));
Console.WriteLine("Победитель третьей 3-ки = " + Max(array[6], array[7], array[8]));
Console.WriteLine("Максимальное число среди всех = " + max);