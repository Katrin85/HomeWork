/*
// Задача №1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] Random2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] =Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(),1);
    return newArray;
}

void Show2dArray(double[,] myarray)
{
    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        for (int j = 0; j < myarray.GetLength(1); j++)
        {
            Console.Write(myarray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Программа задает двумерный массив, заполненный случайными вещественными числами.");

Console.Write("Введиче число строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введиче число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное возвожное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное возвожное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = Random2dArray(m, n, min, max);
Show2dArray(array);
*/

// Задача №2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

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
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введиче число строк: ");
int m = Convert.ToInt16(Console.ReadLine());

Console.Write("Введиче число столбцов: ");
int n = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите минимальное возвожное значение: ");
int min = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите максимальное возвожное значение: ");
int max = Convert.ToInt16(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
