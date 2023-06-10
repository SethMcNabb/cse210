using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 101);
        
        while (true)
        {
            Console.WriteLine("What is your guess? ");
            string UserInput2 = Console.ReadLine();
            int Guess = int.Parse(UserInput2);

            if (Guess > MagicNumber)
            {
                Console.WriteLine("Too high.");
            }
            else if (Guess < MagicNumber)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("You got it!");
                break;
            }
        }
    }
}