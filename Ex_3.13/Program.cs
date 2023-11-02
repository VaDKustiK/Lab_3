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
for (int i = 0; i < 12 - 1; i++)
{
    for (int j = i + 1; j < 12 - count;)
    {
        if (array[i] == array[j])
        {
            count++;
            for (int k = j; k < 11; k++)
            {
                array[k] = array[k + 1];
            }
        }
        else
        {
            j++;
        }
    }
}

Console.WriteLine("Новые значения");
for (int i = 0; i < 12 - count; i++)
{
    Console.WriteLine($"{array[i]}");
}