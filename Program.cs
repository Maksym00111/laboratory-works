using System;
using System.Text;

public class GFG
{
    static public void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.Write("Введіть перше слово: ");
        string a = Console.ReadLine();

        Console.Write("Введіть друге слово: ");
        string b = Console.ReadLine();

        Console.Write("Введіть третє слово: ");
        string c = Console.ReadLine();

        string str = a + b + c;
        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach (char p in str)
        {
            if (count.ContainsKey(p))
            {
                count[p]++;
            }
            else
            {
                count.Add(p, 1);
            }
        }

        Console.Write("Букви, що зустрічаються в усіх словах лише 1 раз: ");

        foreach (KeyValuePair<char, int> kvp in count)
        {
            if (kvp.Value == 1)
            {
                Console.Write("{0}, ", kvp.Key);
            }
        }
        Console.WriteLine();
    }
}