using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

public class GFG
{
    [Flags]
    enum goods
    { 
        Футболка = 1,
        Вітровка,
        Кепка,
        Туфлі,
        Кросівки,
        Сандалі,
        Телевізор,
        Смартфон,
        Монітор
    }
    static public void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.WriteLine("1. Футболка");
        Console.WriteLine("2. Вітровка");
        Console.WriteLine("3. Кепка");
        Console.WriteLine("4. Туфлі");
        Console.WriteLine("5. Кросівки");
        Console.WriteLine("6. Сандалі");
        Console.WriteLine("7. Телевізор");
        Console.WriteLine("8. Смартфон");
        Console.WriteLine("9. Монітор");

        Console.WriteLine();
        Console.WriteLine("Виберіть товар(цифрами через кому):");

        string good = Console.ReadLine();

        if (good == "")
        {
            Console.WriteLine("Помилка: ви не ввели жодного товару");
            return;
        }
        else if (good.Contains("."))
        {
            Console.WriteLine("Помилка: введення має містити кому, а не крапку");
            return;
        }

        string[] numbers = good.Split(',');

        Console.WriteLine();
        Console.WriteLine("Вибрані товари(категорія - товар):");

        if (numbers.Contains("1") || numbers.Contains("2") || numbers.Contains("3"))
        {
            Console.WriteLine("Одяг:");
        }

        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int selection))
            {
                if (selection >= (int)goods.Футболка && selection <= (int)goods.Кепка)
                {
                    Console.WriteLine((goods)selection);
                }
            }
        }

        Console.WriteLine();

        if (numbers.Contains("4") || numbers.Contains("5") || numbers.Contains("6"))
        {
            Console.WriteLine("Взуття:");
        }

        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int selection))
            {
                if (selection >= (int)goods.Туфлі && selection <= (int)goods.Сандалі)
                {
                    Console.WriteLine((goods)selection);
                }
            }
        }

        Console.WriteLine();

        if (numbers.Contains("7") || numbers.Contains("8") || numbers.Contains("9"))
        {
            Console.WriteLine("Електротовари:");
        }

        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int selection))
            {
                if (selection >= (int)goods.Телевізор && selection <= (int)goods.Монітор)
                {
                    Console.WriteLine((goods)selection);
                }
                else if (selection < 1 || selection > 9)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Товар з номером {selection} не знайдено");
                }
            }
        }


        Console.WriteLine();
        Console.WriteLine("Автор програми Кучеренко Максим");
        Console.WriteLine();
    }
}