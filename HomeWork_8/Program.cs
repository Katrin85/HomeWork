/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // метод заполняет массив случайными числами в заданном диапозоне
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array) // метод вывода на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}
int[,] SortingArray (int [,] sortArray) // метод сортировки
{
    for (int j = 0; j < sortArray.GetLength(1); j++)
    {
        for (int i = 0; i < sortArray.GetLength(0); i++)
            for (int k= 0; k < sortArray.GetLength(1) - 1; k++)
                if (sortArray[i,k] < sortArray[i,k + 1])
                {
                    int temp = sortArray[i, k + 1];
                    sortArray[i, k + 1] = sortArray[i, k];
                    sortArray[i, k] = temp;
                }
    }
    return sortArray;
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

Console.WriteLine();
Console.WriteLine("Программа отсортировала этот массив. Выводим его на экран:");

int[,] newArray = SortingArray(myArray);
Show2dArray(newArray);
*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // метод заполняет массив случайными числами в заданном диапозоне
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array) // метод вывода на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}

void sumStringArray (int[,] sumArray)
{
    int index = 0;
    int sum = 0;
    int minsum = 0;
    for(int i = 0; i < sumArray.GetLength(0); i++)
    {
        for (int j = 0; j < sumArray.GetLength(1); j++)
        {
            sum = sum + sumArray[i, j];
            if (sum < sumArray[i,j]) sum = minsum;
            index = i;  
        }
        
    }
    Console.Write($"Строка с минимальной суммой {sum} элементов равна {index + 1}. ");
    
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

sumStringArray(myArray);
