/*
// Задача №1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int InputThreeDigitNumber (int number)
{
    int ten = number / 10;
    int des = ten % 10;
    return des;
}
Console.Write("Введите трехзначное число: ");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());
int newNumber = InputThreeDigitNumber(ThreeDigitNumber);
Console.WriteLine(newNumber);
*/
/*
// Задача №2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int InputNumber (int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    } 
    if (number < 100)
    {
        Console.WriteLine($"В числе {number} нет третьей цифры");
    } 
    else 
    {
       number = number % 10;
    }
   
    return number;
}
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int newNumber = InputNumber(Number);
Console.WriteLine($"Третье цифра числа {Number} - {newNumber}");
*/
// Задача №3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayWeek (int day) 
{
    if (day == 6 || day == 7)
       Console.WriteLine("Это выходной день");
       
    if (day >= 1 && day <= 5)
       Console.WriteLine("Это рабочий день, подожди немного и будет выходной.");
}
Console.WriteLine("Введиите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
DayWeek(day);