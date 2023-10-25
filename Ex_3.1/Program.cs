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

int maxi = array[0];
for (int i = 0; i < x; i++)
{
    if (array[i] >= maxi)
    {
        maxi = array[i];
    }
}

int count = 0;
for (int i = 0; i < x; i++)
{
    if (array[i] == maxi)
    {
        count++;
    }
}

int[] array2 = new int[count];
int j = 0;
for (int i = 0; i < x; i++)
{
    if (array[i] == maxi)
    {
        array2[j] = i;
        j++;
    }
}
Console.WriteLine(string.Join(", ", array2));