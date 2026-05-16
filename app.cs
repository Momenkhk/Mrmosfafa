using System;
using System.Collections.Generic;

class Program
{
    static string MakeSurprise(string gift, string message)
    {
        return $"Your surprise: {gift} - {message}";
    }

    static void Main()
    {
        var gifts = new Dictionary<int, string>
        {
            {1, "Flowers"}, {2, "Book"}, {3, "Thank You Card"}, {4, "Chocolate"}
        };

        var messages = new Dictionary<int, string>
        {
            {1, "Thank you, teachers."},
            {2, "You inspire us every day!"},
            {3, "Teachers make the world brighter!"}
        };

        Console.WriteLine("Teacher Surprise Generator (C#)");
        Console.Write("Choose gift (1-4): ");
        if (!int.TryParse(Console.ReadLine(), out int giftChoice) || !gifts.ContainsKey(giftChoice))
        {
            Console.WriteLine("Invalid gift choice.");
            return;
        }

        Console.Write("Choose message (1-3): ");
        if (!int.TryParse(Console.ReadLine(), out int messageChoice) || !messages.ContainsKey(messageChoice))
        {
            Console.WriteLine("Invalid message choice.");
            return;
        }

        Console.WriteLine(MakeSurprise(gifts[giftChoice], messages[messageChoice]));
    }
}
