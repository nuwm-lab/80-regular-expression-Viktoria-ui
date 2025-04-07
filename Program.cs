using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = @"Today is 01/04/2025 and tomorrow will be 02-04-2025.
Other dates include 15/03/2023, 30-12-2024 and even 07/07/2021.
Invalid dates like 99/99/9999 should not be matched.";


        string pattern = @"\b(0[1-9]|[12][0-9]|3[01])[/-](0[1-9]|1[0-2])[/-](19|20)\d{2}\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Знайдені дати:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
