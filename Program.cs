using System;

namespace Strings_Heath_Karter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input a character
            Console.Write("Please input a character: ");
            char myChar = Console.ReadKey().KeyChar;  // Read the character input by the user

            // Check if the character is a letter
            bool isLetter = Char.IsLetter(myChar);  // Use Char.IsLetter() to check if it's a letter

            // Print out if the character is a letter
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}");

            // Ask the user to input a string of words
            Console.Write("\nPlease input a string of words: ");
            string myString = Console.ReadLine();  // Read the string input by the user

            // Ask the user to input a word to search for
            Console.Write("Please input a word to search for: ");
            string searchWord = Console.ReadLine();  // Read the word input by the user

            // Check if the string contains the word
            bool containsWord = myString.Contains(searchWord);  // Use Contains() method to check if word is in string

            // Print out whether the word exists in the string or not
            Console.WriteLine($"{searchWord} exists in {myString}: {containsWord}");
        }
    }
}
