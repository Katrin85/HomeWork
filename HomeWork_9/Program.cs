Console.Clear();
/*
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Программа выдает все натуральные числа в промежутке от M до N");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

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
NaturalNumbers(n, m);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.WriteLine("Программа находит сумму натуральных элеметнов в промежутке от M до N");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
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
*/
/*
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Программа вычисляет функции Аккермана. Даны два неотрицательных числа M и N");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermanFunction (int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermanFunction(m - 1, 1);
    else
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
AckermanFunction(m, n);
int Ack = AckermanFunction(m, n);
Console.WriteLine($"Функция Аккермана = {Ack} ");
*/