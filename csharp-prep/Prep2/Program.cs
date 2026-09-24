using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        Console.Write("What is your grade? ");
        grade = int.Parse(Console.ReadLine());
        int lastDigit = grade % 10;
        string sign;

        if (grade >= 90)
        {
            if (lastDigit >= 7)
            {
               sign = ""; 
            }
            else if(lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            Console.WriteLine($"You have an A{sign}.");
        }
        else if (grade >= 80)
        {
            if (lastDigit >= 7)
            {
               sign = "+"; 
            }
            else if(lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            Console.WriteLine($"You have a B{sign}.");
        }
        else if (grade >= 70)
        {
            if (lastDigit >= 7)
            {
               sign = "+"; 
            }
            else if(lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            Console.WriteLine($"You have a C{sign}.");
        }
        else if(grade >= 60)
        {
            if (lastDigit >= 7)
            {
               sign = "+"; 
            }
            else if(lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            Console.WriteLine($"You have a D{sign}.");
        }
        else
        {
            
            Console.WriteLine($"You have an F.");
        }

        if (grade >= 70)
        {
            
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("YOu did not pass the class. :(");
        }
    }
}