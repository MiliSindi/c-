// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] newArray = new int[10];  
FillArray(newArray);
Console.WriteLine($"Массив:[{String.Join(",", newArray)}]");

int[] FillArray(int[] size)
{
     
    for (int i = 0; i < size.Length; i++)
    {
        size[i] = new Random().Next(100,1000);
    }
    return size;
}

void CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (newArray [i] % 2 == 0) count ++ ;
    }
    Console.WriteLine(count);
}
CountEvenNumbers (newArray);
