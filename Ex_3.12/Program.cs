using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int[] array = new int[12];
Console.WriteLine("Введите значения массива");
for (int i = 0; i < 12; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

int count = 0;
for (int i = 0; i < 12; i++)
{
    if (array[i] < 0)
    {
        int k = i;
        count++;
        for (int j = k; j < 11 - count + 1; j++)
        {
            array[j] = array[j + 1];
        }
        i--;
        array[11 - count + 1] = 0;
    }
}
Console.WriteLine("Новые значения");
for (int i = 0; i < 12 - count; i++)
{
    Console.WriteLine($"{array[i]}");
}