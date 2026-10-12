using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        

        Journal myJournal = new Journal();

        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {   
                case 1:
                    myJournal.CreateEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("Enter the filename: ");
                    string saveFile = Console.ReadLine();
                    myJournal.WriteToFile(saveFile);
                    break;
                case 4:
                    Console.Write("Enter the filename: ");
                    string readFile = Console.ReadLine();
                    myJournal.ReadFromFile(readFile);
                    break; 
            }
        }

        // obtain file name()
    }
}