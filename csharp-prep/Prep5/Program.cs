using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string myName = Console.ReadLine(); 
        return myName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("What year were you born? ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int squaredNumber)
    {
        return squaredNumber * squaredNumber;
    }

    static void DisplayResult(string userName, int squaredNumber, int birthYear)
    {
        int age = DateTime.Now.Year - birthYear;

        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{userName}, you will turn {age} this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber, birthYear);
    }
}