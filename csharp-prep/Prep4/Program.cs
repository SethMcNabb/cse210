using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when done. ");
        while (true)
        {
            string UserInput = Console.ReadLine();
            int Number = int.Parse(UserInput);
            if (Number != 0 )
            {
                Console.WriteLine("Enter a number: ");
                Numbers.Add(Number);
            }
            else 
            {
                break;
            }    
        }    
        int Sum = Numbers.Sum();
        double Average = Numbers.Average();
        int Max = Numbers.Max();
        Console.WriteLine($"The sum is {Sum}");
        Console.WriteLine($"The average is {Average}");
        Console.WriteLine($"The max is {Max}");

    }
}