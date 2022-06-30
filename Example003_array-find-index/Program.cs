int[] array = { 10, 157, 31, 45, 57, 384, 19, 28, 384, 122 };

int find = 122;
int index = 0;
int n = array.Length;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine("Индекс совпадающего элемента = " + index);
        break;
    }
    index++;
    if(index == n) 
    {
        Console.WriteLine("Совпадений не найдено!");
    }
}