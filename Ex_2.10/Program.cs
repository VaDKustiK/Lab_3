using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введите длину массива");
int x = int.Parse(Console.ReadLine());
int[] num = new int[x];
Console.WriteLine("Введите значения массива");
for (int i = 0; i < num.Length; i++)
{
    num[i] = int.Parse(Console.ReadLine());
}

int mini = 10000;
for (int i = 0; i < x; i++)
{
    if (num[i] > 0 && num[i] < mini)
    {
        mini = num[i];
    }
}

int[] num2 = new int[x-1];
int j = 0;
for (int i = 0; i < x; i++)
{
    if (num[i] != mini)
    {
        num2[j] = num[i];
        j++;
    }
}

Console.WriteLine(string.Join(", ", num2));
Console.WriteLine($"удаленный элемент: {mini}");