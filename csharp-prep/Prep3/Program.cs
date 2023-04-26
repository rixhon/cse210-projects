using System;

class Program
{
    static void Main(string[] args)
    {
        // generate random number
        Random rand = new Random();
        int magicNumber = rand.Next(1, 101);

        int guess = -1;

        do
        {
            //ask a user guess
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            // user higher or lower
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            //looping  
        } while (guess != magicNumber);
    }
}