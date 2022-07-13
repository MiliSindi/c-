// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] array = { 15,270,30,-4,5,60,-70,48,19 };
Console.WriteLine(array);

double FindMax(double[] array)
{
    int i = 0;
    double max = array[i];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    Console.WriteLine($"max = {max}");
    return max;
}

double FindMin(double[] array)
{
    int index = 0;
    double min = array[index];
    for (index = 1; index < array.Length; index++)
    {
        if (array[index] < min) min = array[index];
    }
    Console.WriteLine($"min = {min}");
    return min;
}

double differenceMaxMin = FindMax(array) - FindMin(array);
Console.WriteLine(differenceMaxMin);
