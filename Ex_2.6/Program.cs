using System;
using System.Text;
using System.Xml.Schema;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введите длину массива");
int x = int.Parse(Console.ReadLine());
double[] array = new double[x];

Console.WriteLine("Введите значения массива");
for (int i = 0; i < x; i++)
{
    array[i] = double.Parse(Console.ReadLine());
}

double s = array.Sum() / array.Length;
Console.WriteLine($"s = {s}");

Console.WriteLine("Введите число P");
double p = double.Parse(Console.ReadLine());


int xi = 0;
for (int i = 0; i < array.Length; i++)
{
    if (Math.Abs(array[i] - s) < Math.Abs(array[xi] - s))
    {
        xi = i;
    }
}
Console.WriteLine($"xi = {xi}");

double[] array2 = new double[x + 1];
int k = 0;
for (int i = 0; i < x + 1; i++)
{
    if (i <= xi)
    {
        array2[k] = array[i];
        k++;
    }
    else if (i == xi + 1)
    {
        array2[k] = p;
        k++;
    }
    else if (i > xi + 1)
    {
        array2[k] = array[i-1];
        k++;
    }
}

Console.WriteLine(string.Join(", ", array2));