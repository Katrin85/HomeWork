


static void SecondMethod(int inputUserNum)
        {
            Console.WriteLine("Решение 2-м способом");
            int a = inputUserNum;
            if (a < 100)
                Console.WriteLine($"     В числе {a} нет третьей цифры");
            else
            {
                while (a>=1000)
                {
                    a = a / 10;
                }    
                a = a % 10;
                Console.WriteLine("     Третья цифра числа " + inputUserNum + " является " + a);
            }
        }