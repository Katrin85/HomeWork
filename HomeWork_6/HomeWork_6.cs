// Задача №1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] CreateArray(int size) // метод. На входе размерность массива, на выходе заполненный массив
{
    int [] newArray = new int[size];  // Создаем массив
    for (int i = 0; i < size; i++)
        {
            Console.Write("Введите " + (i + 1) + "-й элемент массива: ");
            newArray[i] = Convert.ToInt32(Console.ReadLine());
        }
    return newArray;  // возвращаем массив
}

int РositivePositions(int[] massive)  // Метод выборки положительных элементов и подсчет их количества
{
    int[] mass = massive;
    int count = 0;
   
    for (int i = 0; i < massive.Length; i++)
        if(massive[i] > 0 ) count += 1; 
    return count;
}
Console.WriteLine("Пользователь вводит с клавиатуры M чисел в массив. Программа считает, сколько чисел больше 0 ввёл пользователь.");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Введите размерность массива: ");
Console.ForegroundColor = ConsoleColor.White;
int a = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(a);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Количество положительных элементов: " + РositivePositions(array));
Console.ForegroundColor = ConsoleColor.White;



// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void KoordinataDotA(double k1, double k2, double b1, double b2)
{
    double IntersectionX = 0;
    double IntersectionY = 0;
    double[] dotIntersection = new double[2]; // Массив из 2-х элементов - координаты точки пересечения (при наличии) прямых на плоскости
                                              // в виде A[0] - по оси Х, A[1] - по оси Y

    if (k1 / k2 == 1 && b1 / b2 == 1)
        Console.WriteLine("Прямые совпадают");
   
    
    else if (k1/k2 == 1 && b1/b2 != 1)
        Console.WriteLine("Прямые параллельны");
   
    else
    {
        IntersectionX = (b2 - b1) / (k1 - k2);
        IntersectionY = (k2 * b1 - k1 * b2) / (k2 - k1);
        Console.WriteLine("точка пересечения " + " (" + IntersectionX + " ;" + IntersectionY + ")");
    }
}

Console.WriteLine("Программа - определятор координаты точки пересечения (при наличии) прямых на плоскости \r\n" +
                  "Уравнения прямых выглядят следующим образом:\r\n" +
                  "\ty=k1*x + b1\r\n" +
                  "\ty=k2*x + b2");

Console.Write("Введите Значение к1: ");
double equationK1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Значение к2: ");
double equationK2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Значение b1: ");
double equationB1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Значение b2: ");
double equationB2 = Convert.ToDouble(Console.ReadLine());

KoordinataDotA(equationK1, equationK2, equationB1, equationB2);
*/