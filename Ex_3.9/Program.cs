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

int countVmax = 0;
int countUmax = 0;
int countV = 0;
int countU = 0;
for (int i = 0; i < x-1; i++)
{
    if (array[i] > array[i + 1])
    {
        countV++;
        countVmax = countV;
        if (countVmax < countUmax)
        {
            countVmax = 0;
        }
    }
    else if (array[i] < array[i + 1])
    {
        countU++;
        countUmax = countU;
        if (countVmax > countUmax)
        {
            countUmax = 0;
        }
    }
}

if (countVmax > countUmax)
{
    Console.WriteLine($"длина последовательности равна {countVmax}");
}
else if  (countUmax > countVmax)
{
    Console.WriteLine($"длина последовательности равна {countUmax}");
}
else
{
    Console.WriteLine($"длина последовательности равна {countVmax}");
}