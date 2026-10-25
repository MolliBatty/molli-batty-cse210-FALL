using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture("Moses", 1, 39,
        "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man.");

        while (!myScripture.IsCompletelyHidden())
        {
            Console.Clear();
            myScripture.ShowScripture();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                return;
            }
            myScripture.HideRandomWords(3);
        }

        Console.Clear();
        myScripture.ShowScripture();
        Console.WriteLine();
    }
}