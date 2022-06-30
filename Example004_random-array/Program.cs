void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 33);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

void IndexOf(int[] collection, int find)
{
    int index = 0;
    int length = collection.Length;
    int position = 0;

    while(index < length)
    {
        if (collection[index] == find)
        {
            position = index;
            Console.WriteLine("Индекс совпадающего элемента = " + position);
            break;
        }
        index++;
        if(index == length) 
        {
            Console.WriteLine("Совпадений не найдено!");
        }
    }
    // return position; // это если мы решим сделать метод с возвратом результата.
}

int[] array = new int[15];

FillArray(array);
PrintArray(array);

Console.WriteLine();

// int pos = IndexOf(array, 155); // это при использовании метода с возвратом результата.
IndexOf(array, 15);
// Console.WriteLine("Индекс совпадающего элемента = " + pos);
                                    // это при использовании метода с возвратом результата.
