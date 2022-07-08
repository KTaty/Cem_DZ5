//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double[] GenerateArray(int length, int startBorder, int endBorder)
{
    double[] resultArray = new double[length];
    for (var i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startBorder, endBorder + 1);
    }
    return resultArray;
}

double GetDiffMaxMin(double[] array)
{
    double diff =0;
    double min = array[0], max = array[0];
    for (var i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    return diff = max - min;

}

void ShowArray(double[] arrayToShow)
{
    Console.Write("[");
    for (var i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i < arrayToShow.Length - 1)
        { Console.Write(", "); }
    }
    Console.WriteLine("]");
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
array = GenerateArray(length, 0, 100);
double diff = GetDiffMaxMin(array);
ShowArray(array);
Console.WriteLine($"Разница между max и min: {diff}");