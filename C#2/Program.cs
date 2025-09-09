using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.WriteLine("Введите целое четырехзначное число:");
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    number = Math.Abs(number); 

                    if (number >= 1000 && number <= 9999) 
                    {
                        int amount = 0;
                        foreach (char c in number.ToString())
                        {
                            int digit = c - '0'; // перевод символа в цифру
                            if (digit % 2 == 0)
                            {
                                amount++;
                            }
                        }
                        Console.WriteLine($"Количество четных цифр: {amount}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число из 4 цифр:");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число из 4 цифр:");
                }
            }

            /* Примечание к упражнению 1. foreach — это цикл, который перебирает все элементы какой-то коллекции 
             (массива, списка, строки и т. д.), по одному за раз. char c — это переменная, которая на каждой итерации 
             принимает один символ строки. input — указывает, что мы перебираем строку input. Цикл сам знает, сколько символов, 
             и закончит работу, когда они закончатся. 

             */

            // task 2
            ulong sum = 0;
            int a;
            int b;
            Console.WriteLine("Введите число а: ");
            string string1 = Console.ReadLine();
            while (true)
            if (!int.TryParse(string1, out a))
            {
                Console.WriteLine("Неккоректный ввод: введите целое число а");
                string1 = Console.ReadLine();
            }
            else
            {
                break;
            }            
            Console.WriteLine("Введите число b: ");
            string string2 = Console.ReadLine();
            while (true)
            {
                if (!int.TryParse(string2, out b) || a > b)
                {
                    Console.WriteLine("Неккоректный ввод: введите целое число b. Также b должно быть больше a.");
                    string2 = Console.ReadLine();
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
                string input1 = Console.ReadLine();
                if (int.TryParse(input1, out password) && password == correctpassword)
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

            


            










                       /* attempts++;
                        if (attempts != 5)
                        {
                            Console.WriteLine("Пароль неверный. Изначально вы можете повторить ввод до 5 раз.");
                            continue;
                        }
                        else
                        {
                            break;
                        } */
                    }
                }
            }
        
    


