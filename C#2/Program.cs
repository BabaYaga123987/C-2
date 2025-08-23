using System.ComponentModel.Design;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите размер ставки (от 5$ до 100$): ");
            int betSize = int.Parse(Console.ReadLine());

            int randomNumber1 = Random.Shared.Next(1, 9);
            int randomNumber2 = Random.Shared.Next(1, 9);
            int randomNumber3 = Random.Shared.Next(1, 9);

            double coefficient = 0;
            if (randomNumber1 == randomNumber2 && randomNumber2 == randomNumber3 && randomNumber1 != 7)
            {
                coefficient = randomNumber1 * 15;
            }
            else if (randomNumber1 == randomNumber2 && randomNumber2 == randomNumber3 && randomNumber1 == 7)
            {
                coefficient = 150 * 1.5;
            }
            else if (randomNumber1 == randomNumber2 && randomNumber2 != randomNumber3 && randomNumber1 != 7)
            {
                coefficient = randomNumber1 * 1.25;
            }
            else if (randomNumber1 == randomNumber2 && randomNumber2 != randomNumber3 && randomNumber1 == 7)
            {
                coefficient = 15 * 1.25;
            }
            else if (randomNumber1 != randomNumber2 && randomNumber1 != 7 && randomNumber1 != 9
                && randomNumber3 != 7 && randomNumber3 != 9) 
            {
                coefficient = 0;
            } 
            else if (randomNumber1 != randomNumber2 && randomNumber1 == 7 && randomNumber3 != 7 && randomNumber3 != 9 ||
                randomNumber1 != randomNumber2 && randomNumber1 != 7
                && randomNumber1 != 9 && randomNumber3 == 7)
            {
                coefficient = 1.6;
            }
            else if (randomNumber1 != randomNumber2 && randomNumber1 == 9 && randomNumber3 != 7 && randomNumber3 != 9 ||
               randomNumber1 != randomNumber2 && randomNumber1 != 7
                && randomNumber1 != 9 && randomNumber3 == 9 )
            {
                coefficient = 1.35;
            }
            else if (randomNumber1 != randomNumber2 && randomNumber1 == 7 && randomNumber3 == 7)
            {
                coefficient = 2 * 1.6;
            }
            else if (randomNumber1 != randomNumber2 && randomNumber1 == 9 && randomNumber3 == 9)
            {
                coefficient = 2 * 1.35;
            }
            else if (randomNumber1 != randomNumber2 && randomNumber1 == 7 && randomNumber3 == 9
                || randomNumber1 == 9 && randomNumber3 == 7 && randomNumber1 != randomNumber2)
            {
                coefficient = 1.6 + 1.35;
            }
            



            double win = betSize * coefficient;
            if (betSize < 5 || betSize > 100)
            {
                Console.WriteLine("Ошибка: ставка должна быть от 5$ до 100$.");
            }

            else if (win > 0 && coefficient != 150 * 1.5)
            {
                Console.WriteLine($"Выпали числа: {randomNumber1} {randomNumber2} {randomNumber3}. Ваш выиграш: {win}$");
            }
            else if (coefficient == 150 * 1.5)
            {
                Console.WriteLine($"Джекпот!!! Выпали числа: {randomNumber1} {randomNumber2} {randomNumber3}. Ваш выиграш: {win}$");
            }
            else if (coefficient == 0)
            {
                Console.WriteLine($"Выпали числа: {randomNumber1} {randomNumber2} {randomNumber3}. Вы проиграли.");
            }

            // Придумать код, в котором используются не 3 числа рандомных, а одно трехзначное число от 100 до 999. Возможно, так будет работать лучше и легче.

        }
    }
}
