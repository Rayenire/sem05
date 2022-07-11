// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[10];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10, 11);
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

FillArray(array);
PrintArray(array);

int sum = 0;
for (int i = 1; i < array.Length;)
{
    sum = sum + array[i];
    i = i+2;
} 
Console.Write("Сумма нечётных элементов =  ");
Console.WriteLine(sum);
