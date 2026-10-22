using System.Runtime.CompilerServices;

class Scripture
{
    private List<Word> _words;
    // ADD SCRIPTURE REFERENCE
    public Scripture(string bookName, int chapter, int verse, string text)
    {
       _words = ConvertToWordList(text);
       _words[7].Hide();
    }
    public Scripture(string bookName, int chapter, int startverse, int endverse, string text)
    {
        
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }
    // TODO ADD constructor for scripture reference
    




    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            // Console.WriteLine(w);
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }

        return tempWordList;
    }

}