using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

double L = 0;
double[] array = new double[5];

Console.WriteLine("Введите значения");

for (int i = 0; i <= 4; i++)
{
    array[i] = double.Parse(Console.ReadLine());
    L += Math.Pow(array[i], 2);
}
Console.WriteLine(Math.Sqrt(L));