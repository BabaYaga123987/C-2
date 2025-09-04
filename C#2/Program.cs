using System.ComponentModel.Design;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер ставки (от 5$ до 100$): ");



            if (!int.TryParse(Console.ReadLine(), out int betSize))
            {
                Console.WriteLine("Ошибка: введите корректное число.");
            }
            else if (betSize < 5 || betSize > 100)
            {
                Console.WriteLine("Ошибка: ставка должна быть от 5$ до 100$.");
            }


            int randomNumber1 = Random.Shared.Next(1, 10); 
            int randomNumber2 = Random.Shared.Next(1, 10);
            int randomNumber3 = Random.Shared.Next(1, 10);



            double coefficient = 0;

            if (randomNumber1 != randomNumber2 && randomNumber1 == 7)
            {
                coefficient += 1.6;
            }
            if (randomNumber1 != randomNumber2 && randomNumber2 == 7)
            {
                coefficient += 1.6;
            }
            if (randomNumber1 != randomNumber2 && randomNumber3 == 7)
            {
                coefficient += 1.6;
            }
            if (randomNumber1 != randomNumber2 && randomNumber1 == 9)
            {
                coefficient += 1.35;
            }
            if (randomNumber1 != randomNumber2 && randomNumber2 == 9)
            {
                coefficient += 1.35;
            }
            if (randomNumber1 != randomNumber2 && randomNumber3 == 9)
            {
                coefficient += 1.35; 
            } 
            if (randomNumber1 == randomNumber2 && randomNumber2 == randomNumber3 && randomNumber1 != 7) // Условие 3 одинаковых чисел, кроме 7
            {
                coefficient = randomNumber1 * 15;
            }
            else if (randomNumber1 == randomNumber2 && randomNumber2 == randomNumber3 && randomNumber1 == 7) // Условие Джекпота
            {
                coefficient = 150 * 1.5;
            }
            else if (randomNumber1 == randomNumber2 && randomNumber1 == 7 && randomNumber2 != randomNumber3 && randomNumber3 == 9)
            // Условие мини Джекпота с 9 на конце
            {
                coefficient = 15 * 1.25 + 1.35;
            }
            else if (randomNumber1 == randomNumber2 && randomNumber2 != randomNumber3 && randomNumber1 != 7 && randomNumber3 == 9)
            // Условие 2 одинаковых чисел и 9 на конце
            {
                coefficient = randomNumber1 * 1.25 + 1.35;
            }
            else if (randomNumber1 == randomNumber2 && randomNumber2 != randomNumber3 && randomNumber1 != 7 && randomNumber3 == 7)
            //Условие 2 одинаковых чисел и 7 на конце
            {
                coefficient = randomNumber1 * 1.25 + 1.6;
            }
            else if (randomNumber1 == randomNumber2 && randomNumber2 != randomNumber3 && randomNumber1 != 7 && randomNumber3 != 9 && randomNumber3 != 7)
            // Условие 2 одинаковых чисел
            {
                coefficient = randomNumber1 * 1.25;
            }
            else if (randomNumber1 == randomNumber2 && randomNumber2 != randomNumber3 && randomNumber1 == 7 && randomNumber3 != 9)
            // Условие мини Джекпота
            {
                coefficient = 15 * 1.25;
            }
            else if (randomNumber1 == randomNumber2 && randomNumber2 != randomNumber3 && randomNumber1 == 7 && randomNumber3 == 9)
            // Условие мини Джекпота с 9 на конце
            {
                coefficient = 15 * 1.25 + 1.35;
            }
            else if (randomNumber1 != randomNumber2 && randomNumber1 != 7 && randomNumber1 != 9
                && randomNumber3 != 7 && randomNumber3 != 9 && randomNumber2 != 7 && randomNumber2 != 9) // Условие проигрыша
            {
                coefficient = 0;
            }
           



                double win = betSize * coefficient;
            if (win > 0 && coefficient != 150 * 1.5 && betSize >= 5 && betSize <= 100)
            {
                Console.WriteLine($"Выпали числа: {randomNumber1} {randomNumber2} {randomNumber3}. Ваш выиграш: {win}$");
            }
            else if (coefficient == 150 * 1.5 && betSize >= 5 && betSize <= 100)
            {
                Console.WriteLine($"Джекпот!!! Выпали числа: {randomNumber1} {randomNumber2} {randomNumber3}. Ваш выиграш: {win}$");
            }
            else if (coefficient == 0 && betSize >= 5 && betSize <= 100)
            {
                Console.WriteLine($"Выпали числа: {randomNumber1} {randomNumber2} {randomNumber3}. Вы проиграли.");
            }


        }
    }
}
