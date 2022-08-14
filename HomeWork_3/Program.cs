/*
// Задача №1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
void Palindrome(string strPal)                             // Метод типа viod. Ничего не отдаёт. Просто выполняет код.
{
  if (strPal[0] == strPal[4] && strPal[1] == strPal[3])    //Условие. Сравниваем равны ли цифры (1 и 5, 2 и 4)
    Console.WriteLine($"Число  - явлется палиндромным");   // Если равны выводим на консоль, что число палидромное
    
  else
    Console.WriteLine($"Число  - не является палиндровным");  // Иначе - Не полидровное
}
Console.WriteLine("Ввeдите пятизначное число: ");             // Вводим то число, которое будем проверять на палидромность.
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
Palindrome(str);

*/
/*

// Задача №2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

double Length(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double len1 = Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2) + Math.Pow(Z2-Z1,2));  //  Вводим формулу нахождения координар двух точек и нахождения расстояния между ними в 3D.
    return len1;  
}

Console.Write ("Введите координату Х точки А ");
double xA = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите координату У точки А ");
double yA = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите координату Z точки А ");
double zA = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите координату Х точки В ");
double xB = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите координату У точки В ");
double yB = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите координату Z точки B ");
double zB = Convert.ToInt32 (Console.ReadLine());

double len = Length(xA, yA, xB, yB, zA, zB);
Console.WriteLine("Длина отрезка равна " + len);

*/
/*
// Задача №3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void QardN(int n)  // Метод типа viod. Ничего не отдаёт. Просто выполняет код.
{
    for (int i = 1; i <= n; i++)  // цикл for([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
    {
        System.Console.Write(i*i*i + " ");  // Ввыводим  балицу кубов.
    }
}
Console.Write ("Введите натуральное число: ");
int num = Convert.ToInt32 (Console.ReadLine());
Console.Write("КУб чисел от 1 до " + num + " равно: ");
QardN(num);

*/