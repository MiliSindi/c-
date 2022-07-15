// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите в строку несколько чисел через пробел:");
int[] ConvertDataToIntArray()
{
    return Console.ReadLine()
        .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
        .Select(Int32.Parse).ToArray();
} 

int[] numbersArray = ConvertDataToIntArray();

int numbersMoreZero = 0;
foreach (var numbers in numbersArray)
{
    if(numbers > 0)
    {
        numbersMoreZero++;
    }
}

Console.WriteLine(numbersMoreZero);
