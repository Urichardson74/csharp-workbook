using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            string hand2 = "";
            Console.WriteLine(CompareHands(hand1, hand2));
            Random compchoice = new Random();
            int x = compchoice.Next(0,3);
              if (x == 0)
            {
               
                hand2 = "Rock";
            }
            if (x == 1)
            {
           
                hand2 = "Paper";
            }
            if (x == 2)
            {
             
               hand2 = "Scissors";
            }
           
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();

        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            return hand1 + ' ' + hand2;
        }
    }
}
