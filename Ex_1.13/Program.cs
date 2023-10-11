using System;
using System.Collections.Generic;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int[] array = new int[10];
int[] chet = new int[5];
int[] nechet = new int[5];

Console.WriteLine("Введите значения массива");

for (int i = 0; i < 10; i++)
{
    array[i] = int.Parse(Console.ReadLine());

    for (int j = 0; j < 10; j++)
    {
        if (i % 2 == 0)
        {
            chet[i / 2] = array[i];
        }
        else
        {
            nechet[i / 2] = array[i];
        }
    }
}
Console.WriteLine("Четные индексы:");
Console.WriteLine(string.Join(", ", chet));
Console.WriteLine("Нечетные индексы:");
Console.WriteLine(string.Join(", ", nechet));