int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Введи число: ");
int n;
bool log = false;
n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    if (n == array[i])
    {
        log = true;
        break;
    }
}
if (log)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}


