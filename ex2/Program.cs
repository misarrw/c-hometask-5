// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random generator = new Random();

int[] numbers = new int[generator.Next(0, 11)];
for (int i = 0; i<numbers.Length; i++)
{
    numbers[i] = generator.Next(-100, 101);
}
int summ = 0;
for (int i = 1; i < numbers.Length; i += 2)
{
    summ += numbers[i];
}
Console.Write(summ);