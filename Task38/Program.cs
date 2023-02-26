// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.


Console.WriteLine($"Какое количество чисел в массиве вы хотите увидеть: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = Math.Round(100 * (new Random().NextDouble()), 2);
}
double minValue = array[0];
double maxValue = array[0];
for (int i = 0; i < size; i++)
{
    if (array[i] > maxValue)
    {
        maxValue = array[i];
    }
    else if (array[i] < minValue)
    {
        minValue = array[i];
    }
}
double result = maxValue - minValue;
Console.WriteLine($"Минимальное число:  {minValue}");
Console.WriteLine($"Максимальное число:  {maxValue}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:  {result}");