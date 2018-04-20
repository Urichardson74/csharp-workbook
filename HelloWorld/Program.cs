using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ukiah!");

            string name = "";
            int age = 0;
            int year = 0;
            string job = "";
            int salary = 0;
            int expenses = 0;
            string city = "";
            int zip = 0;
        
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your job title: ");
            job = Console.ReadLine();
            Console.WriteLine("Please enter your monthly salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your monthly expenses: ");
            expenses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your city: ");
            city = Console.ReadLine();
            Console.WriteLine("Please enter your zip code: ");
            zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello! Your name is {0} and You are {1} years old. You were born in {2}.  You are a {3}, you make ${4} monthly and your monthly expenses are ${5}.  You have ${6} in expendable income per month.  You live in {7} in the {8} zip code.  BIG BROTHER is watching you!", name, age, year-age, job, salary, expenses, salary-expenses, city, zip);
        }
    }
}
