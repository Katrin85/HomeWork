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
/*
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
void sumStringArray (int[,] sumArray)  // метод считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов
{
    int minSum = 0; // минимальная сумма
    int sumString = SumStringElements(sumArray, 0); // строка с минимальной суммой
    for (int i = 1; i < sumArray.GetLength(0); i++) // находит линию с минамальной суммой
    {
        int temp = SumStringElements(sumArray, i);
        if (sumString > temp)
        {
            sumString = temp;
            minSum = i;
        }
    }
    int SumStringElements(int[,] array, int i) // находим сумму элементов в каждой строке
    {
        int sumString = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
            sumString += array[i,j];
    return sumString;
    }
Console.WriteLine($"\n{minSum + 1} - строкa с наименьшей суммой ({sumString}) элементов ");
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
*/


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // метод заполняет массив случайными числами в заданном диапозоне
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
    return matrix;
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

int[,] ProductMatrices (int[,] matrixA, int[,] matrixB)
{
    int matrix1Rows = matrixA.GetLength(0);  
    int matrix1Cols = matrixA.GetLength(1);  
    int matrix2Rows = matrixB.GetLength(0);  
    int matrix2Cols = matrixB.GetLength(1);  
   
    int[,] product = new int[matrix1Rows, matrix2Cols];  // создаем пустую результирующую матрицу нужного размера
    for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++) // заполняем результирующую матрицу, цикл по каждому ряду первой матрицы
    {  
    for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++) // цикл по каждому столбцу второй матрицы 
        for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++)
        {  
            product[matrix1_row, matrix2_col] +=   
            matrixA[matrix1_row, matrix1_col] *   
            matrixB[matrix1_col, matrix2_col];  
        }  
    }  
    return product;
    
} 

Console.WriteLine("Программа, которая будет находить произведение двух матриц");

Console.Write("Введиче число строк первой матрицы: ");
int i1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введиче число столбцов первой матрицы: ");
int j1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введиче число строк второй матрицы: ");
int i2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введиче число столбцов второй матрицы: ");
int j2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное возвожное значение элементов матрицы: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное возвожное значение элементов матрицы: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = CreateRandom2dArray(i1, j1, min, max);
int[,] myArray2 = CreateRandom2dArray(i2, j2, min, max);
int[,] productMatrices = new int[i1, j2];  // Это переменная для 3-й матрицы
Show2dArray(myArray1);
Console.WriteLine();
Show2dArray(myArray2);
Console.WriteLine();

Console.WriteLine("Произведение матриц равно: ");

if (i1 != j2 && i2 != j1)
    Console.WriteLine("Матрицы не совместимы. Число столбцов первой матрицы должно быть равно числу строк второй матрицы");

else
{
    productMatrices = ProductMatrices(myArray1, myArray2);
    Show2dArray(productMatrices);
}