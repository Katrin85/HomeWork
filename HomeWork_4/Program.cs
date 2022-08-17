// Задача №1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
 double DegreeNumber (double x, double y)
            {

                double a = Math.Pow(x, y);
                return a;

            }

            Console.WriteLine("Введите число: ");
            double digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите в какую степень будем возводить: ");
            double number = Convert.ToInt32(Console.ReadLine());
            double resultat = DegreeNumber(digit, number);
            Console.WriteLine($"Ответ: {resultat}");
// Задача №2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача №3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]