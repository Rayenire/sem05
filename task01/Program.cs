﻿int[] array = new int[12];
int[] sum = new int[2];
void FillArray(int[] collection, int[] sum)
{
    for (int i = 0; i < collection.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        if (array[i] > 0) 
            sum[0] = sum[0] + array[i];
        else 
            sum[1] = sum[1] + array[i];
    }
}
FillArray(array, sum);
Console.WriteLine("Суммы положительных цифр = {0} и отр. = {1}", sum[0], sum[1]);

