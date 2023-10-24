using System;
using System.Runtime.Serialization.Formatters;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
Console.WriteLine("Введите значения массива A");
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine());
int[] b = new int[m];
Console.WriteLine("Введите значения массива B");
for (int i = 0; i < m; i++)
{
    b[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Введите значение K");
int k = int.Parse(Console.ReadLine());

int[] ab = new int[n + m];
int j = 0;
int t = 0;
for (int i = 0; i < n + m; i++)
{
    if (i <= k)
    {
        ab[j] = a[i];
        j++;
    }
    else if (i == k+1)
    {
        ab[j] = b[t];
        j++;
        t++;
    }
    else if (i > k && i <= k+m)
    {
        ab[j] = b[t];
        j++;
        t++;
    }
    else if (i > k+m)
    {
        ab[j] = a[i-m];
        j++;
    }
}
Console.WriteLine(string.Join("", ab));