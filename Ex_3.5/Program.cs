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

for (int i = 0; i < x; i += 2)
{
    for (int j = i + 2; j < x; j += 2)
    {
        if (array[i] > array[j])
        {
            int s = array[i];
            array[i] = array[j];
            array[j] = s;
        }
    }
}
Console.WriteLine(string.Join(", ", array));