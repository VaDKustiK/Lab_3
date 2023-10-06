using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int[] array = new int[10];
int count = 0;

Console.WriteLine("(P < Q)");
Console.WriteLine("Введите значение P");
int p = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Q");
int q = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значения массива");
for (int i = 0; i <= 9; i++)
{
    array[i] = int.Parse(Console.ReadLine());

    if (array[i] > p && array[i] < q)
    {
        count++;
    }
}
Console.WriteLine($"Количество значений между P и Q: {count}");