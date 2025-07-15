using System;

class stringmanip
{
    public static void main(string[] args)
    {

        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        Console.WriteLine("Uppercase: " + input.ToUpper());
        Console.WriteLine("Lowercase: " + input.ToLower());
        Console.WriteLine("Reversed: " + Reverse(input));

    }
    static string Reverse(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
