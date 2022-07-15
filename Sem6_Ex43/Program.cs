// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] ConvertDataToIntArray()
{
    return Console.ReadLine()
        .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
        .Select(Double.Parse).ToArray();
} 

double[] CrossPoint(double[] firstArray, double[] secondArray)
{   
    double x = (firstArray[0] - secondArray[0]) / (secondArray[1] - firstArray[1]);
    double y = firstArray[1] * x + firstArray[0];
    double[] crossPoint = {x,y};  
    return crossPoint;     
}

void CheckTwoLine(double[] firstArray, double[] secondArray, double[] crossPoint)
{
    if(firstArray[0] == secondArray[0] && firstArray[1] == secondArray[1]) 
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if(firstArray[0] != secondArray[0] && firstArray[1] == secondArray[1])
    {
        Console.WriteLine("Прямые параллельны");
    }
    else if(firstArray[0] == secondArray[0] && firstArray[1] != secondArray[1])
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        Console.Write("Точка пересечения двух прямых: ");
        Console.WriteLine($"({crossPoint[0]};{crossPoint[1]})");
    }
}

Console.WriteLine("Введите координаты первой прямой b1 и k1 соответственно через пробел:");
double[] firstСoordinatesArray = ConvertDataToIntArray();
Console.WriteLine("Введите координаты второй прямой b2 и k2 соответственно через пробел:");
double[] secondCoorditatesArray = ConvertDataToIntArray();

double[] crossPoint = CrossPoint(firstСoordinatesArray, secondCoorditatesArray);
CheckTwoLine(firstСoordinatesArray, secondCoorditatesArray, crossPoint);
