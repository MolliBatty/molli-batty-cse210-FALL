using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        Console.Write("What is your grade?");
        grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine($"You have an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"You have a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"You have a C");
        }
        else if(grade >= 60)
        {
            Console.WriteLine($"You have a D");
        }
        else
        {
            Console.WriteLine($"You have failed");
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