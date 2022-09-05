/*
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void NaturalNumbers (int n, int m)
{
    if(m != n)
    {
        if (n > m) 
        {
            NaturalNumbers (n - 1, m);
            Console.Write(n + " ");
        }
        else
        {
            NaturalNumbers(m - 1, n);
            Console.Write(m + " ");
        }
    } 
    else
    Console.Write(m + " ");
}
NaturalNumbers(1, 9);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите начальное число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int n = Convert.ToInt32(Console.ReadLine());

int number = m;
if (m > n) 
{
  m = n; 
  n = number;
}
void SumNaturalNumbers (int m, int n, int sum) // Метод нахождения суммы натуральных элементов в промежутке от M до N
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
        sum = sum + (m++);
        SumNaturalNumbers(m, n, sum);
}
SumNaturalNumbers(m, n, 0);