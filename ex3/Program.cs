// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Random generator = new Random();

double[] numbers = new double[generator.Next(0, 11)];
for (int i = 0; i<numbers.Length; i++)
{
    numbers[i] = generator.NextDouble() * 100;
}

double max = 0;
for (int j = 0; j<numbers.Length; j++)
{
    if (numbers[j]>max)
    {
        max = numbers[j];
    }
}

double min = max;
for (int k = 0; k<numbers.Length; k++)
{
    if (numbers[k]<min)
    {
        min = numbers[k];
    }
}
Console.Write("{0,6:F2}", max-min);