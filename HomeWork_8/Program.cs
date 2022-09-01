// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}
int[,] SortingArray (int [,]a, int min, int max)

{
    int temp;
    int maxI = 0;
    int minJ = 0;
    int maxJ = 0;
    int minI = 0;
    max = a[0,0];
    min = a[0,0];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            for(int k = 0; k < a.GetLength(1); k++)
            temp = a[i,j];
            a[i,j] = a[j, k];
            a[j, k] = temp;
        }
    }
    return a;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (max < a[i, j])
            {
                max = a[i, j];
                maxI = i;
                maxJ = j;
            }
            if (min > a[i, j])
            {
                min = a[i, j];
                minI = i;
                minJ = j;
            }
        }
        return a;
    }
}

Console.Write("Введиче число строк: ");
int i = Convert.ToInt16(Console.ReadLine());

Console.Write("Введиче число столбцов: ");
int j = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите минимальное возвожное значение: ");
int min = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите максимальное возвожное значение: ");
int max = Convert.ToInt16(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(i, j, min, max);
Show2dArray(myArray);

int[,] Array = SortingArray(a[,], min, max);
SortingArray(a);