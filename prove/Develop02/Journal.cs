using System.Collections.Generic;
class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateEntry()
    {
        PromptGenerator generator = new PromptGenerator();

        string prompt = generator.GetRandomPrompt();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry(prompt, response, date);

        _entries.Add(newEntry);
    }

    public void WriteToFile(string filename)
    {
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        string[] lines =System.IO.File.ReadAllLines(filename);
        _entries.Clear();
        foreach(string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry(prompt, response, date);

            _entries.Add(entry);
        }
    }
}

