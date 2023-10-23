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

Console.WriteLine("Введите число P");
double p = double.Parse(Console.ReadLine());


int xi = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        xi = i;
    }
}

double[] array2 = new double[x + 1];
int j = 0;
for (int i = 0; i < x + 1; i++)
{
    if (i <= xi)
    {
        array2[j] = array[i];
        j++;
    }
    else if (i == xi + 1)
    {
        array2[j] = p;
        j++;
    }
    else if (i > xi + 1)
    {
        array2[j] = array[i-1];
        j++;
    }
}
Console.WriteLine(string.Join(", ", array2));