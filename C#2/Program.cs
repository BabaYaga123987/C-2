using System;
using System.Collections.Generic;
using System.Text;

namespace C_2
{
    internal class Program
    {
        static readonly Dictionary<char, int> AlphabetToIndex2 = new Dictionary<char, int>() // выводя словари на уровень класса,
                                                                                          // мы можем использовать их в любом методе класса
    {
        {'A',0},{'B',1},{'C',2},{'D',3},{'E',4},
        {'F',5},{'G',6},{'H',7},{'I',8},{'J',9},
        {'K',10},{'L',11},{'M',12},{'N',13},{'O',14},
        {'P',15},{'Q',16},{'R',17},{'S',18},{'T',19},
        {'U',20},{'V',21},{'W',22},{'X',23},{'Y',24},
        {'Z',25}
    };
        static readonly Dictionary<int, char> IndexToAlphabet2 = new Dictionary<int, char>()
    {
        {0,'A'},{1,'B'},{2,'C'},{3,'D'},{4,'E'},
        {5,'F'},{6,'G'},{7,'H'},{8,'I'},{9,'J'},
        {10,'K'},{11,'L'},{12,'M'},{13,'N'},{14,'O'},
        {15,'P'},{16,'Q'},{17,'R'},{18,'S'},{19,'T'},
        {20,'U'},{21,'V'},{22,'W'},{23,'X'},{24,'Y'},
        {25,'Z'}
    };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text to encrypt:");
            string text = Console.ReadLine();
            Console.WriteLine("Create a code (from 1 to 25):");
            int code;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out code) || code < 1 || code > 25)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 25 to encrypt your message:");
                }
                else
                {
                    break;
                }
            }
            string encryptedText = Encode(text, code);
            Decode(encryptedText, code);
        }
        static string Encode(string text, int code)
        {
            string filteredtext = "";
            for (int i = 0; i < text.Length; i++) // фильтрация введенного текста
            {
                char c = char.ToUpper(text[i]);
                if (c >= 'A' && c <= 'Z')
                {
                    filteredtext += c;
                }
            }
            char[] textArray = filteredtext.ToCharArray(); // преобразование строки в массив символов
            string encryptedText = ""; // строка для хранения зашифрованного текста
            for (int i = 0; i < textArray.Length; i++)
            {
                int index = AlphabetToIndex2[textArray[i]]; // получение индекса символа из словаря
                int newIndex = (index + code) % 26; // сдвиг на n позиций
                char newChar = IndexToAlphabet2[newIndex]; // получение нового символа по новому индексу
                encryptedText += newChar;
            }
            Console.WriteLine("Encrypted text: " + encryptedText);
            return encryptedText;
        }
            static void Decode(string encryptedText, int code)
            {
                char[] textArray = encryptedText.ToCharArray();
                string decryptedText = "";
                for (int i = 0; i < textArray.Length; i++)
                {
                    int index = AlphabetToIndex2[textArray[i]];
                    int newIndex = (index - code + 26) % 26;
                    char newChar = IndexToAlphabet2[newIndex];
                    decryptedText += newChar;
                }
                Console.WriteLine("Decrypted text:" + decryptedText);

            }
        }
    }

