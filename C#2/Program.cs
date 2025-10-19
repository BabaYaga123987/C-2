using System;
using System.Collections.Generic;
using System.Text;

namespace C_2
{
    internal class Program
    {
        
        
            static readonly Dictionary<char, int> AlphabetToIndex = new Dictionary<char, int>() // выводя словари на уровень класса,
                                                                                          // мы можем использовать их в любом методе класса
    {
        {'A',0},{'B',1},{'C',2},{'D',3},{'E',4},
        {'F',5},{'G',6},{'H',7},{'I',8},{'J',9},
        {'K',10},{'L',11},{'M',12},{'N',13},{'O',14},
        {'P',15},{'Q',16},{'R',17},{'S',18},{'T',19},
        {'U',20},{'V',21},{'W',22},{'X',23},{'Y',24},
        {'Z',25}
    };

            static readonly Dictionary<int, char> IndexToAlphabet = new Dictionary<int, char>()
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
                Console.WriteLine("Enter the text to encode:");
                string message = Console.ReadLine();

                Console.WriteLine("Create a keyword:");
                string keyword = Console.ReadLine();

                string encodedMessage = Encode(message, keyword);
                Decode(encodedMessage, keyword);
            }

            static string Encode(string message, string keyword)
            {
                string filteredMessage = "";
                for (int i = 0; i < message.Length; i++)
                {
                    char c = char.ToUpper(message[i]);
                    if (c >= 'A' && c <= 'Z')
                    {
                        filteredMessage += c;
                    }
                }

                keyword = keyword.ToUpper();

                int[] messageAlphabetValue = new int[filteredMessage.Length];
                int[] keywordAlphabetValue = new int[keyword.Length];
                int[] messageAndKeywordAlphabetValue = new int[filteredMessage.Length];
                char[] encodedMessageChar = new char[filteredMessage.Length];

                for (int i = 0; i < keyword.Length; i++)
                {
                    keywordAlphabetValue[i] = AlphabetToIndex[keyword[i]];
                }

                for (int i = 0; i < filteredMessage.Length; i++)
                {
                    messageAlphabetValue[i] = AlphabetToIndex[filteredMessage[i]];
                }

                for (int i = 0; i < filteredMessage.Length; i++)
                {
                    int sum = messageAlphabetValue[i] + keywordAlphabetValue[i % keyword.Length];
                    messageAndKeywordAlphabetValue[i] = sum % 26;
                }

                for (int i = 0; i < filteredMessage.Length; i++)
                {
                    encodedMessageChar[i] = IndexToAlphabet[messageAndKeywordAlphabetValue[i]];
                }

                string encodedMessage = new string(encodedMessageChar);

                Console.WriteLine($"Encoded message:\n{encodedMessage}");
                return encodedMessage;
            }

            static void Decode(string encodedMessage, string keyword)
            {
                keyword = keyword.ToUpper();
                encodedMessage = encodedMessage.ToUpper();

                int[] encodedMessageCharValues = new int[encodedMessage.Length];
                int[] keywordAlphabetValues = new int[keyword.Length];
                int[] decodedValues = new int[encodedMessage.Length];
                char[] decodedMessageChar = new char[encodedMessage.Length];

                for (int i = 0; i < keyword.Length; i++)
                {
                    keywordAlphabetValues[i] = AlphabetToIndex[keyword[i]];
                }

                for (int i = 0; i < encodedMessage.Length; i++)
                {
                    encodedMessageCharValues[i] = AlphabetToIndex[encodedMessage[i]];
                }

                for (int i = 0; i < encodedMessage.Length; i++)
                {
                    decodedValues[i] = (encodedMessageCharValues[i] - keywordAlphabetValues[i % keyword.Length] + 26) % 26;
                }

                for (int i = 0; i < encodedMessage.Length; i++)
                {
                    decodedMessageChar[i] = IndexToAlphabet[decodedValues[i]];
                }

                string decodedMessage = new string(decodedMessageChar);
                Console.WriteLine($"Decoded message:\n{decodedMessage}");
            }
        

    }
}
