using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int myguess = -1;

        while (myguess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            myguess = int.Parse(guess);
        
        
            if (myguess < magicNumber)
                Console.WriteLine("Higher");

            else if (myguess > magicNumber)
                Console.WriteLine("Lower");

            else 
            Console.WriteLine("You Guessed it!");
        }
        
       
    }
}