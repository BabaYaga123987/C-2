using System.Collections.Generic;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   // task 1
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Random.Shared.Next(7, 15);
                if (numbers[i] > 10)
                {
                    numbers[i] = numbers[i] - 10;
                }
                Console.Write($"{numbers[i]} ");
            }

            // task 2
               int[] numbers1 = Array.ConvertAll(new int[20], 
                 _ => Random.Shared.Next(10, 31));

               int[] numbers2 = Array.ConvertAll(new int[20],
                 _ => Random.Shared.Next(10, 31));  
                      
              int[] numbers3 = new int[20];
            Console.Write("\nСуммы соответствующих элементов двух массивов: ");
            for (int i = 0; i < numbers3.Length; i++)
            {
                 numbers3[i] = numbers1[i] + numbers2[i];
                 Console.Write($"{numbers3[i]} ");
            }
            double average = 0;
            for (int i = 0; i < numbers3.Length; i++)
            {
             average += (double)numbers3[i] / 2;
            }
            Console.WriteLine($"\nСреднее арифметическое элементов третьего массива: {average}");

            int MinValue = numbers3[0];
            int MaxValue = numbers3[0];
            for (int i = 0; i < numbers3.Length; i++)
            {
                if (numbers3[i] < MinValue)
                {
                    MinValue = numbers3[i];
                }
                else if (numbers3[i] > MaxValue)
                {
                    MaxValue = numbers3[i];
                }
            }
                Console.WriteLine($"Минимальное значение третьего массива: {MinValue}");
                Console.WriteLine($"Максимальное значение третьего массива: {MaxValue}");

                // task 3 
                int[] numbers4 = Array.ConvertAll(new int[20],
                    _ => Random.Shared.Next(0, 51));
                Console.Write("Элементы неотсортированного четвертого массива: ");
                for (int i = 0; i < numbers4.Length; i++)
                {
                    Console.Write($"{numbers4[i]} ");
                }

                  for (int i = 0; i < numbers4.Length - 1; i++) // Bubble Sort Algorithm (по спаданию)
                  {
                      bool swapped = false;
                      for (int j = 0; j < numbers4.Length - i - 1; j++)
                      {
                          if (numbers4[j] < numbers4[j + 1])
                          {
                          int temp = numbers4[j];
                          numbers4[j] = numbers4[j + 1];
                          numbers4[j + 1] = temp;
                          swapped = true;
                          }
                      }
                      if (!swapped) break;
                  }

                  /*
                    for (int i = 0; i < numbers4.Length - 1; i++) // Пример Bubble Sort Algorithm (по возростанию)
                  {
                      bool swapped = false;
                      for (int j = 0; j < numbers4.Length - i - 1; j++)
                      {
                          if (numbers4[j] > numbers4[j + 1])
                          {
                          int temp = numbers4[j];
                          numbers4[j] = numbers4[j + 1];
                          numbers4[j + 1] = temp;
                          swapped = true;
                          }
                      }
                      if (!swapped) break;
                  }
                  */

            Console.Write("\nЭлементы отсортированного четвертого массива: ");
            for (int i = 0; i < numbers4.Length; i++)
            {
            Console.Write($"{numbers4[i]} ");
            }




}

}
}

