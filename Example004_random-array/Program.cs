Console.Clear();

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 55);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine("Сгенерированный массив:");
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
            
            Console.WriteLine("Индекс элемента совпадающего с числом = " + position);
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

int[] array = new int[27];
int find = new Random().Next(1, 55);

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Искомое число среди элементов массива = " + find);
// int pos = IndexOf(array, 155); // это при использовании метода с возвратом результата.
IndexOf(array, find);
// Console.WriteLine("Индекс совпадающего элемента = " + pos);
                                    // это при использовании метода с возвратом результата.
