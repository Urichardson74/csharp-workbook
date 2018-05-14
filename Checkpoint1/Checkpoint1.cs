using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling all functions
            CountByThree();
            AddSum();
            Factorial();
            RanNum();
            HighestNum();
    
        }
        //1 divisible by 3
        public static void CountByThree()
        {
            int count = 0;
            for (int i = 1; i < 101; i++)
            {
               if (i % 3 == 0)
                {
                    count ++;   
                }
        
            } 

            Console.WriteLine(count);
            Console.ReadLine();


        }

        //2 Adding numbers
        public static void AddSum()
        {   
            bool play = true;
            int sum = 0;
            while (play)
            {
                Console.WriteLine("Please enter a number, or 'ok' to get your total");
                string input = Console.ReadLine().ToLower();
                if (input == "ok" && sum == 0)
                {
                    Console.WriteLine("Thank you for not playing!");
                    play = false;
                    break;
                }
                else if (input == "ok" && sum != 0)
                {
                    
                    Console.WriteLine("Thanks for playing your total was {0}", sum);
                    break; 
                }
                else 
                {
                    sum += Convert.ToInt32(input);
                }
            }
        }
        // 3 factorial
        public static void Factorial()
        {   
            int number = 0;
            string input = "";
            //Taking input & converting to integer
            Console.WriteLine("Please enter a whole number under 30");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            int results = number;

            for ( int i = 1; i < number; i++)
            {
                results = results * i;
            }
            Console.WriteLine("{0}! = {1}", number, results);
            Console.ReadLine();
        }

        //4 Random number
        static public void RanNum()
        {
           
            Random rnd = new Random();
            int rannum = rnd.Next(1, 11);
            int turns = 3;
            int numguess = 0;

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                string guess = Console.ReadLine();
                numguess = Convert.ToInt32(guess);

                if (turns == 0)
                {
                    Console.WriteLine("You are out of turns, the number was: " + (rannum));
                    break;

                }
                else if (numguess == rannum)
                {
                    Console.WriteLine("You guessed correctly!");
                    break;
                }
                else
                {
                Console.WriteLine("You have " + (turns) + " chance(s) remaining.");   
                turns --;   
                }
                
            }   
        }
        // 5 Highest Number 
         public static void HighestNum()
        {   
            
            int high = 0;


            Console.WriteLine("Please enter a series of numbers separated by a comma");
            string [] entries = Console.ReadLine().Split(',');
            int[] nums = Array.ConvertAll(entries, int.Parse); 
            //converting strings to ints above
            foreach (int num in nums)
                {   
                    //determining highest number below
                    if (num > high)
                    {
                        high = num;
                    }
                }
            Console.WriteLine("The highest nunber is {0}.", high);
            
        }           
    }

}
