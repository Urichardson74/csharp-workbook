
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
            string word = Console.ReadLine();
            Console.WriteLine(TranslateWord(word));
            // leave this command at the end so your program does not close automatically
            
            Console.ReadLine();
        }
        
        public static string TranslateWord(string word)
        {
            // your code goes here
            int vowelIndex = word.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u'});

            string firstPart = word.Substring(0,vowelIndex);
            string secondPart = word.Substring(vowelIndex);
            word = word.ToLower();

            if (vowelIndex == 0)
            {
                return word + "yay";
            }
            else
            {
                return secondPart + firstPart + "ay";
            }

            string[] words = word.Split(' ');
            string[] sentence = new string[] {};
            for (int i =0; i < words.Length; i++)
            {
                sentence[i] = words[i];
            }
            string combined = string.Join(' ', sentence);
          
            return word;
        }
    }
}