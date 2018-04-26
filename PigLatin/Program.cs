
using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            Console.WriteLine("Welcome to the Pig Latin Translator");
            Console.WriteLine("Please enter a word or sentence.");
            string input = Console.ReadLine();
            Console.WriteLine(TranslateSentence(input));
            // leave this command at the end so your program does not close automatically
            
            Console.ReadLine();
        }
        
        public static string TranslateWord(string word)
        {
            // your code goes here
            int vowelIndex = word.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u', 'y'});

            string firstPart = word.Substring(0,vowelIndex);
            string secondPart = word.Substring(vowelIndex);
            word = word.ToLower();

            if (vowelIndex <= 0)
            {
                return word + "yay";
            }
            else
            {
                return secondPart + firstPart + "ay";
            }
        }
            
        public static string TranslateSentence(string sentence) 
        {
            string[] words = sentence.Split(' ');
            string[] translatedwords = new string[words.Length];
            for (int i =0; i < words.Length; i++)
            {
                translatedwords[i] = TranslateWord(words[i]);
            }
            return String.Join(" ", translatedwords);
          
        }  
        
        
    }
}