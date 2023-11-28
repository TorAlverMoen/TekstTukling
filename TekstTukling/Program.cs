using System;

class Program
{
    static private string ReverseText(string inText)
    {
        char[] charArray = inText.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static private string ChangeWord(string inText)
    {
        bool doesWordContainE = inText.Contains("e");
        if (doesWordContainE)
        {
            return inText.Replace("e", "a");
        }
        return string.Empty;
    }

    static void DisplayResult(string inText)
    {
        Console.Write("Result text: ");
        Console.WriteLine(inText);
    }

    static string GetText()
    {
        Console.Write("Type in text: ");
        return Console.ReadLine();
    }

    static private void Menu()
    {
        Console.WriteLine("Tekst tukling!");
        Console.WriteLine("1. Rotate Text");
        Console.WriteLine("2. Change word");
        Console.WriteLine(String.Empty);
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                DisplayResult(ReverseText(GetText()));
                break;
            case "2":
                DisplayResult(ChangeWord(GetText()));
                break;
            default:
                Console.WriteLine("WTF?");
                break;
        }
    }

    static void Main()
    {
        Menu();
    }
}