// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.
double[] array = new double[10];
for (int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }
}
Console.WriteLine();
Console.WriteLine("min = " +(min));
Console.WriteLine("max = " +(max));
Console.WriteLine("разница между max и min = " +(max - min));