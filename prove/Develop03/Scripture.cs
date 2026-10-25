class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;
    private Random _random = new Random();
    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(book, chapter, verse);
        _words = ConvertToWordList(text);

    }
    public Scripture(string book, int chapter, int startverse, int endverse, string text)
    {
        _reference = new ScriptureReference(book, chapter, startverse, endverse);
        _words = ConvertToWordList(text);
    }

    public void ShowScripture()
    {
        Console.Write(_reference.GetDisplayText() + " - ");
        foreach(Word word in _words)
        {
            word.Display();
        }
    }    

    public void HideRandomWords(int count)
    {
        for(int i = 0; i<count; i++)
        {
            if (IsCompletelyHidden())
            {
                return;
            }
            int index = _random.Next(_words.Count);
            while (_words[index].IsHidden())
            {
                index = _random.Next(_words.Count);
            }
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

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