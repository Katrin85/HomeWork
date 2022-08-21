/*
// Задача №1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] InputArray(int size)
{
    int[] massive = new int[size];
    for (int i = 0; i < size; i++)
    {
        Random random = new Random();
        massive[i] = random.Next(100, 1000);
    }
    return massive;
}

int EvenCount(int[] masSort)
{
    int[] massive = masSort;
    int count = 0;
    foreach (int element in massive)
    {
        if (element % 2 == 0)
            count++;
    }
    return count;
}

Console.WriteLine("Программа автоматически заполняет массив случайными числами от 100 до 999.") 
Console.WriteLine("Подсчитывает количество четных чисел в массиве");
Console.Write("Введите размерность массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] mas = InputArray(a);  // заполняем массив mas случайными числами от 100 до 999
Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i < mas.Length; i++)
    Console.Write(mas[i] + " ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine("Количество чётных чиcел в массиве: " + EvenCount(mas) + " шт.");
*/



// Задача №2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] InputArray(int size)
{
    int[] massive = new int[size];  // Метод заполнения случайными числами (тип int).
                                    // На входе указываем размерность,
                                    // На выходе сам массив
    Random randomNum = new Random();  // Рандомизатор
    for (int i = 0; i < size; i++)
        massive[i] = randomNum.Next(-1000, 1001); // я решила сделать диапозон от -1000 до 1000. 
    return massive;
}
int SumOddPositions(int[] massive)  // Метод выборки нечётных элементов и нахождения их суммы
                                    // На входе массив, на выходе - сумма
{
    int[] mass = massive;
    int sum = 0;
    Console.Write("Выборка элементов массива на нечётных позициях: ");
    for (int i = 1; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
        sum = sum + mass[i];
        i++;
    }
    Console.WriteLine();
    return sum;
}

Console.WriteLine("Программа автоматически заполняет массив из 10 элементов " +
                  "случайными числами от -1000 до 1000. " +
                  "\r\nНайдём сумму элементов, стоящих на нечётных позициях");
Console.Write("Введите размерность массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = InputArray(a);
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Получился массив: ");
for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + SumOddPositions(array));
Console.ForegroundColor = ConsoleColor.White;
*/

/*
// Задача №3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int size) // метод. На входе размерность массива, на выходе заполненный массив
{
    double [] newArray = new double[size];  // Создаем массив
    for (int i = 0; i < size; i++)
        {
            Console.Write("Введите " + (i + 1) + "-й элемент массива: ");
            newArray[i] = double.Parse(Console.ReadLine());
        }
    return newArray;  // возвращаем массив
}
double SumElement(double[] massive)  // метод. На входе массив, на выходе разность mах и min чисел 
{
    double[] mass = massive;
    double minValue = mass[0];
    double maxValue = mass[0];
    double dif = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] < minValue)
            minValue = mass[i];
    }

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > maxValue)
            maxValue = mass[i];
    }
    dif = maxValue - minValue;
    return dif;
}

Console.Write("Введите размерность массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(a);
double difference = SumElement(array);
Console.WriteLine("Разность максимального и минимального элементов составит: " + difference);
*/