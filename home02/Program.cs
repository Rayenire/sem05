// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[10];
for (int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + " ");
}
int sum = 0;
for (int i = 1; i < array.Length;)
{
    sum = sum + array[i];
    i = i+2;
} 
Console.WriteLine();
Console.WriteLine("Сумма элементов на нечётных позициях =  ");
Console.WriteLine(sum);
