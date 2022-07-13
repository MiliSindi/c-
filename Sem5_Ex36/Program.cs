// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] newArray = new int[10]; 
FillArray(newArray);
Console.WriteLine($"Массив:[{String.Join(",", newArray)}]");

int[] FillArray(int[] size)
{
    for (int i = 0; i < size.Length; i++)
    {
        size[i] = new Random().Next(-100,100);
    }
    return size;
}

void SumNumbersOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 1) sum += array[i] ;
    }
    Console.WriteLine(sum);
}
SumNumbersOddPosition(newArray);