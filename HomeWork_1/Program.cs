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

















//Задача №4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i = i + 1)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    } 
}    