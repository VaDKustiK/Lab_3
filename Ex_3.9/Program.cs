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
int countV = 1;
int countU = 1;
for (int i = 1; i < x; i++)
{
    if (array[i] >= array[i - 1])
    {
        countV++;
    }
    else
    {
        if (countV > countVmax)
        {
            countVmax = countV;
        }
        countV = 1;
    }

    if (array[i] <= array[i - 1])
    {
        countU++;
    }
    else
    {
        if (countU > countUmax)
        {
            countUmax = countU;
        }
        countU = 1;
    }
}

if (countV > countVmax)
{
    countVmax = countV;
}

if (countU > countUmax)
{
    countUmax = countU;
}

if (countVmax > countUmax)
{
    Console.WriteLine($"Максимальная длина возрастающей последовательности равна {countVmax}");
}
else if (countUmax > countVmax)
{
    Console.WriteLine($"Максимальная длина убывающей последовательности равна {countUmax}");
}
else
{
    Console.WriteLine($"Максимальная длина убывающей и возрастающей последовательности равны {countUmax}");
}