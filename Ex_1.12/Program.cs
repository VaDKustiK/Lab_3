using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int[] array = new int[8];
int last = 0;
int ind = 0;

Console.WriteLine("Введите значения массива");
for (int i = 0; i <= 7; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] < 0)
    {
        last = array[i];
        ind = i+1;
    }
}
Console.WriteLine($"Число {last}, его индекс: {ind}");