using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

public class GFG
{
    static public void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        int N = 9 / 2;

        using (FileStream fstream = File.OpenRead("D:\\C# projects\\file.txt"))
        {
            byte[] array = new byte[fstream.Length];
            fstream.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);

            Console.WriteLine("переважні елементи тексту: ");
            Console.WriteLine();

            char[] separators = { '.', ',', '!', '?', ';', ':', ' ' };
            string[] words = textFromFile.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            foreach (var word in wordCounts)
            {
                if (word.Value >= N)
                {
                    Console.WriteLine("{0}: {1}", word.Key, word.Value);
                }
            }
        }
    }
}