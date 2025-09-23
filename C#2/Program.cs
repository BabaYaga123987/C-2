using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.WriteLine("Задание 1:");
            int number;
            while(true)
            {
                Console.Write("Введите целое четырехзначное число: ");
                if (!int.TryParse (Console.ReadLine(), out number) || number < 1000 || number > 9999)
                {
                    Console.WriteLine("Ошибка. Число не четырехзначное или не целое.");
                }
                else
                {
                    break;
                }
            }
            int count = 0;
            for (int i = number; i > 0; i /= 10)
            {
                if ((i % 10) % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество четных цифр в числе {number} равно: {count}");

            // task 2
            ulong sum = 0;
            int a;
            int b;
            Console.WriteLine("Введите число а: ");
            while (true)
            if (!int.TryParse((Console.ReadLine()), out a))
            {
                Console.WriteLine("Неккоректный ввод: введите целое число а");
            }
            else
            {
                break;
            }            
            Console.WriteLine("Введите число b: ");
            while (true)
            {
                if (!int.TryParse((Console.ReadLine()), out b) || a > b)
                {
                    Console.WriteLine("Неккоректный ввод: введите целое число b. Также b должно быть больше a.");
                }
                else
                {
                    break;
                }
            }
            for (int i = a; i <= b; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += (ulong)(i * i);
                    }
                }
            Console.WriteLine($"Сумма квадратов целых нечетных чисел от a до b равна: {sum}");

            // task 3
            Console.WriteLine("Введите пароль: "); //Пароль: 12345
            const int correctpassword = 12345;
            int password;
            int attempts = 5;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out password) && password == correctpassword)
                {
                    Console.WriteLine("Добро пожаловать!");
                    return;
                }
                else
                {
                    if (attempts > 1)
                    {
                        attempts--;
                        Console.WriteLine($"Ошибка: пароль неверный. Осталось попыток: {attempts}");
                    }
                    else
                    {
                        Console.WriteLine("Достигнут лимит попыток");
                        return;
                    }
                }
            }

            
        }
    }
}
        
    


