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

int maxi = num[0];
int i_maxi = 0;
int mini = num[0];
int i_mini = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > maxi)
    {
        i_maxi = i;
        maxi = num[i];
    }
    if (num[i] < mini)
    {
        i_mini = i;
        mini = num[i];
    }
}

int start = i_mini;
int end = i_maxi;
if (i_mini < i_maxi)
{
    start = i_mini;
    end = i_maxi;
}
else
{
    start = i_maxi;
    end = i_mini;
}

int count = 0;
for (int i = start + 1; i < end; i++)
{
    count++;
}

int[] num2 = new int[count];
int j = 0;
for (int i = start + 1; i < end; i++)
{
    num2[j] = num[i];
    j++;
}
//Console.WriteLine("num2:");
//Console.WriteLine(string.Join(", ", num2));

double s = num2.Sum() / count;
Console.WriteLine($"Среднее арифметическое = {s}");