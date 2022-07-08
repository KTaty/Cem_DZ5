/*Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] generateArray(int length, int startBorder, int endBorder)
{
    int[] resultArray = new int[length];
    for (var i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startBorder, endBorder + 1);
    }
    return resultArray;
}

int SumElemOddPosition (int[] array){
    int sum=0;
    for(var i=0; i<array.Length;i=i+2){
        sum+=array[i];
    }
    return sum;
}

void ShowArray(int[] arrayToShow)
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
int[] array = new int[length];
array = generateArray(length, 0, 100);
int sumElemOddPosition = SumElemOddPosition (array);
ShowArray(array);
Console.WriteLine($"Сумма чисел на нечетных позициях: {sumElemOddPosition}");