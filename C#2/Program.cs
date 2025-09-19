namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
               Console.WriteLine("Задача 1:");
               int[,] matrix = new int[3, 5];
               Console.WriteLine("Введите элементы матрицы:"); // Заполнение матрицы пользователем
               for (int i = 0; i < matrix.GetLength(0); i++)
               {
                   for (int j = 0; j < matrix.GetLength(1); j++)
                   {
                       while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                       {
                           Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                       }
                   }
               }
               Console.WriteLine("Визуализация матрицы:");
               for (int i = 0; i < matrix.GetLength(0); i++)
               {
                   for (int j = 0; j < matrix.GetLength(1); j++)
                   {
                       Console.Write($"{matrix[i, j]}\t");
                   }
                   Console.WriteLine();
               }
                   int sum = 0;
               for (int i = 1; i == 1 || i == 2; i++) // Вычисление суммы элементов 2 и 3 строк матрицы
               {
                   for (int j = 0; j < matrix.GetLength(1); j++)
                   {
                       sum += matrix[i, j];
                   }
               }
               Console.WriteLine($"Сумма элементов 2 и 3 строк матрицы равна: {sum}");
               //task 2
               Console.WriteLine("Задача 2:");
               int[,] matrix2 = new int[4, 4];
               for (int i = 0; i < matrix2.GetLength(0); i++) // Заполнение матрицы случайными числами от 10 до 100
               {
                   for (int j = 0; j < matrix2.GetLength(1); j++)
                   {
                       matrix2[i, j] = Random.Shared.Next(10, 101);
                   }
               }
               Console.WriteLine($"Элементы матрицы равны: "); // Выведение элементов матрицы
               for (int i = 0; i < matrix2.GetLength(0); i++)
               {
                   for (int j = 0; j < matrix2.GetLength(1); j++)
                   {
                       Console.Write($"{matrix2[i, j]}\t");
                   }
                   Console.WriteLine();
               }
               int[] arraysumline = new int[matrix2.GetLength(0)]; // Создание массива для хранения суммы каждой строки
               for (int i = 0; i < matrix2.GetLength(0); i++)
               {
                   for (int j = 0; j < matrix2.GetLength(1); j++)
                   {
                       arraysumline[i] += matrix2[i, j];
                   }
               }
               int maxValue = arraysumline[0];
               int maxIndex = 0;
               for (int i = 0; i < matrix2.GetLength(0); i++) // Поиск максимального значения в массиве сумм строк
               {
                       if (arraysumline[i] > maxValue)
                       {
                           maxValue = arraysumline[i];
                           maxIndex = i;
                       }
               }
               Console.WriteLine($"Наибольшая сумма строки матрицы равна: {maxValue}. Номер строки: {maxIndex + 1 }."); 
            //task3
            Console.WriteLine("Задача 3:");
            int[,] matrix3 = new int[4, 4];
            for (int i = 0; i < matrix3.GetLength(0); i++) // Заполнение матрицы случайными числами от -100 до 100
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    matrix3[i, j] = Random.Shared.Next(-100, 101);
                }
            }
            Console.WriteLine("Элементы матрицы равны: ");
            for (int i = 0; i < matrix3.GetLength(0); i++) // Выведение элементов матрицы
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    Console.Write($"{matrix3[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Положительные элементы главной диагонали матрицы: "); // Выведение положительных элементов главной
                                                                                     // диагонали матрицы
            for (int i = 0; i < matrix3.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    if (i == j && matrix3[i, j] >= 0)
                    {
                        Console.Write($"{matrix3[i, j]}\t");
                    }
                    
                        
                }
                
            }
            Console.WriteLine("\nПоложительные элементы побочной диагонали матрицы: "); // Выведение положительных элементов побочной
            for (int i = 0; i < matrix3.GetLength(0); i++)                              // диагонали матрицы
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    if (i + j == matrix3.GetLength(0) - 1 && matrix3[i, j] >= 0) // Формула для побочной диагонали. Отнимается единица,
                                                                                 // т.к. matrix3.GetLength(0) считает индексацию от 1,
                                                                                 // а сама матрица имеет индексацию от 0.
                    {
                        Console.Write($"{matrix3[i, j]}\t");
                    }
                }
            }
        }
    }
}
