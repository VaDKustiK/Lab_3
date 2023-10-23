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

int max = num[0];
int maxi = 0;
for (int i = 0; i < x; i += 2)
{
    if (num[i] > max)
    {
        max = num[i];
        maxi = i;
    }
}

if (maxi % 2 == 0)
{
    num[maxi] = maxi;
}
Console.WriteLine(string.Join(", ", num));