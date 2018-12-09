using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumber = new Random();
            int secret = ranNumber.Next(1, 100);
            int guess = 0;
            
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("{0}", secret);

            while (guess != secret)
            {
                Console.Write("Guess: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < secret)
                {
                    Console.WriteLine("No, the number I'm thinking is higher than that number.");
                }
                if (guess > secret)
                {
                    Console.WriteLine("No, the number I'm thinking is lower than that number.");
                    
                }
            }
            if (guess == secret)
            {
                Console.WriteLine("You got it!");

            }
        }
    }
}