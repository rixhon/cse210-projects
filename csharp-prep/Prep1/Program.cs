using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user what is your first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask the user what is their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Show the full name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}