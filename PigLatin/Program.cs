using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            Console.WriteLine("Please enter a word");
            string word =Console.ReadLine();
            int = vowelIndex = -1;

            if ( ( word.IndexOf('a') > -1 && word.IndexOf('a') < vowelIndex ) || vowelIndex === -1 ) {
            vowelIndex = word.indexOf('a');
            }

            if ( ( word.IndexOf('e') > -1 && word.IndexOf('e') < vowelIndex ) || vowelIndex === -1 ) {
            vowelIndex = word.IndexOf('e');
            }

            if ( ( word.IndexOf('i') > -1 && word.IndexOf('i') < vowelIndex ) || vowelIndex === -1 ) {
            vowelIndex = word.IndexOf('i');
            }
              if ( ( word.IndexOf('o') > -1 && word.IndexOf('o') < vowelIndex ) || vowelIndex === -1 ) {
            vowelIndex = word.indexOf('o');
            }

            if ( ( word.IndexOf('u') > -1 && word.IndexOf('u') < vowelIndex ) || vowelIndex === -1 ) {
            vowelIndex = word.IndexOf('u');
            }

            if ( ( word.IndexOf('y') > -1 && word.IndexOf('y') < vowelIndex ) || vowelIndex === -1 ) {
            vowelIndex = word.IndexOf('y');
            }

            string firstPart = word.Substring(0, vowelIndex);
            string restWord = word.substring(vowelIndex)
             if (vowelIndex == 0) 
            {
                word += "yay";
            } else {
                word = secondPart + firstPart + "ay";
            }
            Console.WriteLine(word);

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
            }
        
        public static string TranslateWord(string word)
        {
            // your code goes here
            return word;
        }
    }
}
