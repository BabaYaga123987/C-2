using System;
using System.Linq;
using System.Text;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Введите текст: ");
             string text = Console.ReadLine();

             if (string.IsNullOrWhiteSpace(text))
             {
                 Console.WriteLine("Вы ничего не ввели");
             }
             else
             {
                 int count = 0;
                 bool inWord = false;

                 for (int i = 0; i < text.Length; i++)
                 {
                     if (!char.IsWhiteSpace(text[i]) && inWord == false)
                     {
                         count++;      // нашли начало слова
                         inWord = true;
                     }
                     else if (char.IsWhiteSpace(text[i]))
                     {
                         inWord = false; // слово закончилось
                     }
                 }
                 Console.WriteLine($"Количество слов равно {count}");
             }

             string reversed = new string(text.Reverse().ToArray()); // To array - преобразует в массив.
                                                                     // Reverse - переворачивает последовательность
             Console.WriteLine($"Перевернутая строка: {reversed}");

             string longestWord = ""; 
             int maxLength = 0;       
             string currentWord = ""; 
             for (int i = 0; i < text.Length; i++)
             {
                 if (!char.IsWhiteSpace(text[i])) // если не пробел, а символ, то есть часть слова
                 {
                     currentWord += text[i]; // добавляем символ к текущему слову
                 }
                 else
                 {

                     if (currentWord.Length > maxLength) // если текущее слово длиннее максимума
                     {
                         maxLength = currentWord.Length; // записываем новую максимальную длину
                         longestWord = currentWord; // обновляем самое длинное слово на текущее слово
                     }
                     currentWord = ""; // сбрасываем текущее слово для следующего слова
                 }
             }


             if (currentWord.Length > maxLength) // если текущее слово длиннее максимума (на случай, если строка не заканчивается пробелом)
                                                 // поскольку условие else не сработает, если строка не заканчивается пробелом,
                                                 // и это слово не будет проверено внутри цикла. Для этого случая
                                                 // добавляем проверку после цикла.
                                                 // Примечание: если строк несколько, и все последние слова в строках не заканчиваются пробелом,
                                                 // алгоритмы будуть работать корректно, так как \n - это тоже пробельный символ.
             {
                 longestWord = currentWord;
             }

             Console.WriteLine($"Самое длинное слово: {longestWord}");


             StringBuilder sb = new StringBuilder(); // преобразуем строку в StringBuilder для удобного добавления символов
             for (int i = 0; i < text.Length; i++)
             {
                 char c = char.ToLower(text[i]);
                 if (char.IsLetterOrDigit(c)) // если символ - буква или цифра
                 {   
                     sb.Append(c); // добавляем его в StringBuilder
                 }
             }
             string cleanText = sb.ToString(); // преобразуем StringBuilder обратно в строку
             string reversedClean = new string(cleanText.Reverse().ToArray());
             bool isPalindrome = cleanText == reversedClean;
             Console.WriteLine($"Палиндром: {isPalindrome}"); 
           
             
        }
    }
}
