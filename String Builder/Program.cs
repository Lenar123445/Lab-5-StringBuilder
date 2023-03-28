//Задание 1 String Builder

using System;
using System.Text;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            while (true)
            {
                Console.Write("Введите строку: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;

                string[] words = input.Split(' ');
                text.Append(words[0]).Append(" ");

                for (int i = 1; i < words.Length; i++)
                {
                    if (i % 2 == 1)
                        text.Append(ReverseWord(words[i])).Append(" ");
                }

                text.Append(". ");
            }

            Console.WriteLine("Результат: ");
            Console.WriteLine(text.ToString());
        }

        static string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}


//Задание 2

/*using System;
using System.Text;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "Киев Нью-Йорк Амстердам Вена Мельбурн";
            string arrangedWords = ArrangeWords(words);
            Console.WriteLine(arrangedWords);
        }

        static string ArrangeWords(string words)
        {
            StringBuilder result = new StringBuilder();

            string[] wordList = words.Split(' ');
            int length = wordList.Length;
            result.Append(wordList[0]).Append(" ");
            bool[] used = new bool[length];
            used[0] = true;

            int currentIndex = 0;
            int count = 1;
            while (count < length)
            {
                for (int i = 1; i < length; i++)
                {
                    if (!used[i] && char.ToLower(wordList[currentIndex][wordList[currentIndex].Length - 1]) == char.ToLower(wordList[i][0]))
                    {
                        result.Append(wordList[i]).Append(" ");
                        currentIndex = i;
                        used[i] = true;
                        count++;
                        break;
                    }
                }
            }

            return result.ToString();
        }
    }
}
*/