using System;
using System.Text;

namespace _20._04task1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string normal = Capitalized("bU tasKI metHodla yAzmAliSiz");
                Console.WriteLine(normal);
                Console.WriteLine("bU tasKI metHodla yAzmAliSiz");





            }
            static string Capitalized(string sentence)
            {

                StringBuilder stringBuilder = new StringBuilder();
                sentence = sentence.ToLower();
                string[] words = sentence.Split();

                foreach (string word in words)
                {
                    stringBuilder.Append(char.ToUpper(word[0]));
                    for (int i = 1; i < word.Length; i++)
                    {
                        stringBuilder.Append(word[i]);
                    }
                    if (word != words[words.Length - 1])
                    {
                        stringBuilder.Append(" ");
                    }
                }

                return stringBuilder.ToString();

            }

        }
    }
}
