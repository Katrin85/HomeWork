// Задача №1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Вариант №1.
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
// Вариант №2ю
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
// Задача №2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
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



// Задача №3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]