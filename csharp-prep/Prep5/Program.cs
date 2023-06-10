using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int sqdNumber = SquareNumber(favNumber);
        DisplayResult(userName,sqdNumber);

    }  
     static void DisplayWelcome()
    {
        Console.WriteLine("Welcome!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;        
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int favoriteNumber = int.Parse(userInput);
        return favoriteNumber;
    }
    static int SquareNumber(int favNumber)
    {
        int sqdNumber = favNumber * favNumber;
        return sqdNumber;
    }
    static void DisplayResult(string userName, int sqdNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqdNumber}.");
    }
}