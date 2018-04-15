using System;
using System.Threading;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Variables//
            string torch = "";
            string flint = "";
            
           Console.WriteLine("Welcome to the Tunnel of Terror");
           Thread.Sleep(3000); 
           Console.WriteLine("You enter a dark tunnel out of curiosity. With the small light from the entrace you see a small shine on an object on the floor do you pick it up? y or n?");
           flint = Console.ReadLine();
           if (flint == "y")
           {
               Console.WriteLine("You reach down and find a piece of flint.");
           }
            else if (flint == "n")
            {
                Console.WriteLine("Not wanting to touch something you can't see clearly you move on.");
            }
          Thread.Sleep(1000);
          Console.WriteLine("As you move further your foot touches an object on the floor do you pick it up? y or n?");
           torch = Console.ReadLine();
           
           if (torch == "y")
           {
               Console.WriteLine("You reach down and pick up the object, as you feel the object you realize it is a torch.");
           }
            else if (torch == "n")
            {
                Console.WriteLine("Not wanting to touch something you can't see clearly you move on.");
            }
            Thread.Sleep(1000);

               if (torch == "y" & flint == "y")
           {
               Console.WriteLine("You strike the flint off another hard stone and manage to light the torch.");
           }
            else if (torch == "n" || flint == "n")
            {
                Console.WriteLine("As you stumble into the darkness you slip on rubble the next thing you know you feel yourself falling and falling....do.");
            }

       
        }   

    }
}
