/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
double[] GenerateRandomArray(int length, int startPoint, int endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

double findSubtractionMaxMinElements(double[] array)
{
    int i = 0;
    double max = array[i];
    double min = array[i];
    for (i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        else
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
    } 
    double sub = max - min;
    return sub;
}
double[] array = GenerateRandomArray(6, 1, 10);
printArray(array);
double sub = findSubtractionMaxMinElements(array);
Console.WriteLine($"Разница между макс и мин элементами массива равна {sub}");
