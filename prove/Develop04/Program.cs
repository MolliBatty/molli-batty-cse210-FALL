using System;


// Exceeding requirements:
// 1. Added a session log that counts how many times each activity
//    was completed and shows a summary when the user quits.
// 2. Added extra prompts to the Reflection and Listing activities.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity Bactivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."); 
                Bactivity.RunActivity();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectionActivity Ractivity = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Ractivity.RunActivity();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                ListingActivity Lactivity = new ListingActivity("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Lactivity.RunActivity();
                listingCount++;
            }
        }

        Console.Clear();
        Console.WriteLine("Session Summary:");
        Console.WriteLine($"Breathing: {breathingCount} time(s)");
        Console.WriteLine($"Reflection: {reflectionCount} time(s)");
        Console.WriteLine($"Listing: {listingCount} time(s)");
        Console.WriteLine("Thanks for taking time to be mindful!");
    }
}