using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float grade = int.Parse(userInput);
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is a {letter}.");
        if (grade >= 70)
        {
            Console.WriteLine("Great job! You passed the class.");
        }
        else{
            Console.WriteLine("You didn't pass, you'll get it next time!");
        }


    }
}