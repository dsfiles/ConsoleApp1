using System;
using System.Collections.Generic;
public class Example
{
    public static void Main()
    {
        // Create the link list.
        string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
        var sentence = new LinkedList<string>(words);
        Display(sentence, "The linked list values:");  
    }
    private static void Display(LinkedList<string> words, string test) {
        Console.WriteLine(test);
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.Write("\n\n");
    }
} // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-5.0
