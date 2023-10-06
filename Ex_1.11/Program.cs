using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int[] array = new int[10];
int count = 0;

Console.WriteLine("Введите значение массива");
for  (int i = 0; i <= 9; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество положительных чисел: {count}");