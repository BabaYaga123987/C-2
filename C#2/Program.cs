namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Год высокосный");
            }
            else
            {
                Console.WriteLine("Год не высокосный");
            }



            Console.WriteLine("Введите первое целое число");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье целое число");
            int thirdNumber = int.Parse(Console.ReadLine());

            int positiveCounter = 0;
            int negativeCounter = 0;
            if (firstNumber > 0) positiveCounter++;
            else if (firstNumber < 0) negativeCounter++;
            if (secondNumber > 0) positiveCounter++;
            else if (secondNumber < 0) negativeCounter++;
            if (thirdNumber > 0) positiveCounter++;
            else if (thirdNumber < 0) negativeCounter++;

            Console.WriteLine($"Количество положительных чисел: {positiveCounter}");
            Console.WriteLine($"Количество отрицательных чисел: {negativeCounter}");

        }
    }
}
