// Задача №1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Вариант №1. При помощи формулы
/*
 double DegreeNumber (double x, double y)  // int x - число; int y- степень
            {

                double a = Math.Pow(x, y);   // возводим в степень при помощи формулы
                return a;

            }

            Console.WriteLine("Введите число: ");
            double digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите в какую степень будем возводить: ");
            double number = Convert.ToInt32(Console.ReadLine());
            double resultat = DegreeNumber(digit, number);
            Console.WriteLine($"Ответ: {resultat}");
*/
// Вариант №2. через цикл for
/*
int DegreeNumber(int x, int y) 
            {

                int result = 1;
                for (int i = 1; i <= y; i++) // при помощи цикла for возводим число в степень.
                {
                    result = result * x;
                }
                return result;
            }

            Console.WriteLine("Введите число: ");
            int digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите в какую степень будем возводить: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int resultat = DegreeNumber(digit, number);
            Console.WriteLine($"Ответ: {resultat}");
        
*/
// Вариант №3. через цикл while
/*
 int DegreeNumber(int x, int y)
            {
                int i = 1;
                int result = 1;
                while (i <= y)
                {
                    result = result * x;
                    i++;
                }
                return result;
            }

            Console.WriteLine("Введите число: ");
            int digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите в какую степень будем возводить: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int resultat = DegreeNumber(digit, number);
            Console.WriteLine($"Ответ: {resultat}");
*/
// Задача №2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Вариант №1. при помощи цикла for
/*
int Count(int number)
            {
                int size = 0;
                int score = 0;
                int counter = Convert.ToString(number).Length;

                for (int i = 0; i < counter; i++)
                {
                    score = number - number % 10;
                    size = size + (number - score);
                    number = number / 10;
                }
                return size;
            }

            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = Count(num);
            Console.WriteLine("Сумма цифр в числе = " +sum);
    */
// Вариант №2. через цикл while
/*
int Count(int number)
            {
                int size = 0;
                int score = 0;
                int counter = Convert.ToString(number).Length;
                int i = 0;
                while (i < counter)
                {
                    score = number - number % 10;
                    size = size + (number - score);
                    number = number / 10;
                    i++;
                }
                return size;
            }

            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = Count(num);
            Console.WriteLine("Сумма цифр в числе = " +sum);
*/

// Задача №3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
            int[] intArray1 = new int[8]; 
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Введите " + (i + 1) + "-й элемент массива: ");
                intArray1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Получившийся массив выводим на экран:");
            for (int i = 0; i < 8; i++)
                Console.Write(intArray1[i] + " ");
            Console.WriteLine();
        