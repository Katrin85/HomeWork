/*
//Задача №1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
int max = numA;
int min = numA;
if (numA > max) max = numA;
if (numB > max) max = numB;
if (numA < min) min = numA;
if (numB < min) min = numB;
Console.WriteLine ($"{max} - большее число");
Console.WriteLine ($"{min} - меньшее число");
*/
/*
//Задача №2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write ("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine($"Максимальное число = {max}");
*/
/*
//Задача №3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 1)
{
   Console.WriteLine ($"Число {number} - нечетное");
}
else 
{
    Console.WriteLine ($"Число {number} - четное");
}
*/