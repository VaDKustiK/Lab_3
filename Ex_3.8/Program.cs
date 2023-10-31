using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введите длину массива");
int x = int.Parse(Console.ReadLine());
int[] array = new int[x];
Console.WriteLine("Введите значения массива");
for (int i = 0; i < x; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < x-1; i++)
{
    for (int j = i+1; j < x; j++)
    {
        if (array[i] < array[j] && array[i] < 0 && array[j] < 0)
        {
            int s = array[i];
            array[i] = array[j];
            array[j] = s;
        }
    }
}
Console.WriteLine(string.Join(", ", array));