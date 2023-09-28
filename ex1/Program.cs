// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System.Formats.Asn1;

Random generator = new Random();

int[] numbers = new int[generator.Next(0, 11)];
for (int i = 0; i<numbers.Length; i++)
{
    numbers[i] = generator.Next(100, 1000);
}
int summ = 0;
for (int j = 0; j<numbers.Length; j++)
{
    int a1 = numbers[j] % 10;
    if (a1 % 2 == 0)
    {
        summ += 1;
    }
}
Console.Write(summ);