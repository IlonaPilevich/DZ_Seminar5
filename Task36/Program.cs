// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях
// [3,7,23,12] - 19, [-4,-6,89,6] - 0.

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];   
    for (int i = 0; i < result.Length; i++)  
    {
       result[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return result;
}
int[] array = GetArray(5, 1, 10);
Console.WriteLine($"Массив: [{string.Join(";", array)}]");
int size = array.Length;
int sumArray = 0;
for (int i = 1; i < size; i+=2)
{
    sumArray += array[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях:  {sumArray}");