Console.Clear();
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

/*
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
*/

/*
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)


int[,,] RandomArray3D(int[,,] array3D)
{
    int[] vector = new int[array3D.GetLength(0) *  // Формируем временный массив векторного типа.В него
                           array3D.GetLength(1) *  // помещаем количество всех ячеек из 3-хмерного массиве
                           array3D.GetLength(2)]; 
    int number;
    for (int i = 0; i < vector.GetLength(0); i++)  // по оси Х
    {
        vector[i] = new Random().Next(10, 100);  // Из расчёта, что максимальный
                                                 // размер массива 4х4х4 = 56. (5х5х5 = 125  -
                                                 // не подходит, т.к. число уже трёзначное)
                                                 // Допустим, числа положительные
        number = vector[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)  // по оси Y
            {
                while (vector[i] == vector[j])
                {
                    vector[i] = new Random().Next(10, 100);
                    j = 0;
                    number = vector[i];
                }
                number = vector[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
       for (int y = 0; y < array3D.GetLength(1); y++)
           for (int z = 0; z < array3D.GetLength(2); z++)
           {
               array3D[x, y, z] = vector[count];
               count++;
           }
    return array3D;
}

void PrintArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) {" "} \t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


//--------------------------О С Н О В Н А Я       П Р О Г Р А М М А------------------------
Console.WriteLine("Программа создаёт трёххмерный массив с неповторяющимися двухзначными числами." +
                  "\r\n\tПострочно выводит массив, добавляя индексы каждого элемента.");
Console.WriteLine("Укажите размерность матрицы.");

Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 4): ");
int x = Convert.ToInt32(Console.ReadLine());
while (x <= 1 || x > 4)  // Условие "оптимального" заполнения числа ячеек по оси
{
    if (x <= 1)
    {
        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 4): ");
        x = Convert.ToInt32(Console.ReadLine());
    }
    if (x > 4)
    {
        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 4): ");
        x = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("Введите количество ячеек по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());
while (y <= 1 || y > 4)  // Условие "оптимального" заполнения числа ячеек по оси 
{
    if (y <= 1)
    {
        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Y (желательно в пределах от 2 до 4): ");
        y = Convert.ToInt32(Console.ReadLine());
    }
    if (y > 4)
    {
        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Y (желательно в пределах от 2 до 4): ");
        y = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("Введите количество ячеек по оси Z: ");
int z = Convert.ToInt32(Console.ReadLine());
while (z <= 1 || z > 4)  // Условие "оптимального" заполнения числа ячеек по оси
{
    if (z <= 1)
    {
        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Z (желательно в пределах от 2 до 4): ");
        z = Convert.ToInt32(Console.ReadLine());
    }
    if (z > 4)
    {
        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Z (желательно в пределах от 2 до 4): ");
        z = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine();
int[,,] array3D = new int[x,y,z];
int[,,] randomArray3d = RandomArray3D(array3D);
PrintArray3D(randomArray3d);
*/
/*
//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] Array2D (int numXY)
{
    int[,] array2D = new int[numXY, numXY];  // Определяем количество сторон
    int numCell = 1;                         // Переменная, которая заполняет элемент матрицы
    int i = 0;
    int j = 0;

    while (numCell <= array2D.GetLength(0) * array2D.GetLength(1))
    {
        array2D[i, j] = numCell;
        numCell++;
        if (i + j < array2D.GetLength(1) - 1 && i <= j + 1)  // Заполняем вниз
            j++;
        else if (i + j >= array2D.GetLength(0) - 1 && i < j)  // Заполняем вправо
            i++;
        else if (i + j > array2D.GetLength(1) - 1 && i >= j)  // Заполняем вверх
            j--;
        else  // Заполняем влево
            i--;
    }
    return array2D;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write(array[i, j] + "\t");
            else Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


////--------------------------О С Н О В Н А Я       П Р О Г Р А М М А------------------------
Console.WriteLine("Программа, которая заполнит спирально квадратный массив со сторонами от 2 до 10 (допустим, 4 х 4).");

Console.Write("Введите количество ячеек по осям Х и Y: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n <= 1 || n > 10)  // Условие "оптимального" заполнения числа ячеек по оси
{
    if (n <= 1)
    {
        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 10): ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    if (n > 10)
    {
        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 10): ");
        n = Convert.ToInt32(Console.ReadLine());
    }
}


int[,] array2D = Array2D(n);
PrintArray2D(array2D);
*/